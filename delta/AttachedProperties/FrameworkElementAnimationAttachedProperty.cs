using System.Windows;

namespace delta
{
    /// <summary>
    /// A base class to run any animation method when a boolean is set to true
    /// and reverse animation when set to false
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    public abstract class AnimateBaseProperty<TParent> : BaseAttachedProperty<TParent, bool>
        where TParent : BaseAttachedProperty<TParent, bool>, new()
    {

        #region Public Properties

        /// <summary>
        /// Indicates if this is the first time this property has been loaded
        /// </summary>
        public bool FirstLoad { get; set; } = true;

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            //Get the framework element
            if (!(sender is FrameworkElement element))
                return;

            //Don't fire if the value doesn't change
            if (sender.GetValue(ValueProperty) == value && !FirstLoad)
                return;

            //On first load
            if (FirstLoad)
            {
                //Create a single self-unhookable event
                //fot the elements Loaded event

                RoutedEventHandler onLoad = null;
                onLoad = (ss, ee) =>
                {
                    //Unhook ourselves
                    element.Loaded -= onLoad;

                    //Do desire animation
                    DoAnimation(element, (bool)value);

                    //No longer in first load
                    FirstLoad = false;
                };

                element.Loaded += onLoad;
            }
            else
            {
                //Do desire animation
                DoAnimation(element, (bool)value);

            }

        }

        /// <summary>
        /// The animation method that fired when the value changes
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        protected virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    /// <summary>
    /// Animate a framework element sliding it in from the left on show
    /// and sliding out to the left on hide
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                //Animate in
                await element.SlideAndFadeInFromLeft(FirstLoad ? 0 : 0.3f);
            }
            else
            {
                await element.SlideAndFadeOutToLeft(FirstLoad ? 0 : 0.3f);
            }
        }
    }

    /// <summary>
    /// Animate a framework element sliding up from the bottom on show
    /// and sliding out to the to the bottom on hide
    /// </summary>
    public class AnimateSlideInFromBottomProperty : AnimateBaseProperty<AnimateSlideInFromBottomProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                //Animate in
                await element.SlideAndFadeInFromBottom(FirstLoad ? 0 : 0.3f);
            }
            else
            {
                await element.SlideAndFadeOutToBottom(FirstLoad ? 0 : 0.3f, 0, element.Margin);
            }
        }
    }
}
