using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public Genre Genre { get; set; }

        [Required]
       
        public int Year { get; set; }

        public string Actors { get; set; }
        public string Directors { get; set; }
    }
    public enum Genre
    {
        
        SciFi,
        Action,
        Horror,
        Comedy
    }
}