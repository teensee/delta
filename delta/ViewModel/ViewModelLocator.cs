using delta.Core;

namespace delta
{
    /// <summary>
    /// Locates view models from IoC for use in bindings in XAML files
    /// </summary>
    public class ViewModelLocator : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// Singleton
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// The application view model from ioc
        /// </summary>
        public static ApplicationViewModel AppViewModel => IoC.ApplicationViewModel;

        #endregion

    }
}
