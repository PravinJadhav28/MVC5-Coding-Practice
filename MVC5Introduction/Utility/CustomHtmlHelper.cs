using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MVC5Introduction.Utility
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString Button(this HtmlHelper helper,string type,string value)
        {
            //build html tag
            TagBuilder input = new TagBuilder("input");
            input.Attributes.Add  ("type", type);
            input.Attributes.Add("value", value);

            return new MvcHtmlString(input.ToString());

        }

    }
}