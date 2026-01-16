namespace HRLib
{
    public abstract class Employee
    {
		// Git Test
		private string name;

		private static int count = 100;

		private int empNo;
				
		public int EmpNo
		{
			get { return empNo; }
			set { empNo = value; }
		}


		public string Name
		{
			get { return name; }
			set { name  = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

        public Employee()
        {
			Name = "John Doe";
			Address = "USA";
			EmpNo = count++;
        }

        public Employee(string _name , string _address)
        {
			this.Name = _name;
			this.Address = _address;
			EmpNo = count++;
        }

		public abstract double CalculateSalary();

        public override string ToString()
        {
            return $"Name: {Name} | Address: {Address} | EmpNo: {EmpNo}";
        }

    }
}
