namespace Project.DTO
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Destination { get; set; }
        public Customer()
        {
            
        }

        public Customer(int id, string name, string email, string address, string phone, string destination)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Phone = phone;
            Destination = destination;
        }
    }
}
