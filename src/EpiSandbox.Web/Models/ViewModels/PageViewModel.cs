using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiSandbox.Web.Models.ViewModels
{
    public abstract class PageViewModel
    {
        public string PageTitle { get; set; }
    }

    public class PageViewModel<T> : PageViewModel
    {
        public PageViewModel(T page)
        {
            Page = page;
        }

        public T Page { get; }
    }
}