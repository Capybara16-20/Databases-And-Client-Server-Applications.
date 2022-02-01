using System;

namespace Entities
{
    public class ServiceRecord
    {
        public int? ID { get; set; }
        public string Master { get; set; }
        public string Client { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public double Price { get; set; }

        public ServiceRecord(string master, string client, string serviceType, 
            DateTime date, DateTime time, double price)
        {
            ID = null;
            Master = master;
            Client = client;
            ServiceType = serviceType;
            Date = date;
            Time = time.ToString("hh:mm tt");
            Price = price;
        }
        public ServiceRecord(int id, string master, string client, string serviceType,
            DateTime date, DateTime time, double price)
        {
            ID = id;
            Master = master;
            Client = client;
            ServiceType = serviceType;
            Date = date;
            Time = time.ToString("hh:mm tt");
            Price = price;
        }
    }
}
