namespace DanceStudioEntities
{
    public class Membership
    {
        public int? ID { get; set; }
        public string Client { get; set; }
        public string MembershipType { get; set; }
        public int IndividualCount { get; set; }
        public double Price { get; set; }

        public Membership(string client, string membershipType,
            int individualCount, double price)
        {
            ID = null;
            Client = client;
            MembershipType = membershipType;
            IndividualCount = individualCount;
            Price = price;
        }

        public Membership(int id, string client, string membershipType,
            int individualCount, double price)
        {
            ID = id;
            Client = client;
            MembershipType = membershipType;
            IndividualCount = individualCount;
            Price = price;
        }
    }
}
