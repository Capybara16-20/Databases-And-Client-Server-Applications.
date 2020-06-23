using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Stage
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
        private string step;
        public string Step
        {
            get { return step; }
            set
            {
                step = value;
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
