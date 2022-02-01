namespace Entities
{
    public class Style
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Coefficient { get; set; }

        public Style(int id, string name, double coefficient)
        {
            ID = id;
            Name = name;
            Coefficient = coefficient;
        }
    }
}
