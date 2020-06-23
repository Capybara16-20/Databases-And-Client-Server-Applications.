using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Payment
    {
        private int deal;
        public int Deal
        {
            get { return deal; }
            set
            {
                deal = value;
            }
        }
        private int paymentType;
        public int PaymentType
        {
            get { return paymentType; }
            set
            {
                paymentType = value;
            }
        }
        private double sum;
        public double Sum
        {
            get { return sum; }
            set
            {
                sum = value;
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
    }
}
