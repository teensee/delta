using delta.Core;
using System.Threading.Tasks;
using System.Windows;

namespace delta
{
    /// <summary>
    /// The applications implementation of the <see cref="IUIManager" />
    /// </summary>
    public class UIManager : IUIManager
    {
        /// <summary>
        /// Displays a single message box to the user
        /// </summary>
        /// <param name="viewModel">the view model</param>
        /// <returns></returns>
        public Task ShowMessage(MessageBoxDialogsViewModel viewModel)
        {
            return Task.Run(() => MessageBox.Show("Test"));
        }
    }
}
