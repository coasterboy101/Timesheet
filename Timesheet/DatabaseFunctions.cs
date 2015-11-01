using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Timesheet
{
	class DatabaseFunctions
	{
		private MySqlConnection dbConnection;

		private string connString;

		/// <summary>
		/// Creates a new instance with the given connection string.
		/// </summary>
		/// <param name="connString">The connection string to the database.</param>
		public DatabaseFunctions(string connString)
		{
			this.connString = connString;
		}

		/// <summary>
		/// Runs a stored procedure and returns a datatable containing the result set.
		/// </summary>
		/// <param name="procName">The name of the stored procedure to execute.</param>
		/// <param name="parameters">The parameters to supply to stored procedure with.</param>
		/// <returns>A datatable containing the result set.</returns>
		public DataTable FillStoredProc(string procName, List<MySqlParameter> parameters)
		{
			using (dbConnection = new MySqlConnection(connString))
			{
				if (dbConnection.State != ConnectionState.Open) dbConnection.Open();

				MySqlCommand dbCommand = new MySqlCommand(procName, dbConnection);
				dbCommand.CommandType = CommandType.StoredProcedure;

				// Loop through the parameters, and add each one to dbCommand's parameter collection.
				foreach (MySqlParameter param in parameters)
				{
					dbCommand.Parameters.Add(param);
				}

				// Fill the datatable with the result set, then return it.
				DataTable dbTable = new DataTable("");
				MySqlDataAdapter dbAdapter = new MySqlDataAdapter(dbCommand);
				dbAdapter.Fill(dbTable);

				return dbTable;
			}
		}

		/// <summary>
		/// Runs a stored procedure.
		/// </summary>
		/// <param name="procName">The name of the stored procedure to execute.</param>
		/// <param name="parameters">The parameters to supply to stored procedure with.</param>
		public void ExecuteStoredProc(string procName, List<MySqlParameter> parameters)
		{
			using (dbConnection = new MySqlConnection(connString))
			{
				if (dbConnection.State != ConnectionState.Open) dbConnection.Open();

				MySqlCommand dbCommand = new MySqlCommand(procName, dbConnection);
				dbCommand.CommandType = CommandType.StoredProcedure;

				// Loop through the parameters, and add each one to dbCommand's parameter collection.
				foreach (MySqlParameter param in parameters)
				{
					dbCommand.Parameters.Add(param);
				}

				// Execute the command.
				dbCommand.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// Runs inline SQL code and returns a datatable containing the result set.
		/// </summary>
		/// <param name="sqlString">The inline SQL to run.</param>
		/// <param name="parameters">The parameters contained in the inline SQL code.</param>
		/// <returns>A datatable containing the result set.</returns>
		public DataTable FillInlineSql(string sqlString, List<MySqlParameter> parameters)
		{
			using (dbConnection = new MySqlConnection(connString))
			{
				if (dbConnection.State != ConnectionState.Open) dbConnection.Open();

				MySqlCommand dbCommand = new MySqlCommand(sqlString, dbConnection);

				//Loop through the parameters, and add each on to dbCommand's parameter collection.
				foreach (MySqlParameter param in parameters)
				{
					dbCommand.Parameters.Add(param);
				}

				// Fill the datatable with the result set, then return it.
				DataTable dbTable = new DataTable("");
				MySqlDataAdapter dbAdapter = new MySqlDataAdapter(dbCommand);
				dbAdapter.Fill(dbTable);

				return dbTable;
			}
		}

		/// <summary>
		/// Removes all non-letter characters from a string.
		/// </summary>
		/// <param name="withNonLetters">The string to process.</param>
		/// <returns>A string with all non-letter characters removed.</returns>
		public string RemoveNonLetters(string withNonLetters)
		{
			return Regex.Replace(withNonLetters, "[^A-Za-z]", "");
    }
	}
}
