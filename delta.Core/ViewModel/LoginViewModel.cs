using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace delta.Core
{
    public class LoginViewModel : BaseViewModel
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
        /// A flag indicates if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion Public Properties

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion Commands

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            //Create a command
            LoginCommand = new RelayParameterizedCommand(async (param) => await Login(param));
            RegisterCommand = new RelayCommand(async () => await Register());
        }

        #endregion Constructor

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="param">The <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>
        private async Task Login(object param)
        {
            await RunCommand(() => LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                //Go to chat page
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Chat);

                var email = Email;
                var pswrd = (param as IHavePassword).SecretPassword.Unsecure();
            });
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        private async Task Register()
        {
            // TODO: Go to register page?
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Register);

            await Task.Delay(1);
        }
    }
}