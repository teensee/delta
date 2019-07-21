using System;

namespace delta.Core
{
    /// <summary>
    /// design time data for <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListItemDesignModel Instance = new ChatMessageListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListItemDesignModel()
        {
            ServiceIcon = ServiceIconEnum.Twitch;
            Username = "teensee";
            Message = "Это design-time текст. Тут вообще-то будет что-то интересное...наверно?";
            IconRGB = "6441a4";
            IsSelected = false;
            SentByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
        }

        #endregion
    }
}
