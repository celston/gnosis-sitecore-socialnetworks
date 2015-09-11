using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;
using Sitecore.Mvc.Presentation;

using Sitecore.GnosisSocialNetworks.Library.Helpers;
using System.Reflection;
using Sitecore.GnosisSocialNetworks.Library.Attributes;
using System.Diagnostics;

namespace Sitecore.GnosisSocialNetworks.Library.Mvc.Models
{
    public abstract class BaseRenderingModel : IRenderingModel
    {
        #region Protected Fields

        protected readonly MediaManagerHelper mediaManagerHelper = MediaManagerHelper.Instance;
        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;
        protected readonly ItemsHelper itemsHelper = ItemsHelper.Instance;
        protected readonly LinksHelper linksHelper = LinksHelper.Instance;
        protected Rendering rendering;

        #endregion

        #region Public Properties

        public Guid Id { get; private set; }
        public string MachineName { get; private set; }

        #endregion

        #region IRenderingModel Implementation

        public virtual void Initialize(Rendering rendering)
        {
            this.rendering = rendering;
            MachineName = itemsHelper.GetItemMachineName(rendering.Item);
            Id = rendering.Item.ID.ToGuid();
            
            SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute = this.GetType().GetCustomAttributes<SitecoreFieldNamePrefixAttribute>().FirstOrDefault();

            foreach (PropertyInfo pi in GetType().GetProperties())
            {
                foreach (SitecoreDataAttribute attribute in pi.GetCustomAttributes<SitecoreDataAttribute>())
                {
                    Sitecore.Diagnostics.Profiler.StartOperation(String.Format("Processing {0} for {1}", attribute.GetType().Name, pi.Name));
                    
                    if (pi.GetSetMethod() == null)
                    {
                        throw new Exception(String.Format("No set method for {0}", pi.Name));
                    }
                    
                    pi.SetValue(this, attribute.GetValue(fieldNamePrefixAttribute, pi, rendering));

                    Sitecore.Diagnostics.Profiler.EndOperation(String.Format("Processing {0} for {1}", attribute.GetType().Name, pi.Name));
                }
            }
        }

        #endregion
    }
}