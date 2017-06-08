using System.Collections.Generic;

namespace Search_Engine_Assignment {
	interface IMapper<TFrom, TTo> {
		List<TTo> ConvertToList(TFrom input);
	}
}
