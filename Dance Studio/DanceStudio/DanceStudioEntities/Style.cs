namespace DanceStudioEntities
{
    public class Style
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Style(int id, string name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}
