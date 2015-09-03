using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;

namespace Sitecore.GnosisSocialNetworks.Library.Helpers
{
    public class MediaManagerHelper
    {
        #region Singleton Setup

        private readonly static Lazy<MediaManagerHelper> lazy = new Lazy<MediaManagerHelper>(() =>
        {
            return new MediaManagerHelper();
        });

        private MediaManagerHelper()
        {
        }

        public static MediaManagerHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        #region Protected Fields

        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;

        #endregion

        #region Public Methods

        public string GetImageFieldAbsoluteUrl(Item item, string fieldName)
        {
            ImageField field = fieldsHelper.GetImageField(item, fieldName);
            if (field == null || field.MediaItem == null)
            {
                return null;
            }

            return MediaManager.GetMediaUrl(field.MediaItem, BuildAbsoluteUrlMediaUrlOptions());
        }

        public string GetMediaLinkFieldAbsoluteUrl(LinkField field)
        {
            if (field.TargetItem == null)
            {
                return null;
            }
            
            return Sitecore.Resources.Media.MediaManager.GetMediaUrl(field.TargetItem, BuildAbsoluteUrlMediaUrlOptions());
        }

        public MediaUrlOptions BuildAbsoluteUrlMediaUrlOptions()
        {
            return new MediaUrlOptions()
            {
                AlwaysIncludeServerUrl = true
            };
        }

        #endregion
    }
}
