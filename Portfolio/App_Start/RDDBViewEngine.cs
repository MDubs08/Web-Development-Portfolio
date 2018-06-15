using System.Linq;
using System.Web.Mvc;

namespace Portfolio.App_Start
{
    public class RDDBViewEngine : RazorViewEngine
    {
        private static readonly string[] NewPartialViewFormats =
        {
            "~/Views/{1}/Widgets/{0}.cshtml",
            "~/Views/Shared/Widgets/{0}.cshtml",
            "~/Views/{1}/Blackjack/{0}.cshtml",
            "~/Views/Design/Blackjack/{0}.cshtml"
        };

        public RDDBViewEngine()
        {
            PartialViewLocationFormats = base.PartialViewLocationFormats.Union(NewPartialViewFormats).ToArray();
        }
    }
}