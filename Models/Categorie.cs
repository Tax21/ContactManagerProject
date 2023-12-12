﻿using System.ComponentModel.DataAnnotations;

namespace ContactManagerProject.Models
{
    public class Categorie
    {
        public int CategorieID { get; set; } // PK

        [Required(ErrorMessage = "Le champ Nom est obligatoire.")]
        public string Nom { get; set; }

        //========================= Navigation Properties =================================
        public virtual ICollection<Contact>? Contacts { get; set; }
    }
}
