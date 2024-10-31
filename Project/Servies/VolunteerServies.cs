using Project.DTO;
using System.Reflection.Metadata.Ecma335;

namespace Project.Servies
{
    public class VolunteerServies
    {
        //put עדכון
        //post הוספה
        static List<Volunteer> volunteers = new List<Volunteer>() { new Volunteer() {Id=1,Name="Moshe",Address="yeoshua",Email="M000@gmail.com",Phone="0548577747",CountTravelingInMonth=4,
            DetailsOfCar=new Car(){Id="111111",CountPlacesInCar=6,Status=false } } };
        public List<Volunteer> GetListOfVolunteers { get; set; }
        public V

    }
}
