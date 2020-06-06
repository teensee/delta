using System.Threading.Tasks;

namespace delta.Core
{
    /// <summary>
    /// The UI manager that handles any UI interaction in the application
    /// </summary>
    public interface IUIManager
    {
        /// <summary>
        /// Displays a single message box to the user
        /// </summary>
        /// <param name="viewModel">the view model</param>
        /// <returns></returns>
        Task ShowMessage(MessageBoxDialogsViewModel viewModel);
    }
}
