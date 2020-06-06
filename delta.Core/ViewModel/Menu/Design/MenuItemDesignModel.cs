namespace delta.Core
{
    public class MenuItemDesignModel : MenuItemViewModel
    {
        public static MenuItemDesignModel Instance => new MenuItemDesignModel();

        public MenuItemDesignModel()
        {
            Text = "Test 1 item";
            Icon = IconType.Picture;
            Type = MenuItemType.TextAndIcon;
        }
    }
}
