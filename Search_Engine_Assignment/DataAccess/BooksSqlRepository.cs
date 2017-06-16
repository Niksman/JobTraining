using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class BooksSqlRepository : BaseSqlRepository<Book> {

		private string queryBooks = "SELECT * FROM Books";
		private string queryBooksJoinAuthors = "SELECT a.firstname, a.lastname, b.name, b.description, b.pageCount, b.genre FROM Books AS b INNER JOIN Authors AS a ON b.authorId = a.authorId";

		public override List<Book> GetList() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand(queryBooksJoinAuthors, connection);
				var bookDataAccess = new List<Book>();
				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						bookDataAccess.Add(new Book(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), reader[5].ToString()));
					}
				} catch (Exception e) {

					Console.WriteLine(e.ToString());
				}
				return bookDataAccess;
			}
		}
	}
}
