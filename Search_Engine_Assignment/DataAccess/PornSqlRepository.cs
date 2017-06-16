using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class PornSqlRepository : BaseSqlRepository<Porn> {

		private string queryPorn = "SELECT * FROM Porn";
		private string queryPornJoinAuthors = "SELECT a.firstname, a.lastname, p.name, p.pornstar, p.duration, p.rating FROM Porn AS p INNER JOIN Authors AS a ON p.authorId = a.authorId";
		
		public override List<Porn> GetList() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand(queryPornJoinAuthors, connection);
				var pornDataAccess = new List<Porn>();
				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						pornDataAccess.Add(new Porn(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5])));
					}
				} catch (Exception e) {

					Console.WriteLine(e.ToString());
				}
				return pornDataAccess;
			}
		}
	}
}
