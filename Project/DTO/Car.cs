namespace Project.DTO
{
    public class Car
    {
        public string Id { get; set; }
        public int CountPlacesInCar { get; set; }
        public bool Status { get; set; }
        public Car()
        {

        }

        public Car(int id, int countPlacesInCar, bool status)
        {
            Id = id;
            CountPlacesInCar = countPlacesInCar;
            Status = status;
        }
    }
}
