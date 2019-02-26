using System;
using System.Windows;

namespace delta
{
    /// <summary>
    /// Base attached property class
    /// </summary>
    /// <typeparam name="Parent">Parent class to the attached prop.</typeparam>
    /// <typeparam name="Property">Type of this attached property</typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent: BaseAttachedProperty<Parent, Property>, new()
    {
        #region Public events

        /// <summary>
        /// Fired when the value changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        #endregion

        #region Singleton

        /// <summary>
        /// Singleton instance of our parent class
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Attached Property Definitions

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached(
                "Value", 
                typeof(Property), 
                typeof(BaseAttachedProperty<Parent, Property>), 
                new PropertyMetadata(new PropertyChangedCallback(OnValuePropertyChanged)));

        /// <summary>
        /// Callback event whent the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element that had it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //Call the parent function
            Instance.OnValueChanged(d, e);

            //Call event listeners
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// Gets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);

        /// <summary>
        /// Sets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <param name="value">The value to set the property</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        #endregion

        #region Event Methods

        /// <summary>
        /// The method that is called when any attached property of this type os changed
        /// </summary>
        /// <param name="sender">The UI element that this propperty was changed</param>
        /// <param name="e">The argument for this event</param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }



        #endregion
    }
}
