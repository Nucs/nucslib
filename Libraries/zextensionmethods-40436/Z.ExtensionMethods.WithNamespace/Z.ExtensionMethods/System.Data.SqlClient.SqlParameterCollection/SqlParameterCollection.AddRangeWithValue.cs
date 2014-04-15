// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System.Collections.Generic;
using System.Data.SqlClient;

namespace Z.ExtensionMethods
{
    public static class SqlParameterCollectionExtension
    {
        /// <summary>
        ///     A SqlParameterCollection extension method that adds a range with value to 'values'.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="values">The values.</param>
        public static void AddRangeWithValue(this SqlParameterCollection @this, Dictionary<string, object> values)
        {
            foreach (var keyValuePair in values)
            {
                @this.AddWithValue(keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}