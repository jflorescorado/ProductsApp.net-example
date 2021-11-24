using System;
using System.Collections.Generic;
using System.Text;

// Imports
using System.ComponentModel.DataAnnotations;

namespace Products.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El codigo es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Code { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(150, ErrorMessage = "Maximo 150 caracteres")]
        public string ProductName { get; set; }

        [StringLength(1024, ErrorMessage = "Maximo 1024 caracteres")]
        public string Description { get; set; }
        public byte[] Image { get; set; }

        [Required(ErrorMessage = "El codigo de barra es obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public int BarCode { get; set; }

        [Required(ErrorMessage = "La existencia es obligatoria")]
        public int Existence { get; set; }

        public float SalePrice { get; set; }

        public float PriceCost { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        public char ProductStatus { get; set; } 
    }
}
