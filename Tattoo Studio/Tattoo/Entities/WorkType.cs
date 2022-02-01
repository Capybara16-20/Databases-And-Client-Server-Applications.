namespace Entities
{
    public class WorkType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double OriginTime { get; set; }

        public WorkType(int id, string name, double originTime)
        {
            ID = id;
            Name = name;
            OriginTime = originTime;
        }
    }
}
