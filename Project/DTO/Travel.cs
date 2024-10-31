namespace Project.DTO
{
    public class Travel
    {
        public int IdOfVolunteer { get; set; }
        public int IdOfCar { get; set; }
        public int numberofpassengers { get; set; }
        public DateTime TimeOfTraveling { get; set; }
        public DateTime TravelTime { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public Travel()
        {
            
        }

        public Travel(int idOfVolunteer, int idOfCar, int numberofpassengers, DateTime timeOfTraveling, DateTime travelTime, string source, string destination)
        {
            IdOfVolunteer = idOfVolunteer;
            IdOfCar = idOfCar;
            this.numberofpassengers = numberofpassengers;
            TimeOfTraveling = timeOfTraveling;
            TravelTime = travelTime;
            this.source = source;
            this.destination = destination;
        }
    }
}
