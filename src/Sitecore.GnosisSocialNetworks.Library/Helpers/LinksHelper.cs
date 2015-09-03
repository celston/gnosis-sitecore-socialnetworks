using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisSocialNetworks.Library.Helpers
{
    public class LinksHelper
    {
        #region Singleton Setup

        private static readonly Lazy<LinksHelper> lazy = new Lazy<LinksHelper>(() =>
        {
            return new LinksHelper();
        });

        private LinksHelper()
        {
        }

        public static LinksHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        #region Protected Fields

        protected readonly MediaManagerHelper mediaManagerHelper = MediaManagerHelper.Instance;
        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;

        #endregion

        #region Public Methods

        public string GetItemAbsoluteUrl(Item item)
        {
            if (item == null)
            {
                return null;
            }
            
            return LinkManager.GetItemUrl(item, BuildAbsoluteUrlOptions());
        }

        public UrlOptions BuildAbsoluteUrlOptions()
        {
            return new UrlOptions()
            {
                AlwaysIncludeServerUrl = true
            };
        }

        public string GetLinkFieldAbsoluteUrl(Item item, string fieldName)
        {
            return GetLinkFieldAbsoluteUrl(fieldsHelper.GetLinkField(item, fieldName));
        }

        public string GetLinkFieldAbsoluteUrl(LinkField field)
        {
            if (field == null)
            {
                return null;
            }

            switch (field.LinkType.ToLower())
            {
                case "internal":
                    return GetItemAbsoluteUrl(field.TargetItem);
                case "media":
                    return mediaManagerHelper.GetMediaLinkFieldAbsoluteUrl(field);
                case "anchor":
                    // Prefix anchor link with # if link if not empty
                    return !string.IsNullOrEmpty(field.Anchor) ? "#" + field.Anchor : string.Empty;
                default:
                    // all others fallback
                    return field.Url;
            }
        }

        #endregion
    }
}
