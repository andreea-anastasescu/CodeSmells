using System.Text;

namespace CodeSmells.Bloaters.LongClass.MultipleResponsabilities.FeatureEnvy
{
    class Customer
    {

        private string firstName;
        private string lastName;
        //...
        private Address currentAddress = null;

        public string MailingAddress()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(currentAddress.AddressLine1);
            sb.Append("\n");
            sb.Append(currentAddress.City + ", " + currentAddress.State);
            sb.Append("\n");
            sb.Append(currentAddress.PostalCode);
            return sb.ToString();
        }
    }

    public class Address
    {
        public string AddressLine1 { get; internal set; }
        public string City { get; internal set; }
        public string State { get; internal set; }
        public char PostalCode { get; internal set; }
    }

}
