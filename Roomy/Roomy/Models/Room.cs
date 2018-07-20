﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Models
{
    public class Room : BaseModel
    {
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [StringLength(50)]
        [Display(Name = "Libellé")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]        
        [Display(Name = "Nombre de place.")]
        [Range(0, 50)]
        public int Capacity{ get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]        
        [Display(Name = "Tarif")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [Display(Name = "Date de création")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dddd dd MMMM yyyy}")]//format d'affichage qui va avoir dans la vue
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Utilisateur/créateur")]
        public int? UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }


        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [Display(Name = "Catégorie")]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public ICollection<RoomFile> Files { get; set; } //(permet de rechercher un fichier) 
    }
}