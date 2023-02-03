using System;
using System.ComponentModel.DataAnnotations;
namespace NET_Mom2.Models {

    public class Notes {

        // Properties
        public int Id { get; set; } // ID

        [Required]
        public String? NoteTitle { get; set; } // Titel

        public String? NoteBody { get; set; } // Anteckningar

    }

}
