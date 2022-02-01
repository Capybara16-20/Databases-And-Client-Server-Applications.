namespace DanceStudioEntities
{
    public class MembershipType
    {
        public int ID { get; set; }
        public string Style { get; set; }
        public int WorkoutsCount { get; set; }
        public string Name { get; set; }

        public MembershipType(int id, string style, int workoutsCount, string name)
        {
            ID = id;
            Style = style;
            WorkoutsCount = workoutsCount;
            Name = name;
        }
    }
}
