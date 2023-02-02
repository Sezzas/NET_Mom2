using System;
using System.ComponentModel.DataAnnotations;
namespace NET_Mom2.Models {

    public class Horses {

        // Properties
        public int Id { get; set; } // ID

        [Required]
        public String? HorseName { get; set; } // Namn

        public String? HorseNickname { get; set; } // Smeknamn

        public String? HorseGender { get; set; } // Kön

        [Required]
        public String? HorseBreed { get; set; } // Ras

        [Required]
        public int HorseLevel { get; set; } // level

    }

}

