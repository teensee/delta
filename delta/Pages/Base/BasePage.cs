﻿using delta.Core;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace delta
{
    /// <summary>
    /// Base page for all pages to gain base functionallity
    /// </summary>
    public class BasePage<VM> : Page
        where VM: BaseViewModel, new()
    {

        #region Private Member

        /// <summary>
        /// View Model assiciated with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The animation the play when page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation the play when page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slides animation takes
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// View Model assiciated with this page
        /// </summary>
        public VM ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel == value)
                    return;

                //Update the value
                mViewModel = value;

                //Set the data context for this page
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region Default Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            //If we are anumating in, hide to begin with
            if (PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;

            //Listen out for the page loading
            Loaded += BasePage_Loaded;

            //Create a default view model
            this.ViewModel = new VM();
        }

        #endregion

        #region Animation Load/Unload

        /// <summary>
        /// Once the pages is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            await AnimateIn();
        }

        /// <summary>
        /// Animates page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            //Make sure we have something to do
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    //Start the animation
                    await this.SlideAndFadeInFromRight(SlideSeconds);
                    break;

            }
        }

        /// <summary>
        /// Animates page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            //Make sure we have something to do
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    //Start the animation
                    await this.SlideAndFadeOutToLeft(SlideSeconds);
                    break;
            }
        }

        #endregion
    }
}
