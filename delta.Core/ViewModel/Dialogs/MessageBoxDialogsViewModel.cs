namespace delta.Core
{
    /// <summary>
    /// Details fot a message box dialog
    /// </summary>
    public class MessageBoxDialogsViewModel : BaseViewModel
    {
        /// <summary>
        /// The title of the message box
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The message to display
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The text to use for the OK button
        /// </summary>
        public string OkText { get; set; }

    }
}
