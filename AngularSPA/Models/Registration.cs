namespace AngularSPA.Models
{
    using System.ComponentModel.DataAnnotations;
    using Controllers;

    public class Registration
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Distance { get; set; }

        public CarManufacturer CarManufacturer { get; set; }

        public WorldRegion Location { get; set; }
    }
}