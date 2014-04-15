// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Z.ExtensionMethods.EntityFramework
{
    public static partial class DatabaseExtension
    {
        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction) where T : new()
        {
            var connection = (SqlConnection) @this.Connection;

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = cmdText;
                command.CommandType = commandType;
                command.Transaction = transaction;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (IDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.ToEntity<T>();
                }
            }
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="commandFactory">The command factory.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, Action<SqlCommand> commandFactory) where T : new()
        {
            var connection = (SqlConnection) @this.Connection;

            using (SqlCommand command = connection.CreateCommand())
            {
                commandFactory(command);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (IDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.ToEntity<T>();
                }
            }
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, SqlTransaction transaction) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, CommandType commandType) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, CommandType commandType, SqlTransaction transaction) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, SqlParameter[] parameters) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        ///     A Database extension method that SQL execute entity.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="cmdText">The command text.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns>A T.</returns>
        public static T SqlExecuteEntity<T>(this Database @this, string cmdText, SqlParameter[] parameters, CommandType commandType) where T : new()
        {
            return @this.SqlExecuteEntity<T>(cmdText, parameters, commandType, null);
        }
    }
}