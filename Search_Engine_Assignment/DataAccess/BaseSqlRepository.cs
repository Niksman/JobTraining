using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ServicesClassLibrary.Base;

namespace DataAccess {
	public abstract class BaseSqlRepository<T> : IReadableList<T> {
		private const string _connectionString = @"Data Source=SUPPER-MARIO\SQLEXPRESS;Initial Catalog=SEA_DB;Integrated Security=true";

		public abstract List<T> GetList();

		public void Test() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand("SELECT * FROM Authors;", connection);

				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						Console.WriteLine($"ID: {reader[0]}, Full Name: {reader[1]} {reader[2]}");
					}
				} catch (Exception e) {
					Console.WriteLine(e.ToString());
				}

			}
		}
	}
}
