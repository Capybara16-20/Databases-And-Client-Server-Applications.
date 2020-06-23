using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Deal
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
        private int customer;
        public int Customer
        {
            get { return customer; }
            set
            {
                customer = value;
            }
        }
        private int employee;
        public int Employee
        {
            get { return employee; }
            set
            {
                employee = value;
            }
        }
        private int hopelessnessLevel;
        public int HopelessnessLevel
        {
            get { return hopelessnessLevel; }
            set
            {
                hopelessnessLevel = value;
            }
        }
        private int agreementType;
        public int AgreementType
        {
            get { return agreementType; }
            set
            {
                agreementType = value;
            }
        }
        private int? stage;
        public int? Stage
        {
            get { return stage; }
            set
            {
                stage = value;
            }
        }
        private int? status;
        public int? Status
        {
            get { return status; }
            set
            {
                status = value;
            }
        }
        public Deal()
        {
            this.ID = GetID();
        }
        public Deal(int customer, int employee, int level, int type)
        {
            this.Customer = customer;
            this.Employee = employee;
            this.HopelessnessLevel = level;
            this.AgreementType = type;
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
