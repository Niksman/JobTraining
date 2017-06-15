using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ServicesClassLibrary.Base;

namespace DataAccess {
	public abstract class BaseSqlRepository<T> : IReadableList<T> {

		protected const string _connectionString = @"Data Source=SUPPER-MARIO\SQLEXPRESS;Initial Catalog=SEA_DB;Integrated Security=true";

		public abstract List<T> GetList();
	}
}
