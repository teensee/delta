using System.Collections.Generic;

namespace delta.Core
{
    /// <summary>
    /// View Model for a chat message thread list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }
    }
}
