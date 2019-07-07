using System.Collections.Generic;

namespace delta.Core
{
    /// <summary>
    /// design time data for <see cref="ChatListDesignModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance = new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    ServiceIcon = ServiceIconEnum.Twitch,
                    ViewerCount = 9999,
                    IconRGB = "6441a4",
                    IsSelected = true,

                },

                new ChatListItemViewModel
                {
                    ServiceIcon = ServiceIconEnum.YouTube,
                    ViewerCount = 222,
                    IconRGB = "ff4747",

                },
                new ChatListItemViewModel
                {
                    ServiceIcon = ServiceIconEnum.YouTube,
                    ViewerCount = 222,
                    IconRGB = "ff4747",

                },
             };
        }

        #endregion
    }
}
