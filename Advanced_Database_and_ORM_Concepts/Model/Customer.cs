namespace Advanced_Database_and_ORM_Concepts.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public HashSet<Address> Addresses { get; set; } = new HashSet<Address>();
        public Customer() { }
    }
}