﻿using System.Windows;
using System.Windows.Controls;

namespace delta
{
    /// <summary>
    /// The MonitorPassword a <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //Get the caller
            var passwordBox = (sender as PasswordBox);

            //Make sure it is a password box
            if (passwordBox == null)
                return;

            //Remove any previous events
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            //if the caller set MonitorPassword to true...
            if ((bool)e.NewValue)
            {
                //Set default value
                HasTextProperty.SetValue(passwordBox);

                //Start listening out for password changes
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        /// <summary>
        /// Fired when the password box password value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //Set the attached HasText value
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }

    /// <summary>
    /// The HasText for a <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        /// <summary>
        /// Sets the HasText property based on if the caller <see cref="PasswordBox"/> has any text'
        /// We make short SetValue with 1 parametr
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender)
        {
            //We call SetValue from BaseAttachedProperty
            SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
        }
    }
}
