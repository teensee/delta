using delta.Core;
using System.Security;

namespace delta
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SecurePassword for this login page
        /// </summary>
        public SecureString SecretPassword => PasswordText.SecurePassword;
    }
}
