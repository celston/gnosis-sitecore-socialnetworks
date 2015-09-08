using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisSocialNetworks.Library.Mvc.Models;
using Sitecore.GnosisSocialNetworks.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    [SitecoreFieldNamePrefix("Call to Action")]
    public class CallToActionModel : BaseRenderingModel
    {
        [SitecoreField]
        public HtmlString Heading { get; set; }
        [SitecoreField]
        public HtmlString Image { get; set; }
        [SitecoreField]
        public HtmlString Body { get; set; }
        [SitecoreField]
        public HtmlString Link { get; set; }
        [SitecoreLinkFieldUrl("Link")]
        public string LinkUrl { get; set; }
    }
}