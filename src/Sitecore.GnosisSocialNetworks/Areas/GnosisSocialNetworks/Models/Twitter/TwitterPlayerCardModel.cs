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

        public bool ShowPlayerStream
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card Player Stream"); }
        }

        public bool ShowPlayerStreamContentType
        {
            get { return ShowPlayerStream && !RenderingItemFieldIsNullOrWhitespace("Twitter Card Player Stream Content Type"); }
        }
    }
}