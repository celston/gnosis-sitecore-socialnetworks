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

        public string AppIphoneName
        {
            get { return RenderingItem["Twitter Card App iPhone Name"]; }
        }

        public bool ShowAppIphoneName
        {
            get { return !String.IsNullOrWhiteSpace(AppIphoneName); }
        }

        public string AppIphoneId
        {
            get { return RenderingItem["Twitter Card App iPhone ID"]; }
        }

        public bool ShowAppIphoneId
        {
            get { return !String.IsNullOrWhiteSpace(AppIphoneId); }
        }

        public string AppIphoneUrl
        {
            get { return RenderingItem["Twitter Card App iPhone URL"]; }
        }

        public bool ShowAppIphoneUrl
        {
            get { return !String.IsNullOrWhiteSpace(AppIphoneUrl); }
        }

        public string AppIpadName
        {
            get { return RenderingItem["Twitter Card App iPad Name"]; }
        }

        public bool ShowAppIpadName
        {
            get { return !String.IsNullOrWhiteSpace(AppIpadName); }
        }

        public string AppIpadId
        {
            get { return RenderingItem["Twitter Card App iPad ID"]; }
        }

        public bool ShowAppIpadId
        {
            get { return !String.IsNullOrWhiteSpace(AppIpadId); }
        }

        public string AppIpadUrl
        {
            get { return RenderingItem["Twitter Card App iPad URL"]; }
        }

        public bool ShowAppIpadUrl
        {
            get { return !String.IsNullOrWhiteSpace(AppIpadUrl); }
        }

        public string AppGooglePlayName
        {
            get { return RenderingItem["Twitter Card App Google Play Name"]; }
        }

        public bool ShowAppGooglePlayName
        {
            get { return !String.IsNullOrWhiteSpace(AppGooglePlayName); }
        }

        public string AppGooglePlayId
        {
            get { return RenderingItem["Twitter Card App Google Play ID"]; }
        }

        public bool ShowAppGooglePlayId
        {
            get { return !String.IsNullOrWhiteSpace(AppGooglePlayId); }
        }

        public string AppGooglePlayUrl
        {
            get { return RenderingItem["Twitter Card App Google Play URL"]; }
        }

        public bool ShowAppGooglePlayUrl
        {
            get { return !String.IsNullOrWhiteSpace(AppGooglePlayUrl); }
        }
    }
}