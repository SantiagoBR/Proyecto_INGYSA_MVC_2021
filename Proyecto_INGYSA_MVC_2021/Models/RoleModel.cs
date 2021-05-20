using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Models
{
    public class RoleModel
    {
        [Key]
        [Column(Order = 1)]
        public int RoleID { get; set; }
        [Required]
        [Display(Name = "Rol")]
        public string Role { get; set; }
    }
}