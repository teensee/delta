using System.Collections.Generic;

namespace delta.Core
{
    public class MenuDesignModel : MenuViewModel
    {
        public static MenuDesignModel Instance => new MenuDesignModel();

        public MenuDesignModel()
        {
            var collection = new[]
            {
                new MenuItemViewModel { Type = MenuItemType.Header, Text = "Design time header..."},
                new MenuItemViewModel { Type = MenuItemType.TextAndIcon, Icon = IconType.File, Text = "Menu item 1"},
                new MenuItemViewModel { Type = MenuItemType.TextAndIcon, Icon = IconType.Picture, Text = "Menu item 2"},
            };

            Items = new List<MenuItemViewModel>(collection);
        }
    }
}
