using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class RoomFile : BaseModel
    {
        [Required(ErrorMessage = "Champ {0} obligatoire")]
        [StringLength(254)]
        [Display(Name = "Nom")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Champ {0} obligatoire")]
        [StringLength(100)]
        [Display(Name = "Type")]
        public string ContentType { get; set; }

        [Required(ErrorMessage = "Champ {0} obligatoire")]
        [Display(Name = "Contenu")]
        public byte[] Content { get; set; }

        [Display(Name = "Salle")]
        public int RoomID { get; set; }

        [ForeignKey("RoomID")]
        public Room Room { get; set; }

    }
}