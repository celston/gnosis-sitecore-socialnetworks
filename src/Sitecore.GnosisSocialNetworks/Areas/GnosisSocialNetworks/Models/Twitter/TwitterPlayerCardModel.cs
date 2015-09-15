using Sitecore.Data.Fields;
using Sitecore.GnosisSocialNetworks.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    public class TwitterPlayerCardModel : TwitterCardModel
    {
        public override string CardType
        {
            get { return "player"; }
        }

        [SitecoreFieldRaw]
        public string Player { get; set; }
        [SitecoreFieldRaw]
        public string PlayerHeight { get; set; }
        [SitecoreFieldRaw]
        public string PlayerWidth { get; set; }
        [SitecoreLinkFieldAbsoluteUrl("Player Stream")]
        public string PlayerStream { get; set; }
        [SitecoreFieldRaw]
        public string PlayerStreamContentType { get; set; }

        public bool ShowPlayerStream
        {
            get { return !String.IsNullOrWhiteSpace(PlayerStream); }
        }
        
        public bool ShowPlayerStreamContentType
        {
            get { return ShowPlayerStream && !String.IsNullOrWhiteSpace(PlayerStreamContentType); }
        }
    }
}