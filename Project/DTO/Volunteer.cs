namespace Project.DTO
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CountTravelingInMonth { get; set; }
        public Car DetailsOfCar { get; set; }
        public Volunteer()
        {
            
        }

        public Volunteer(int id, string name, string email, string address, string phone, int countTravelingInMonth, Car detailsOfCar)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Phone = phone;
            CountTravelingInMonth = countTravelingInMonth;
            DetailsOfCar = detailsOfCar;
        }
    }
}
