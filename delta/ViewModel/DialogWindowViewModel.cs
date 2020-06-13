using System.Windows;
using System.Windows.Controls;

namespace delta
{
    public class DialogWindowViewModel : WindowViewModel
    {

        #region Public Properties

        /// <summary>
        /// The title of this dialog window
        /// </summary>
        public string Title { get; set; } = "123123123";

        /// <summary>
        /// The content to host inside the dialog
        /// </summary>
        public Control Content { get; set; }

        #endregion


        #region Constructor
        public DialogWindowViewModel(Window window) : base(window)
        {
            WindowMinimumHeight = 100;
            WindowMinimumWidth = 150;
        } 
        #endregion
    }
}
