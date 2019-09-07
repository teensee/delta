namespace delta.Core
{
    /// <summary>
    /// design time data for <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListItemDesignModel Instance = new ChatListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListItemDesignModel()
        {
            ServiceIcon = ServiceIconEnum.Twitch;
            ViewerCount = 1501;
        }

        #endregion
    }
}
