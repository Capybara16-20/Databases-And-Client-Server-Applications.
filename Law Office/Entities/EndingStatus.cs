using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class EndingStatus
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
        private string status;
        public string Status
        {
            get { return status; }
            set
            {
                status = value;
            }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
    }
}
