// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.IO;
using System.Linq;

namespace Z.ExtensionMethods
{
    public static partial class DirectoryInfoExtension
    {
        /// <summary>
        ///     A DirectoryInfo extension method that deletes the older than.
        /// </summary>
        /// <param name="obj">The obj to act on.</param>
        /// <param name="timeSpan">The time span.</param>
        public static void DeleteOlderThan(this DirectoryInfo obj, TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }

        /// <summary>
        ///     A DirectoryInfo extension method that deletes the older than.
        /// </summary>
        /// <param name="obj">The obj to act on.</param>
        /// <param name="searchOption">The search option.</param>
        /// <param name="timeSpan">The time span.</param>
        public static void DeleteOlderThan(this DirectoryInfo obj, SearchOption searchOption, TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }
    }
}