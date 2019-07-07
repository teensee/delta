using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace delta
{
    /// <summary>
    /// Helpers to animate pages in specific ways
    /// </summary>
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Slides an element in from the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this FrameworkElement element, float seconds =0.3f)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromRight(seconds, element.ActualWidth);

            // Add fade in animation
            storyboard.AddFadeIn(seconds);

            //Start animating
            storyboard.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element in from the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeft(this FrameworkElement element, float seconds=0.3f)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromLeft(seconds, element.ActualWidth);

            // Add fade in animation
            storyboard.AddFadeIn(seconds);

            //Start animating
            storyboard.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides a element out to the left
        /// </summary>
        /// <param name="element">The page to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this FrameworkElement element, float seconds = 0.3f)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideToLeft(seconds, element.ActualWidth);

            // Add fade in animation
            storyboard.AddFadeOut(seconds);

            //Start animating
            storyboard.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides a element out to the right
        /// </summary>
        /// <param name="element">The page to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRight(this FrameworkElement element, float seconds = 0.3f)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideToRight(seconds, element.ActualWidth);

            // Add fade in animation
            storyboard.AddFadeOut(seconds);

            //Start animating
            storyboard.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }
    }
}
