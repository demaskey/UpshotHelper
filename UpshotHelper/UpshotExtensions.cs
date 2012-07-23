﻿using System.Web.Mvc;
namespace UpshotHelper
{
    public static class UpshotExtensions
    {
        public static UpshotConfigBuilder UpshotContext(this HtmlHelper htmlHelper)
        {
            return htmlHelper.UpshotContext(false);
        }

        public static UpshotConfigBuilder UpshotContext(this HtmlHelper htmlHelper, bool bufferChanges)
        {
            return new UpshotConfigBuilder(htmlHelper, bufferChanges);
        }
    }
}
