namespace Entities
{
    public class Size
    {
        public int ID { get; set; }
        public string Sizes { get; set; }
        public double Coefficient { get; set; }

        public Size(int id, string sizes, double coefficient)
        {
            ID = id;
            Sizes = sizes;
            Coefficient = coefficient;
        }
    }
}
