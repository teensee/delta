using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delta.Core
{
    /// <summary>
    /// The application state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Chat;

        /// <summary>
        /// True is the bottom menu should be show
        /// </summary>
        public bool BottomMenuVisible { get; set; } = true;

        /// <summary>
        /// Naviagate to specify page
        /// </summary>
        /// <param name="page">the page to go to</param>
        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;

            BottomMenuVisible = page == ApplicationPage.Chat;
        }
    }
}
