using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Shared.Base;

namespace DataAccess {
	public class SongsSqlRepository : BaseSqlRepository<Song> {

		private string querySongs = "SELECT * FROM Songs";
		private string querySongsJoinAuthors = "SELECT a.firstname, a.lastname, s.name, s.duration, s.genre FROM Songs AS s INNER JOIN Authors AS a ON s.authorId = a.authorId";

		public override List<Song> GetList() {
			using (var connection = new SqlConnection(_connectionString)) {
				var command = new SqlCommand(querySongsJoinAuthors, connection);
				var songDataAccess = new List<Song>();
				try {
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read()) {
						songDataAccess.Add(new Song(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString()));
					}
				} catch (Exception e) {

					Console.WriteLine(e.ToString());
				}
				return songDataAccess;
			}
		}
	}
}
