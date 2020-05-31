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
        public bool AttachmentMenuVisible { get; set; }
        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the attachment button is clicked
        /// </summary>
        public ICommand AttachmentButtonCommand { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default contructor
        /// </summary>
        public ChatMessageListViewModel()
        {
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
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

        #endregion

    }
}
