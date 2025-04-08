using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
	public partial class Absence
	{
		// constructores
		public Absence()
		{
			//Sin relaciones en esta dirección
		}

		public Absence(DateTime date)
		{
			this.Date = date;
			this.Id = 1;
		}
	}
}
