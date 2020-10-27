using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicBreadCrumbs.Models
{
	public class Breadcrumb
	{
		public string Text { get; set; }
		public string Action { get; set; }
		public string Controller { get; set; }
		public bool Active { get; set; }
	}
}