﻿// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System.Data.SqlClient;

namespace Z.Utility
{
    internal partial class SqlBulkOperation
    {
        /// <summary>
        ///     Executes the bulk action.
        /// </summary>
        public void ExecuteBulkAction()
        {
            using (var sqlCommand = new SqlCommand(SqlBulkAction, SqlConnection))
            {
                sqlCommand.Transaction = SqlTransaction;
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}