using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisSocialNetworks.Library.Attributes
{
    public class SitecoreImageFieldAbsoluteUrlAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; set; }

        #region Constructors

        public SitecoreImageFieldAbsoluteUrlAttribute()
        {
        }

        public SitecoreImageFieldAbsoluteUrlAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return mediaManagerHelper.GetImageFieldAbsoluteUrl(rendering.Item, fieldName);
        }
    }
}
