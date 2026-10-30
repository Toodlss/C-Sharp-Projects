using System.ComponentModel.DataAnnotations;

namespace TheatreCMS3.Areas.Rent.Models
{
    public class RentalHistory
    {
        [Key]
        public int RentalHistoryId { get; set; }
        public bool RentalDamaged { get; set; }
        public string DamagesIncurred { get; set; }
        public string Rental { get; set; }
    }
}