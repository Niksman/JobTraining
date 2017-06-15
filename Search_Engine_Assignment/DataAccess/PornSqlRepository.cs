using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class PornSqlRepository : BaseSqlRepository<Porn> {
		
		public override List<Porn> GetList() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand("Select * From Porn;", connection);
				var pornDataAccess = new List<Porn>();
				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						pornDataAccess.Add(new Porn(reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5])));
					}
				} catch (Exception e) {

					Console.WriteLine(e.ToString());
				}
				return pornDataAccess;
			}
		}
	}
}
