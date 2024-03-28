using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age,decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            private set
            {
                if (value.Length > 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                firstname = value;
            }
        }
        public string LastName
        {
            get => lastname;
            
            private set
            {
                if (value.Length > 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                lastname = value;
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                age = value;
            }

        }
        public decimal Salary
        {
            get => salary;
            private set
            {
                if (value >= 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal parcentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * parcentage / 100;
            }
            else
            {
                this.Salary += this.Salary * parcentage / 200;
            }
        }
    }
}
