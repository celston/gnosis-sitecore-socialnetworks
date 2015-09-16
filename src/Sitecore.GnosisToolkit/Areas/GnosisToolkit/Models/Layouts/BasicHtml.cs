using System;

using Sitecore.GnosisSocialNetworks.Library.Mvc.Models;
using Sitecore.GnosisSocialNetworks.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Layouts
{
    public class BasicHtml : BaseRenderingModel
    {
        [SitecoreImageFieldPathWithRootFallback("Favicon", "Favicon")]
        public string FaviconPath { get; set; }
        [SitecoreImageFieldMimeTypeWithRootFallback("Favicon", "Favicon")]
        public string FaviconMimeType { get; set; }

        public bool ShowFavicon
        {
            get { return !String.IsNullOrWhiteSpace(FaviconPath); }
        }

        public string Lang
        {
            get { return rendering.Item.Language.CultureInfo.TwoLetterISOLanguageName; }
        }

        public string CanonicalUrl
        {
            get { return linksHelper.GetItemAbsoluteUrl(rendering.Item); }
        }
    }
}