using System;
using System.Collections.Generic;

namespace delta.Core
{
    /// <summary>
    /// design time data for <see cref="ChatListDesignModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance = new ChatMessageListDesignModel();

        #endregion Singleton

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    ServiceIcon = ServiceIconEnum.Twitch,
                    Username = "teensee",
                    Message = "Привет, вы все такие классные, подскажите как сделать неведомую хуйню?",
                    IconRGB = "6441a4",
                    IsSelected = false,
                    SentByMe = true,
                    MessageSentTime = DateTimeOffset.UtcNow,
                },

                new ChatMessageListItemViewModel
                {
                    ServiceIcon = ServiceIconEnum.YouTube,
                    Username = "аslan",
                    Message = "Я ебал твой рот, вот это поворот!",
                    IconRGB = "ff4747",
                    IsSelected = false,
                    SentByMe = false,
                    MessageSentTime = DateTimeOffset.UtcNow,
                },

                new ChatMessageListItemViewModel
                {
                    ServiceIcon = ServiceIconEnum.Twitch,
                    Username = "дурачок",
                    Message = "Не вижу ничаво крутова!1!Не вижу ничаво крутова!1!Не вижу ничаво крутова!1!Не вижу ничаво крутова!1!",
                    IconRGB = "6441a4",
                    IsSelected = false,
                    SentByMe = false,
                    MessageSentTime = DateTimeOffset.UtcNow,
                },

            };
        }

        #endregion Constructor
    }
}