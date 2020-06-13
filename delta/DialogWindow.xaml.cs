using System.Windows;

namespace delta
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {

        #region Private members

        /// <summary>
        /// The view model for this window
        /// </summary>
        private DialogWindowViewModel mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The view model for this window
        /// </summary>
        public DialogWindowViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                mViewModel = value;

                //Update data context
                DataContext = mViewModel;
            }
        }

        #endregion

        public DialogWindow()
        {
            InitializeComponent();
        }
    }
}
