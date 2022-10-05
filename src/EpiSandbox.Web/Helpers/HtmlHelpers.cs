using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EpiSandbox.Web.Business;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;
using EPiServer;

namespace EpiSandbox.Web.Helpers
{
    public static class HtmlHelpers
    {
        public static IHtmlString MenuList(
            this HtmlHelper helper,
            ContentReference rootLink,
            Func<MenuItem, HelperResult> itemTemplate = null,
            bool includeRoot = false,
            bool requireVisibleInMenu = true,
            bool requirePageTemplate = true)
        {
            itemTemplate = itemTemplate ?? GetDefaultItemTemplate(helper);
            var currentContentLink = helper.ViewContext.RequestContext.GetContentLink();
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            Func<IEnumerable<PageData>, IEnumerable<PageData>> filter =
                pages => pages.FilterForDisplay(requirePageTemplate, requireVisibleInMenu);

            var pagePath = contentLoader.GetAncestors(currentContentLink)
                .Reverse()
                .Select(x => x.ContentLink)
                .SkipWhile(x => !x.CompareToIgnoreWorkID(rootLink))
                .ToList();

            var menuItems = contentLoader.GetChildren<PageData>(rootLink)
                .FilterForDisplay(requirePageTemplate, requireVisibleInMenu)
                .Select(x => CreateMenuItem(x, currentContentLink, pagePath, contentLoader, filter))
                .ToList();

            if (includeRoot)
            {
                menuItems.Insert(0, CreateMenuItem(contentLoader.Get<PageData>(rootLink), currentContentLink, pagePath, contentLoader, filter));
            }

            var buffer = new StringBuilder();
            var writer = new StringWriter(buffer);
            foreach (var menuItem in menuItems)
            {
                itemTemplate(menuItem).WriteTo(writer);
            }

            return new MvcHtmlString(buffer.ToString());
        }

        private static MenuItem CreateMenuItem(PageData page, ContentReference currentContentLink, List<ContentReference> pagePath, IContentLoader contentLoader, Func<IEnumerable<PageData>, IEnumerable<PageData>> filter)
        {
            var menuItem = new MenuItem(page)
            {
                Selected = page.ContentLink.CompareToIgnoreWorkID(currentContentLink) ||
                                pagePath.Contains(page.ContentLink),
                HasChildren =
                        new Lazy<bool>(() => filter(contentLoader.GetChildren<PageData>(page.ContentLink)).Any())
            };
            return menuItem;
        }
        private static Func<MenuItem, HelperResult> GetDefaultItemTemplate(HtmlHelper helper)
        {
            return x => new HelperResult(writer => writer.Write(helper.PageLink(x.Page)));
        }

        public class MenuItem
        {
            public MenuItem(PageData page)
            {
                Page = page;
            }
            public PageData Page { get; set; }
            public bool Selected { get; set; }
            public Lazy<bool> HasChildren { get; set; }
        }
    }
}