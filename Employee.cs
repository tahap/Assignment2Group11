using System;
namespace Assignment2Group11
{
    class Employee
    {
        private readonly int employeeUserId;
        private string firstName;
        private string lastName;
        private double basicSalary = 2000.00;
        private double grossSales;
        private double commissionRate = 0.2;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }
        public double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }
    }
}