using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class BooksSqlRepository : BaseSqlRepository<Book> {

		public override List<Book> GetList() {
			List<Book> bookList = GetData();
			return bookList;
		}

		private const string _connectionString = @"Data Source=SUPPER-MARIO\SQLEXPRESS;Initial Catalog=SEA_DB;Integrated Security=true";

		public override List<Book> GetData() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand("Select * From Books;", connection);
				List<Book> bookDataAccess = new List<Book>();
				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						bookDataAccess.Add(new Book(reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), reader[5].ToString()));
					}
				} catch (Exception e) {

					Console.WriteLine(e.ToString());
				}
				return bookDataAccess;
			}
		}
	}
}
