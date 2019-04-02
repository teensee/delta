﻿namespace delta
{
    /// <summary>
    /// View Model for each chat list item in the overview chat list
    /// </summary>
    public class ChatListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The display icon of connected service
        /// </summary>
        public ServiceIconEnum ServiceIcon { get; set; }

        /// <summary>
        /// The display a connected users
        /// </summary>
        public int ViewerCount { get; set; }

        /// <summary>
        /// The RGB values in hex for the background color of the icon 
        /// </summary>
        public string IconRGB { get; set; }

        /// <summary>
        /// True if this item currently selected
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
