using Sitecore.Data.Fields;
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

        public string Player
        {
            get { return RenderingItem["Twitter Card Player"]; }
        }

        public string PlayerHeight
        {
            get { return RenderingItem["Twitter Card Player Height"]; }
        }

        public string PlayerWidth
        {
            get { return RenderingItem["Twitter Card Player Width"]; }
        }

        public string PlayerStream { get; private set; }

        public bool ShowPlayerStream
        {
            get { return !String.IsNullOrWhiteSpace(PlayerStream); }
        }

        public string PlayerStreamContentType
        {
            get { return RenderingItem["Twitter Card Player Stream Content Type"]; }
        }

        public bool ShowPlayerStreamContentType
        {
            get { return ShowPlayerStream && !String.IsNullOrWhiteSpace(PlayerStreamContentType); }
        }

        public override void Initialize(Mvc.Presentation.Rendering rendering)
        {
            base.Initialize(rendering);

            PlayerStream = GetRenderingItemLinkFieldAbsoluteUrl("Twitter Card Player Stream");
        }
    }
}