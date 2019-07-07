using delta.Core;
using System.Security;

namespace delta
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<RegisterViewModel>, IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SecurePassword for this login page
        /// </summary>
        public SecureString SecretPassword => PasswordText.SecurePassword;
    }
}
