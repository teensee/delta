using System.Collections.Generic;

namespace delta.Core
{
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuViewModel : BaseViewModel
    {
        /// <summary>
        /// Items in this menu
        /// </summary>
        public IList<MenuItemViewModel> Items { get; set; }

    }
}
