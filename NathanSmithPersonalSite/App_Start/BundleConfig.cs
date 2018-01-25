using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace NathanSmithPersonalSite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #if !DEBUG
                bundles.UseCdn = true;
                BundleTable.EnableOptimizations = true;

            #endif

            bundles.Add(new StyleBundle(
                "~/bundles/bootstrapcss",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
            );

            bundles.Add(new ScriptBundle(
                "~/bundles/bootstrapjs",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js")
            );
        }
    }
}