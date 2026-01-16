using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
		private int noOfDays;

		public int NoOfDays
		{
			get { return noOfDays; }
			set { noOfDays = value; }
		}

		private double ratePerDay;

		public double RatePerDay
		{
			get { return ratePerDay; }
			set { ratePerDay = value; }
		}

        public Trainee() : base() 
        {
			NoOfDays = 90;
			RatePerDay = 500;
        }

        public Trainee(string name, string address, double _ratePerDay,int _noOfDays ) : base(name, address)
        {
            this.RatePerDay = _ratePerDay;
			this.NoOfDays = _noOfDays;
        }

        public override string ToString()
        {
            return base.ToString() + $" | No of Days: {NoOfDays} | Rate per day: {RatePerDay}";
        }

        public sealed override double CalculateSalary()
        {
            return RatePerDay * NoOfDays;
        }




    }
}
