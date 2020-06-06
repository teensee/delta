namespace delta.Core
{
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The text to display for the menu item
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The type of this menu item
        /// </summary>
        public MenuItemType Type { get; set; }

        /// <summary>
        /// The icon for this item menu
        /// </summary>
        public IconType Icon { get; set; } = IconType.None;


    }
}
