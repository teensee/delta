namespace delta.Core
{
    /// <summary>
    /// Details fot a message box dialog
    /// </summary>
    public class MessageBoxDialogsDesignModel : MessageBoxDialogsViewModel
    {

        public static MessageBoxDialogsDesignModel Instance => new MessageBoxDialogsDesignModel();

        public MessageBoxDialogsDesignModel()
        {
            Title = "Design-time title";
            Message = "This is simple design-time message";
            OkText = "Close";
        }

    }
}
