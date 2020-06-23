using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Customer
    {
        private int id;
        public int ID
        {
            get { return id; }
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
    }
}
