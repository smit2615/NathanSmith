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
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
            );

            bundles.Add(new ScriptBundle(
                "~/bundles/bootstrapjs",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js")
            );

            bundles.Add(new StyleBundle(
                "~/bundles/sitecss")
                .Include(new string[] { "~/Content/Footer.css",
                            "~/Content/Index.css",
                            "~/Content/Navbar.css",
                            "~/Content/Resume.css",
                            "~/Content/Sidebar.css",
                            "~/Content/Site.css"
                        }
                )
            );

            bundles.Add(new ScriptBundle(
                "~/bundles/sitejs")
                .Include(new string[] { "~/Scripts/Navbar.js",
                            "~/Scripts/Resume.js",
                            "~/Scripts/Site.js"
                        }
                )
            );
        }
    }
}