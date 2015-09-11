using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore.GnosisSocialNetworks.Library.Attributes
{
    public class SitecoreImageFieldMimeTypeAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string FieldName { get; set; }

        #endregion

        #region Constructors

        public SitecoreImageFieldMimeTypeAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        public SitecoreImageFieldMimeTypeAttribute()
        {
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            ImageField field = fieldsHelper.GetImageField(rendering.Item, fieldName);

            if (field == null || field.MediaItem == null)
            {
                return null;
            }

            MediaItem mediaItem = new MediaItem(field.MediaItem);

            if (mediaItem == null)
            {
                return null;
            }

            return mediaItem.MimeType;
        }
    }
}
