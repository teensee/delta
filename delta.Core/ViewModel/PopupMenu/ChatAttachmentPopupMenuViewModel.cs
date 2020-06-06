using System.Collections.Generic;

namespace delta.Core
{
    /// <summary>
    /// A view model for the <see cref="BubbleContent"/>
    /// </summary>
    public class ChatAttachmentPopupMenuViewModel : BasePopupViewModel
    {
        #region Public Properties


        #endregion

        #region Contructor

        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>(new[]
                {
                    new MenuItemViewModel { Type = MenuItemType.Header, Text = "Attach a file..."},
                    new MenuItemViewModel { Type = MenuItemType.TextAndIcon, Icon = IconType.File, Text = "From computer"},
                    new MenuItemViewModel { Type = MenuItemType.TextAndIcon, Icon = IconType.Picture, Text = "From pictures"},
                })
            };
        }

        #endregion
    }
}
