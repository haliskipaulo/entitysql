using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MTipoHotel
    {
        [Key]
        public int TipoHotelID { get; set; }
        public string? Nome { get; set; }
    }
}
