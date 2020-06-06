using delta.Core.DataModels;

namespace delta.Core
{
    /// <summary>
    /// A view model for the <see cref="BubbleContent"/>
    /// </summary>
    public class BasePopupViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The background color of the bubble in ARGB value
        /// </summary>
        public string BubbleBackground{ get; set; }
        /// <summary>
        /// The alignment of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        /// <summary>
        /// The content inside of this popup menu
        /// </summary>
        public BaseViewModel Content { get; set; }

        #endregion

        #region Contructor

        public BasePopupViewModel()
        {
            //set default values
            BubbleBackground = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Right;
        }

        #endregion
    }
}
