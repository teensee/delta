using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace delta
{
    /// <summary>
    /// Animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        #region Slide and Fade In/Out

        /// <summary>
        /// Add a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation too</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f)
        {
            //Create a margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            //Add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// Add a slide to left animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation too</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f)
        {
            //Create a margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, offset, 0),
                DecelerationRatio = decelerationRatio
            };

            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            //Add this to the storyboard
            storyboard.Children.Add(animation);

        }

        #endregion

        #region Fade In/Out

        /// <summary>
        /// Add a fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation too</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            //Create a margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
            };

            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            //Add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// Add a fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation too</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            //Create a margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0
            };

            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            //Add this to the storyboard
            storyboard.Children.Add(animation);

        }

        #endregion
    }
}
