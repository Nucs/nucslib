// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System.IO;
using System.Security.AccessControl;

public static partial class DirectoryInfoExtension
{
    /// <summary>
    ///     Creates all directories and subdirectories in the specified @this.
    /// </summary>
    /// <param name="this">The directory @this to create.</param>
    /// <returns>An object that represents the directory for the specified @this.</returns>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     The directory specified by <paramref name="this" /> is a file.-or-The
    ///     network name is not known.
    /// </exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> is a zero-length string, contains only
    ///     white space, or contains one or more invalid characters as defined by
    ///     <see
    ///         cref="F:System.IO.Path.InvalidPathChars" />
    ///     .-or-<paramref name="this" /> is prefixed with, or contains only a colon character (:).
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or both exceed the system-
    ///     defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file
    ///     names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     The specified @this is invalid (for example, it is on
    ///     an unmapped drive).
    /// </exception>
    /// ###
    /// <exception cref="T:System.NotSupportedException">
    ///     <paramref name="this" /> contains a colon character (:) that
    ///     is not part of a drive label ("C:\").
    /// </exception>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using System.IO;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_IO_DirectoryInfo_CreateAllDirectory
    ///               {
    ///                   [TestMethod]
    ///                   public void CreateAllDirectory()
    ///                   {
    ///                       // Type
    ///                       var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;DirectoryInfo_Clear&quot;, &quot;SubDirectory&quot;));
    ///           
    ///                       // Examples
    ///                       @this.CreateAllDirectories(); // Create the directory the first time.
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(@this.Exists);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this)
    {
        return Directory.CreateDirectory(@this.FullName);
    }

    /// <summary>
    ///     Creates all the directories in the specified @this, applying the specified Windows security.
    /// </summary>
    /// <param name="this">The directory to create.</param>
    /// <param name="directorySecurity">The access control to apply to the directory.</param>
    /// <returns>An object that represents the directory for the specified @this.</returns>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     The directory specified by <paramref name="this" /> is a file.-or-The
    ///     network name is not known.
    /// </exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this" /> is a zero-length string, contains only
    ///     white space, or contains one or more invalid characters as defined by
    ///     <see
    ///         cref="F:System.IO.Path.InvalidPathChars" />
    ///     . -or-<paramref name="this" /> is prefixed with, or contains only a colon character (:).
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or both exceed the system-
    ///     defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file
    ///     names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     The specified @this is invalid (for example, it is on
    ///     an unmapped drive).
    /// </exception>
    /// ###
    /// <exception cref="T:System.NotSupportedException">
    ///     <paramref name="this" /> contains a colon character (:) that
    ///     is not part of a drive label ("C:\").
    /// </exception>
    /// <example>
    ///     <code>
    ///           using System;
    ///           using System.IO;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_IO_DirectoryInfo_CreateAllDirectory
    ///               {
    ///                   [TestMethod]
    ///                   public void CreateAllDirectory()
    ///                   {
    ///                       // Type
    ///                       var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;DirectoryInfo_Clear&quot;, &quot;SubDirectory&quot;));
    ///           
    ///                       // Examples
    ///                       @this.CreateAllDirectories(); // Create the directory the first time.
    ///           
    ///                       // Unit Test
    ///                       Assert.IsTrue(@this.Exists);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this, DirectorySecurity directorySecurity)
    {
        return Directory.CreateDirectory(@this.FullName, directorySecurity);
    }
}