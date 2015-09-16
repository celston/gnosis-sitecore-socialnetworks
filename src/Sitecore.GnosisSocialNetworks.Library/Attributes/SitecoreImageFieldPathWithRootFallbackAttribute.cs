using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisSocialNetworks.Library.Attributes
{
    public class SitecoreImageFieldPathWithRootFallbackAttribute : SitecoreDataAttribute
    {
        public string ItemFieldName { get; set; }
        public string RootFieldName { get; set; }

        public SitecoreImageFieldPathWithRootFallbackAttribute(string itemFieldName, string rootFieldName)
        {
            ItemFieldName = itemFieldName;
            RootFieldName = rootFieldName;
        }

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string itemFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, ItemFieldName);
            string rootFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, RootFieldName);

            string result = mediaHelper.GetImageFieldMediaItemAbsoluteUrl(rendering.Item, itemFieldName);
            if (String.IsNullOrWhiteSpace(result))
            {
                result = mediaHelper.GetImageFieldMediaItemPath(itemsHelper.RootItem, rootFieldName);
            }

            return result;
        }
    }
}
