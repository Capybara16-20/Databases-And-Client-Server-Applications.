using System;

namespace Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Client(int id, string fullName, DateTime birthDate, string address, string phone)
        {
            ID = id;
            FullName = fullName;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
        }
    }
}
