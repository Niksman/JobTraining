using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class BooksSqlRepository : BaseSqlRepository<Book> {

		public override List<Book> GetList() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand("Select * From Books;", connection);
				var bookDataAccess = new List<Book>();
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
