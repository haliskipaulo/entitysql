using System;
using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MConsumo
    {
        [Key]
        public int ConsumoID { get; set; }
        public int ReservaID { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataModificacao { get; set; }
        public MReserva Reserva { get; set; } = null!;
    }
}
