using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace delta.Core
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The secure password
        /// </summary>
        public SecureString Password { get; set; }

        /// <summary>
        /// A flag indicates if the register command is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterViewModel()
        {
            //Create a command
            RegisterCommand = new RelayParameterizedCommand(async (param) => await Register(param));
            LoginCommand = new RelayCommand(async () => await Login());
        }

        #endregion

        /// <summary>
        /// Attempts to register the user in
        /// </summary>
        /// <param name="param">The <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>
        private async Task Register(object param)
        {
            await RunCommand(() => RegisterIsRunning, async () =>
            {
                await Task.Delay(5000);

            });

        }

        /// <summary>
        /// Takes the user to the login page
        /// </summary>
        /// <returns></returns>
        private async Task Login()
        {
            // TODO: Go to register page?
            IoC.ApplicationViewModel.GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }

    }
}
