using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MarketUygulamasi.Core.Entities;

namespace Market.Entities.Concrete
{
    public class Product:IEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId { get; set; } //Urun turunu kategori diye yazdım.
        [Required]
        public short UnitsInStock { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
    }
}
