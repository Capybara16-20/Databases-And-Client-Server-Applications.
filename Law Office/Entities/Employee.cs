using System;
using System.Text;

namespace Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Specialty { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }
        public double? Statistics { get; set; }
        public int? RankingPlace { get; set; }

        public Employee() 
        {
            this.ID = IDCalculator.GetID();
        }
        public Employee(string fullName, int specialty, int experience)
        {
            this.FullName = fullName;
            this.Specialty = specialty;
            this.Experience = experience;
            this.ID = IDCalculator.GetID();
        }
    }
}
