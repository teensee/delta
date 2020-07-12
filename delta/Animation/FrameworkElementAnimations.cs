using System.Threading.Tasks;
using System.Windows;
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
        public static async Task SlideAndFadeInFromRight(this FrameworkElement element, float seconds = 0.3f, double width = 0)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromRight(seconds, width == 0 ? element.ActualWidth : width);

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
        /// Slides a element out to the right
        /// </summary>
        /// <param name="element">The page to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRight(this FrameworkElement element, float seconds = 0.3f, double width = 0)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideToRight(seconds, width == 0 ? element.ActualWidth : width);

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
        /// Slides an element in from the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeft(this FrameworkElement element, float seconds = 0.3f, double width = 0)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromLeft(seconds, width == 0 ? element.ActualWidth : width);

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
        public static async Task SlideAndFadeOutToLeft(this FrameworkElement element, float seconds = 0.3f, double width = 0)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideToLeft(seconds, width == 0 ? element.ActualWidth : width);

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
        /// Slides an element in from the bottom
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration</param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromBottom(this FrameworkElement element, float seconds = 0.3f, double height = 0, Thickness thickness = default)
        {
            //Make page visible
            element.Visibility = Visibility.Visible;

            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromBottom(seconds, height == 0 ? element.ActualHeight : height, decelerationRatio: 0.9f, thickness: thickness);

            // Add fade in animation
            storyboard.AddFadeIn(seconds);

            //Start animating
            storyboard.Begin(element);

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides a element out to the left
        /// </summary>
        /// <param name="element">The page to animate</param>
        /// <param name="seconds">Duration</param>
        /// <param name="height"></param>
        /// <param name="thickness"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToBottom(this FrameworkElement element, float seconds = 0.3f, double height = 0, Thickness thickness = default)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideToBottom(seconds, height == 0 ? element.ActualHeight : height, decelerationRatio: 0.9f, thickness: thickness);

            // Add fade in animation
            storyboard.AddFadeOut(seconds);

            //Start animating
            storyboard.Begin(element);

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            //Make page unvisible
            element.Visibility = Visibility.Collapsed;
        }
    }
}
