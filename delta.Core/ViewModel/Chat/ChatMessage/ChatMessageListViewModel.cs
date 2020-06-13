using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace delta.Core
{
    /// <summary>
    /// View Model for a chat message thread list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }

        /// <summary>
        /// If true - show attachment menu 
        /// </summary>
        public bool AttachmentMenuVisible { get; set; } = false;

        /// <summary>
        /// True if any popup menu are visible
        /// </summary>
        public bool AnyPopupVisible => AttachmentMenuVisible;

        /// <summary>
        /// The view model for the attachment menu
        /// </summary>
        public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the attachment button is clicked
        /// </summary>
        public ICommand AttachmentButtonCommand { get; set; }

        /// <summary>
        /// The command for when the area outside of popup is clicked
        /// </summary>
        public ICommand PopupClickAwayCommand { get; set; }

        /// <summary>
        /// The command for when the user clicks the send button
        /// </summary>
        public ICommand SendCommand { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default contructor
        /// </summary>
        public ChatMessageListViewModel()
        {
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
            PopupClickAwayCommand = new RelayCommand(PopupClickAway);
            SendCommand = new RelayCommand(SendAction);


            //make a default menu
            AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// When the attachment button is clicked show/hide the attachment popup
        /// </summary>
        public void AttachmentButton()
        {
            //toggle menu visible
            AttachmentMenuVisible ^= true;
        }

        /// <summary>
        /// When the popup clickaway area is ckicked hide any popups
        /// </summary>
        public void PopupClickAway()
        {
            //hide menu
            AttachmentMenuVisible = false;
        }

        /// <summary>
        /// When the user clicks the send button, send the message
        /// </summary>
        public void SendAction()
        {

            IoC.ApplicationViewModel.SettingsMenuVisible = true;
            //IoC.UI.ShowMessage(new MessageBoxDialogsViewModel
            //{
            //    Title = "Send message",
            //    Message = "This is simple test message  :3",
            //    OkText = "Ok"
            //});
        }


        #endregion

    }
}
