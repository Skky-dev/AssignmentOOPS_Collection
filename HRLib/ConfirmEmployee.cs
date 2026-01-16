using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee

    {
        // Git test
        private double basic;

        public double Basic
        {
            get { return basic; }
            set 
            { 
                if (value < 0)
                {
                    throw new InvalidBasicSalaryException("Basic Salary can not be negative");
                }
                if (value < 5000)
                {
                    throw new InvalidBasicSalaryException("Basic Salary below minimum value");
                }
                basic = value; 
            }
            
          
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set 
            { 
                if(value == null || value == " ")
                {
                    throw new InvalidDesignationException("Designation cannot be null or empty");
                }
                designation = value; 
            }
        }


        public sealed override double CalculateSalary()
        {
            double hra, conv, pf;

            if (Basic >= 30000)
            {
                hra = 0.3 * Basic;
                conv = 0.3 * Basic;
                pf = 0.1 * Basic;
            }
            if (Basic >= 20000)
            {
                hra = 0.2 * Basic;
                conv = 0.2 * Basic;
                pf = 0.1 * Basic;
            }
            else
            {
                hra = 0.1 * Basic;
                conv = 0.1 * Basic;
                pf = 0.1 * Basic;
            }
            Double netSalary = Basic + hra + conv - pf;
            return netSalary;
        }

        public ConfirmEmployee() : base()
        {
            Basic = 50000;
            Designation = "Intern";
        }
        public override string ToString()
        {
            return base.ToString() + $" | Designation: {Designation} | Basic: {Basic}";
        }
        public ConfirmEmployee(double _basic, string _designation, string name, string address) : base(name, address) {
            {
                this.Basic = _basic;
                this.Designation = _designation;

            }

        }
    }
}
