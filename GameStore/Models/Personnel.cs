using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
	public class Personnel
	{
		[Key]
		public int PersId { get; set; }
		[Required(ErrorMessage = "Пожалуйста введите свое имя")]
		public string Name { get; set; }

		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string Line3 { get; set; }

		public string City { get; set; }
		
		public string Style { get; set; }

		public string Groupe { get; set; }

		//public virtual List<OrderLine> OrderLines { get; set; }
	}
}