using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisSocialNetworks.Library.Models;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    public abstract class TwitterCardModel : BaseRenderingModel
    {
        public abstract string CardType { get; }

        public string Site
        {
            get
            {
                return GetFallbackField("Twitter Card Site", "Twitter Card Site Override");
            }
        }

        public bool ShowSite
        {
            get
            {
                return !String.IsNullOrWhiteSpace(Site);
            }
        }

        public string SiteId
        {
            get
            {
                return GetFallbackField("Twitter Card Site Id", "Twitter Card Site Id Override");
            }
        }

        public bool ShowSiteId
        {
            get
            {
                return !String.IsNullOrWhiteSpace(SiteId);
            }
        }

        public string ImageUrl
        {
            get
            {
                return GetRenderingItemImageFieldAbsoluteUrl("Twitter Card Image");
            }
        }

        public bool ShowImageUrl
        {
            get
            {
                return !String.IsNullOrWhiteSpace(ImageUrl);
            }
        }

        public string Title
        {
            get { return RenderingItem["Twitter Card Title"]; }
        }

        public bool ShowTitle
        {
            get { return !String.IsNullOrWhiteSpace(Title); }
        }

        public string Description
        {
            get { return RenderingItem["Twitter Card Description"]; }
        }

        public bool ShowDescription
        {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }
    }
}