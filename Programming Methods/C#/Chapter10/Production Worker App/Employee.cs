using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_Worker_App
{
	public class Employee
	{
		private string _name;
		private int _number;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Number
		{
			get { return _number; }
			set { _number = value; }
		}

		public Employee()
		{
			_name = string.Empty;
			_number = 0;
		}
	}
}
