﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThotMVC.Models
{
    public class Zonas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Number")]
        public Int64 Id { get; set; }

        [Display(Name = "Código")]
        [Required(ErrorMessage = "Digite el código de la zona")]
        public Int64 Codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Digite el nombre de la zona")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Display(Name = "Estado")]
        public bool Activo { get; set; }

        public Int64? UsuarioRegistra { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }

        public Int64? UsuarioModifica { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaModifica { get; set; }
    }
}