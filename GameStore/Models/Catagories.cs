using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GameStore.Models;

namespace GameStoreAdmin.Models
{
    public class Catagories
    {
        public int CatagoriesId { get; set; }
        public string? CatagoriesName { get; set; }
        //public ICollection<CatagoryCob> CatagoryCobs { get; set; }
    }
}