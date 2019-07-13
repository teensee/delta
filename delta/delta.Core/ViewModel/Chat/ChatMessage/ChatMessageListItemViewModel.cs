using System;

namespace delta.Core
{
    /// <summary>
    /// View Model for each chat message thread item in a chat thread
    /// </summary>
    public class ChatMessageListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The display icon of connected service
        /// </summary>
        public ServiceIconEnum ServiceIcon { get; set; }

        /// <summary>
        /// The display a user's name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The display a user's message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The RGB values in hex for the background color of the icon 
        /// </summary>
        public string IconRGB { get; set; }

        /// <summary>
        /// True if this item currently selected
        /// </summary>
        public bool IsSelected { get; set; }
        
        /// <summary>
        /// True if this message was sent by the signed in user
        /// </summary>
        public bool SentByMe { get; set; }

        /// <summary>
        /// The time the message was read, or <see cref="DateTimeOffset.MinValue"/> if not read
        /// </summary>
        public DateTimeOffset MessageReadTime { get; set; }

        /// <summary>
        /// True if this message has been read
        /// </summary>
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        /// <summary>
        /// The time the message was sent
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }
    }
}
