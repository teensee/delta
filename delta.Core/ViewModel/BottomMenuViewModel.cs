using System.Windows.Input;

namespace delta.Core.ViewModel
{
    public class BottomMenuViewModel
    {
        #region Public Commands

        public ICommand ShowSettingsCommand { get; set; }

        #endregion

        #region Constructor

        public BottomMenuViewModel()
        {
            ShowSettingsCommand = new RelayCommand(ShowSettings);
        }

        #endregion


        public void ShowSettings()
        {
            IoC.ApplicationViewModel.SettingsMenuVisible = true;
        }
    }
}
