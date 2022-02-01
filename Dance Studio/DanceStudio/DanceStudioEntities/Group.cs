namespace DanceStudioEntities
{
    public class Group
    {
        public int ID { get; set; }
        public int ClientsCount { get; set; }
        public string Style { get; set; }
        public int Number { get; set; }

        public Group(int id, int clientsCount, string style, int number)
        {
            ID = id;
            ClientsCount = clientsCount;
            Style = style;
            Number = number;
        }
    }
}
