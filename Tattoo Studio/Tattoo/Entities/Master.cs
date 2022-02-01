using System;

namespace Entities
{
    public class Master
    {
        public int ID { get; set; }
        public string Specialty { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Master(int id, string specialty, string fullName, DateTime birthDate, string address, string phone)
        {
            ID = id;
            Specialty = specialty;
            FullName = fullName;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
        }
    }
}
