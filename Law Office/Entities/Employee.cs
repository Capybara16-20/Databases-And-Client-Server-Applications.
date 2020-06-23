using System;
using System.Text;

namespace Entities
{
    public class Employee
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
            }
        }
        private int specialty;
        public int Specialty
        {
            get { return specialty; }
            set
            {
                specialty = value;
            }
        }
        private int expirience;
        public int Experience
        {
            get { return expirience; }
            set
            {
                expirience = value;
            }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }
        private double? statistics;
        public double? Statistics
        {
            get { return statistics; }
            set
            {
                statistics = value;
            }
        }
        private int? rankingPlace;
        public int? RankingPlace
        {
            get { return rankingPlace; }
            set
            {
                rankingPlace = value;
            }
        }
        public Employee() 
        {
            this.ID = GetID();
        }
        public Employee(string fullName, int specialty, int experience)
        {
            this.FullName = fullName;
            this.Specialty = specialty;
            this.Experience = experience;
            this.id = GetID();
        }
        private int GetID()
        {
            Guid guid = Guid.NewGuid();
            string strGuid = guid.ToString().Replace("-", "");
            StringBuilder sb = new StringBuilder();
            int count = 0;
            while (sb.Length < 6)
            {
                if (char.IsDigit(strGuid[count]))
                {
                    sb.Append(strGuid[count]);
                }
                count++;
            }
            return Int32.Parse(sb.ToString());
        }
    }
}
