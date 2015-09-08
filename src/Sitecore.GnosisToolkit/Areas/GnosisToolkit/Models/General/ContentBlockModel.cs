using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisSocialNetworks.Library.Attributes;
using Sitecore.GnosisSocialNetworks.Library.Mvc.Models;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    [SitecoreFieldNamePrefix("Content Block")]
    public class ContentBlockModel : BaseRenderingModel
    {
        [SitecoreField]
        public HtmlString Heading { get; set; }
        [SitecoreCheckboxRenderingParameter("Show Heading")]
        public bool ShowHeading { get; set; }
        [SitecoreField]
        public HtmlString Image { get; set; }
        [SitecoreCheckboxRenderingParameter("Show Image")]
        public bool ShowImage { get; set; }
        [SitecoreField]
        public HtmlString Body { get; set; }
    }
}