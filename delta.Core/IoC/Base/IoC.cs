using Ninject;

namespace delta.Core
{
    /// <summary>
    /// IoC container for our application
    /// </summary>
    public static class IoC
    {
        #region Public Properties

        /// <summary>
        /// The kernel for our IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();


        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI => Get<IUIManager>();

        /// <summary>
        /// A shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => Get<ApplicationViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="SettingsViewModel"/>
        /// </summary>
        public static SettingsViewModel SettingsViewModel => Get<SettingsViewModel>();
        #endregion

        #region Constructions

        /// <summary>
        /// Sets up the IoC container, binds all information required and is ready for use
        /// NOTE: Must be called as soon as your application starts up to ensure all services can be found
        /// </summary>
        public static void Setup()
        {
            // Bind all required voew models
            BindViewModels();
        }

        #endregion

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            //Bind to a single instance of Application View Model
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());

            //Bind to a single instance of SettingsViewModel
            Kernel.Bind<SettingsViewModel>().ToConstant(new SettingsViewModel());
        }

        /// <summary>
        /// Gets a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
