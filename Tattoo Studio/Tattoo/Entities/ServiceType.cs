namespace Entities
{
    public class ServiceType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ServiceType(int id, string name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}
