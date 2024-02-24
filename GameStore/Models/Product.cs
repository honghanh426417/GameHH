using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageGame { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Catagories { get; set; }
        public string? Review { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        //public ICollection<CatagoryCob> CatagoryCobs { get; set; }
        public decimal DiscountedPrice => Price - (Price * DiscountPercentage / 100);
    }
}

