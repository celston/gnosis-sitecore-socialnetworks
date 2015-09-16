using System;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore.GnosisSocialNetworks.Library.Attributes
{
    public class SitecoreImageFieldMimeTypeWithRootFallbackAttribute : SitecoreDataAttribute
    {
        public string ItemFieldName { get; set; }
        public string RootFieldName { get; set; }

        public SitecoreImageFieldMimeTypeWithRootFallbackAttribute(string itemFieldName, string rootFieldName)
        {
            ItemFieldName = itemFieldName;
            RootFieldName = rootFieldName;
        }

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string itemFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, ItemFieldName);
            string rootFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, RootFieldName);

            string result = mediaHelper.GetImageFieldMediaItemMimeType(rendering.Item, itemFieldName);
            if (String.IsNullOrWhiteSpace(result))
            {
                result = mediaHelper.GetImageFieldMediaItemMimeType(itemsHelper.RootItem, rootFieldName);
            }

            return result;
        }
    }
}
