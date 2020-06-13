using delta.Core;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace delta
{
    /// <summary>
    /// Base class for any content that is being used inside of a <see cref="DialogWindow"/>
    /// </summary>
    public class BaseDialogUserControl : UserControl
    {
        #region Private members

        /// <summary>
        /// The dialog widnod we will be contained within
        /// </summary>
        private DialogWindow mDialogWindow;

        #endregion

        #region Public Commands

        /// <summary>
        /// Close this dialog
        /// </summary>
        public ICommand CloseCommand { get; private set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// Minimum width of this dialog
        /// </summary>
        public int WindowMinimumWidth { get; set; } = 150;

        /// <summary>
        /// Minimum height of this dialog
        /// </summary>
        public int WindowMinimumHeight { get; set; } = 150;

        /// <summary>
        /// The height of the title bar
        /// </summary>
        public int TitleHeight { get; set; }

        /// <summary>
        /// The title of this dialog
        /// </summary>
        public string Title { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDialogUserControl()
        {
            //create a new dialog window;
            mDialogWindow = new DialogWindow();
            mDialogWindow.ViewModel = new DialogWindowViewModel(mDialogWindow);

            CloseCommand = new RelayCommand(() => mDialogWindow.Close());
        }

        #endregion

        #region Public Dialog Show Methods

        /// <summary>
        /// Displays a single message box to the user
        /// </summary>
        /// <param name="viewModel">the view model</param>
        /// <returns></returns>
        public Task ShowDialog<T>(T viewModel)
            where T : BaseDialogViewModel
        {
            //Create a task to await the dialod closing
            var task = new TaskCompletionSource<bool>();

            Application.Current.Dispatcher.Invoke(() =>
            {
                try
                {
                    mDialogWindow.ViewModel.WindowMinimumWidth = WindowMinimumWidth;
                    mDialogWindow.ViewModel.WindowMinimumHeight = WindowMinimumHeight;
                    mDialogWindow.ViewModel.Title = string.IsNullOrEmpty(viewModel.Title) ? Title : viewModel.Title;

                    mDialogWindow.ViewModel.Content = this;

                    DataContext = viewModel;

                    //Show dialog 
                    mDialogWindow.ShowDialog();
                }
                finally
                {
                    //Let caller know we finished
                    task.TrySetResult(true);
                }

            });


            return task.Task;
        }

        #endregion
    }
}
