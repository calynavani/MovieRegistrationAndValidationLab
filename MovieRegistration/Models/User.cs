namespace MovieRegistration.Models
{



    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public State State { get; set; }
        public string FavColor { get; set;}

        
    }

    public enum State
    {
        MI,
        VA,
        TX,
        CA,
        FL,
        MO,
        IN,
        OH,
        PA,
        GA,
        SC,
        NC

    }
}
