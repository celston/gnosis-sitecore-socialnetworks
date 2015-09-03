using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;
using Sitecore.Mvc.Presentation;

using Sitecore.GnosisSocialNetworks.Library.Helpers;

namespace Sitecore.GnosisSocialNetworks.Library.Models
{
    public abstract class BaseRenderingModel : IRenderingModel
    {
        #region Protected Fields

        protected readonly MediaManagerHelper mediaManagerHelper = MediaManagerHelper.Instance;
        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;
        protected readonly ItemsHelper itemsHelper = ItemsHelper.Instance;
        protected readonly LinksHelper linksHelper = LinksHelper.Instance;

        #endregion

        #region Protected Properties

        protected Item RenderingItem { get; private set; }
        protected Item RootItem
        {
            get
            {
                return itemsHelper.RootItem;
            }
        }

        #endregion

        #region Protected Methods

        protected string GetRenderingItemImageFieldAbsoluteUrl(string fieldName)
        {
            return mediaManagerHelper.GetImageFieldAbsoluteUrl(RenderingItem, fieldName);
        }
        
        protected string GetFallbackField(string rootFieldName, string itemFieldName)
        {
            string temp = RenderingItem[itemFieldName];
            if (!String.IsNullOrWhiteSpace(temp))
            {
                return temp;
            }

            return RootItem[rootFieldName];
        }

        protected bool RenderingItemFieldIsNullOrWhitespace(string fieldName)
        {
            return String.IsNullOrWhiteSpace(RenderingItem[fieldName]);
        }

        protected string GetRenderingItemLinkFieldAbsoluteUrl(string fieldName)
        {
            return linksHelper.GetLinkFieldAbsoluteUrl(RenderingItem, fieldName);
        }

        #endregion

        #region IRenderingModel Implementation

        public virtual void Initialize(Rendering rendering)
        {
            RenderingItem = rendering.Item;
        }

        #endregion
    }
}