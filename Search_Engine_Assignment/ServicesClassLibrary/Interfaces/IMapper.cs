using System.Collections.Generic;

namespace ServicesClassLibrary.Base {
	public interface IMapper<TFrom, TTo> {
		List<TTo> ConvertToList(TFrom input);
	}
}
