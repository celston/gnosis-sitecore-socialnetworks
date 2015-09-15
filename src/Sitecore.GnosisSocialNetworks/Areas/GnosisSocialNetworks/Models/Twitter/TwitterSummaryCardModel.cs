using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;
using Sitecore.GnosisSocialNetworks.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    public class TwitterSummaryCardModel : TwitterCardModel
    {
        public override string CardType
        {
            get
            {
                return "summary";
            }
        }

        [SitecoreFieldRaw]
        public string Creator { get; set; }
        [SitecoreFieldRaw]
        public string CreatorId { get; set; }

        public bool ShowCreator
        {
            get
            {
                return !String.IsNullOrWhiteSpace(Creator);
            }
        }

        protected virtual bool CreatorApplicable
        {
            get
            {
                return false;
            }
        }
        
        public bool ShowCreatorId
        {
            get
            {
                return !String.IsNullOrWhiteSpace(CreatorId);
            }
        }
    }
}