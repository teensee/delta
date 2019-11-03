using System.Windows;
using System.Windows.Controls;

namespace delta
{
    /// <summary>
    /// Focuses this element on load
    /// </summary>
    public class IsFocusedProperty : BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //if we dont have a control
            if (!(sender is Control control))
                return;

            control.Loaded += (ss, ee) => control.Focus();
        }
    } 

}