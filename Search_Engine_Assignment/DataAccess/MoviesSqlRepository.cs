using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class MoviesSqlRepository : BaseSqlRepository<Movie> {

		public override List<Movie> GetList() {
			List<Movie> movieList = GetData();
			return movieList;
		}

		private const string _connectionString = @"Data Source=SUPPER-MARIO\SQLEXPRESS;Initial Catalog=SEA_DB;Integrated Security=true";

		public override List<Movie> GetData() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand("Select * From Movies;", connection);
				List<Movie> movieDataAccess = new List<Movie>();
				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						movieDataAccess.Add(new Movie(reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), reader[5].ToString()));
					}
				} catch (Exception e) {

					Console.WriteLine(e.ToString());
				}
				return movieDataAccess;
			}
		}
	}
}
