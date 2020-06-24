using System;
using System.Text;

namespace Entities
{
    public class Deal
    {
        public int ID { get; set; }
        public int Customer { get; set; }
        public int Employee { get; set; }
        public int HopelessnessLevel { get; set; }
        public int AgreementType { get; set; }
        public int? Stage { get; set; }
        public int? Status { get; set; }

        public Deal()
        {
            this.ID = IDCalculator.GetID();
        }
        public Deal(int customer, int employee, int level, int type)
        {
            this.Customer = customer;
            this.Employee = employee;
            this.HopelessnessLevel = level;
            this.AgreementType = type;
            this.ID = IDCalculator.GetID();
        }
        
    }
}
