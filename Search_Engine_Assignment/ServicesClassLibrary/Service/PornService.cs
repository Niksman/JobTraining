using System;
using System.Collections.Generic;
using System.Text;
using ServicesClassLibrary.Base;
using Shared.Base;
using DataAccess;

namespace ServicesClassLibrary.Service {
	public class PornService : IReadableList<Porn> {

		public List<Porn> GetList() {
			var pornList = new PornSqlRepository().GetList();
			return pornList;
		}
	}
}
