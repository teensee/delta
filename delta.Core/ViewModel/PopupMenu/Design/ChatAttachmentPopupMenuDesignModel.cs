using delta.Core;

namespace delta.Core
{
    /// <summary>
    /// A view model for the <see cref="BubbleContent"/>
    /// </summary>
    public class ChatAttachmentPopupMenuDesignModel : ChatAttachmentPopupMenuViewModel
    {

        #region Singleton

        public static ChatAttachmentPopupMenuDesignModel Instance => new ChatAttachmentPopupMenuDesignModel();

        #endregion

        #region Contructor

        public ChatAttachmentPopupMenuDesignModel()
        {
           
        }

        #endregion
    }
}
