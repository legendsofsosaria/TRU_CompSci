using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	public class Car
	{
		private int _speed;
		private int _year;
		private string _make;

		public int Speed
		{
			get { return _speed; }
			private set { _speed = value; }
		}

		public int Year
		{
			get { return _year; }
			private set { _year = value; }
		}

		public string Make
		{
			get { return _make; }
			private set { _make = value; }
		}

		public Car(int year, string make)
		{
			_year = year;
			_make = make;
			_speed = 0;
		}

		public void Accelerate()
		{
			_speed += 5;
		}

		public void Brake()
		{
			if (_speed >= 5)
			{
				_speed -= 5;
			}
			else
			{
				_speed = 0;
			}
		}
	}
}