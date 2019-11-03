﻿using System;
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
    public static class PageAnimations
    {
        /// <summary>
        /// Slides a page in from the right
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromRight(seconds, page.WindowWidth);

            // Add fade in animation
            storyboard.AddFadeIn(seconds);

            //Start animating
            storyboard.Begin(page);

            //Make page visible
            page.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides a page out to the left
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            //Create the storyboard
            var storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideToLeft(seconds, page.WindowWidth);

            // Add fade in animation
            storyboard.AddFadeOut(seconds);

            //Start animating
            storyboard.Begin(page);

            //Make page visible
            page.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }
    }
}
