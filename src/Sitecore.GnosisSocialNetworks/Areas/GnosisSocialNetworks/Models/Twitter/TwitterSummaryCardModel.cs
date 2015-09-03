using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;

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

        public string Creator
        {
            get
            {
                return RenderingItem["Twitter Card Creator"];
            }
        }

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

        public string CreatorId
        {
            get
            {
                return RenderingItem["Twitter Card Creator ID"];
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