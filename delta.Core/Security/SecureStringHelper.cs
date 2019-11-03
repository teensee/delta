﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace delta.Core
{
    /// <summary>
    /// Helper for the <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringHelper
    {
        /// <summary>
        /// Unsecures a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="secureString"></param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            //Make sure we have a password
            if (secureString == null)
                return string.Empty;

            //Get a pointer for an unsecure string in memory
            var unmanagedString = IntPtr.Zero;

            try
            {
                //Unsecure the password
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }

            finally
            {
                //Clean up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }

        }
    }
}
