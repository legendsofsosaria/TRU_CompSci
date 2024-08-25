namespace Production_Worker_App
{
	public class ProductionWorker : Employee
	{
		private int _shiftNumber;
		private double _hourlyPay;

		public int ShiftNumber
		{
			get { return _shiftNumber; }
			set { _shiftNumber = value; }
		}

		public double HourlyPay
		{
			get { return _hourlyPay; }
			set { _hourlyPay = value; }
		}

		public ProductionWorker()
		{
			_hourlyPay = 0;
			_shiftNumber = 0;
		}
	}
}
