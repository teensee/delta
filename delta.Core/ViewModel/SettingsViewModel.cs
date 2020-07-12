using System.Windows.Input;

namespace delta.Core
{
    /// <summary>
    /// The settings state as a view model
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Public Commands

        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsViewModel()
        {
            CloseCommand = new RelayCommand(Close);
        }

        #endregion

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        public void Close()
        {
            IoC.ApplicationViewModel.SettingsMenuVisible = false;
        }

    }
}
