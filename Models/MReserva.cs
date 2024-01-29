using System;
using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MReserva
    {
        [Key]
        public int ReservaID { get; set; }
        public int ClienteID { get; set; }
        public int QuartoID { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool Cancelada { get; set; }
        public string? Status { get; set; }
        public DateTime DataModificacao { get; set; }
        public MCliente Cliente { get; set; } = null!;
        public MQuarto Quarto { get; set; } = null!;
    }
}
