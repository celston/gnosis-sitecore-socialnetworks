using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Items;

namespace Sitecore.GnosisSocialNetworks.Library.Helpers
{
    public class ItemsHelper
    {
        Lazy<Item> lazyRootItem;
        
        #region Singleton Setup

        private readonly static Lazy<ItemsHelper> lazy = new Lazy<ItemsHelper>(() =>
        {
            return new ItemsHelper();
        });

        private ItemsHelper()
        {
            lazyRootItem = new Lazy<Item>(() =>
            {
                return Sitecore.Context.Database.GetItem(Sitecore.Context.Site.RootPath);
            });
        }

        public static ItemsHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        public Item RootItem
        {
            get
            {
                return lazyRootItem.Value;
            }
        }
    }
}
