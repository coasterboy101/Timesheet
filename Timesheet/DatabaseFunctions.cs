using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Timesheet
{
	class DatabaseFunctions
	{
		private MySqlConnection dbConnection;

		/// <summary>
		/// Runs a stored procedure and returns a datatable containing the result set.
		/// </summary>
		/// <param name="connString">The database connection string.</param>
		/// <param name="procName">The name of the stored procedure to execute.</param>
		/// <param name="parameters">The parameters to supply to stored procedure with.</param>
		/// <returns></returns>
		public DataTable FillStoredProc(string connString, string procName, List<MySqlParameter> parameters)
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
	}
}
