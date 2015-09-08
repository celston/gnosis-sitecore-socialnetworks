﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisSocialNetworks.Library.Mvc.Models;
using Sitecore.GnosisSocialNetworks.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    [SitecoreFieldNamePrefix("Twitter Card")]
    public abstract class TwitterCardModel : BaseRenderingModel
    {
        public abstract string CardType { get; }

        [SitecoreFieldRawWithRootFallback("Site Override", "Site")]
        public string Site { get; set; }
        [SitecoreFieldRawWithRootFallback("Site ID Override", "Site ID")]
        public string SiteId { get; set; }
        [SitecoreFieldRaw]
        public string Title { get; set; }
        [SitecoreFieldRaw]
        public string Description { get; set; }
        [SitecoreImageFieldAbsoluteUrl("Image")]
        public string ImageUrl { get; set; }

        public bool ShowSite
        {
            get { return !String.IsNullOrWhiteSpace(Site); }
        }
        
        public bool ShowSiteId
        {
            get { return !String.IsNullOrWhiteSpace(SiteId); }
        }

        public bool ShowImageUrl
        {
            get { return !String.IsNullOrWhiteSpace(ImageUrl); }
        }

        public bool ShowTitle
        {
            get { return !String.IsNullOrWhiteSpace(Title); }
        }
        
        public bool ShowDescription
        {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }
    }
}