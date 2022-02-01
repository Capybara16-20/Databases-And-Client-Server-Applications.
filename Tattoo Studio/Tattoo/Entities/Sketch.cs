namespace Entities
{
    public class Sketch
    {
        public int? ID { get; set; }
        public string Style { get; set; }
        public string Size { get; set; }
        public double Time { get; set; }

        public Sketch(string style, string size, double time)
        {
            ID = null;
            Style = style;
            Size = size;
            Time = time;
        }
        public Sketch(int id, string style, string size, double time)
        {
            ID = id;
            Style = style;
            Size = size;
            Time = time;
        }
    }
}
