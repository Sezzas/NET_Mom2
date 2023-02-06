using System;
using System.ComponentModel.DataAnnotations;
namespace NET_Mom2.Models {

    public class Horses {

        // Properties
        public int Id { get; set; } // ID

        [Required(ErrorMessage = "Du måste ange hästens namn.")]
        [Display(Name = "Namn:")]
        public String? HorseName { get; set; } // Namn

        [Display(Name = "Smeknamn:")]
        public String? HorseNickname { get; set; } // Smeknamn

        [Display(Name = "Kön:")]
        public String? HorseGender { get; set; } // Kön

        [Required(ErrorMessage = "Du måste ange hästens ras.")]
        [Display(Name = "Ras:")]
        public String? HorseBreed { get; set; } // Ras

        [Required(ErrorMessage = "Du måste ange hästens level.")]
        [Display(Name = "Level:")]
        public int HorseLevel { get; set; } // level

    }

}

