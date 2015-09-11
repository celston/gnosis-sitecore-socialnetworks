using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Mvc.Presentation;
using Sitecore.GnosisSocialNetworks.Library.Helpers;

namespace Sitecore.GnosisSocialNetworks.Library.Attributes
{
    public abstract class SitecoreDataAttribute : Attribute
    {
        protected readonly LinksHelper linksHelper = LinksHelper.Instance;
        protected readonly ItemsHelper itemsHelper = ItemsHelper.Instance;
        protected readonly MediaManagerHelper mediaManagerHelper = MediaManagerHelper.Instance;
        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;
        
        public abstract object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering);

        protected string ResolveFieldName(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, string fieldName)
        {
            if (fieldNamePrefixAttribute == null || String.IsNullOrWhiteSpace(fieldNamePrefixAttribute.FieldNamePrefix))
            {
                if (String.IsNullOrWhiteSpace(fieldName))
                {
                    return pi.Name;
                }

                return fieldName;
            }

            if (String.IsNullOrWhiteSpace(fieldName))
            {
                return String.Format("{0} {1}", fieldNamePrefixAttribute.FieldNamePrefix, pi.Name);
            }

            return String.Format("{0} {1}", fieldNamePrefixAttribute.FieldNamePrefix, fieldName);
        }
    }
}
