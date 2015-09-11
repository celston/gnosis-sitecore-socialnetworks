using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisSocialNetworks.Library.Mvc.Models;
using Sitecore.GnosisSocialNetworks.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.OpenGraph
{
    [SitecoreFieldNamePrefix("Open Graph")]
    public class OpenGraphBasicModel : BaseRenderingModel
    {
        [SitecoreFieldRaw]
        public string Title { get; set; }
        [SitecoreFieldRaw]
        public string Description { get; set; }
        [SitecoreImageFieldAbsoluteUrl("Image")]
        public string ImageUrl { get; set; }
        [SitecoreImageFieldHeight("Image")]
        public int ImageHeight { get; set; }
        [SitecoreImageFieldWidth("Image")]
        public int ImageWidth { get; set; }
        [SitecoreImageFieldMimeType("Image")]
        public string ImageMimeType { get; set; }

        public string Locale
        {
            get { return rendering.Item.Language.CultureInfo.TextInfo.CultureName.Replace("-", "_"); }
        }

        public bool ShowDescription
        {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }

        public bool ShowImage
        {
            get { return !String.IsNullOrWhiteSpace(ImageUrl); }
        }
        
    }
}