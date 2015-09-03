using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    public class TwitterAppCardModel : TwitterCardModel
    {
        public override string CardType
        {
            get { return "app"; }
        }

        public bool ShowAppIphoneName
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App iPhone Name"); }
        }

        public bool ShowAppIphoneId
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App iPhone ID"); }
        }

        public bool ShowAppIphoneUrl
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App iPhone URL"); }
        }

        public bool ShowAppIpadName
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App iPad Name"); }
        }

        public bool ShowAppIpadId
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App iPad ID"); }
        }

        public bool ShowAppIpadUrl
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App iPad URL"); }
        }

        public bool ShowAppGooglePlayName
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App Google Play Name"); }
        }

        public bool ShowAppGooglePlayId
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App Google Play ID"); }
        }

        public bool ShowAppGooglePlayUrl
        {
            get { return !RenderingItemFieldIsNullOrWhitespace("Twitter Card App Google Play URL"); }
        }
    }
}