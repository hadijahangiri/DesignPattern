namespace Person.Domain
{
    public class Address
    {
        public string Street { get; set; }
        public int Plaque { get; set; }
        public int Unit { get; set; }

        public Address(string street, int plaque, int unit)
        {
            Street = street;
            Plaque = plaque;
            Unit = unit;
        }
    }
}