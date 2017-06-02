using System;
using System.Collections.Generic;
using System.Text;

namespace Search_Engine_Assignment
{
    interface IMapper <TFrom, TTo>
    {
		List<TTo> ConvertToList(TFrom input);
    }
}
