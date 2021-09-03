namespace Control.Core.Entities
{
    public class Address
    {
        public int Id { get; private set };
        public string FullAddress { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string Neighbourhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }

        public Address(string fullAddress, string number, string complement, string neighbourhood, string city, string state, string zipCode, string country)
        {
            FullAddress = fullAddress;
            Number = number;
            Complement = complement;
            Neighbourhood = neighbourhood;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;

        }
    }
}
