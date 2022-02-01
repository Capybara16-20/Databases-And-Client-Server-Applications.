using System;

namespace DanceStudioEntities
{
    public class Client
    {
        public int? ID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        public Client(string surname, string name, 
            string patronymic, DateTime birthDate, string phone)
        {
            ID = null;
            FullName = GetFullName(surname, name, patronymic);
            BirthDate = birthDate;
            Phone = phone;
        }
        public Client(int id, string fullName, DateTime birthDate, string phone)
        {
            ID = id;
            FullName = fullName;
            BirthDate = birthDate;
            Phone = phone;
        }

        private string GetFullName(string surname, string name, string patronymic)
        {
            return string.Format("{0} {1} {2}", surname, name, patronymic);
        }
    }
}
