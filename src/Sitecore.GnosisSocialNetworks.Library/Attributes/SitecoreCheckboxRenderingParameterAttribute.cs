using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisSocialNetworks.Library.Attributes
{
    public class SitecoreCheckboxRenderingParameterAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; set; }

        #region Constructor

        public SitecoreCheckboxRenderingParameterAttribute()
        {
        }

        public SitecoreCheckboxRenderingParameterAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return rendering.Parameters[fieldName] == "1";
        }
    }
}
