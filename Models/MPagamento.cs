using System;
using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MPagamento
    {
        [Key]
        public int PagamentoID { get; set; }
        public int ReservaID { get; set; }
        public DateTime DataPagamento { get; set; }
        public string? MetodoPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataModificacao { get; set; }
        public MReserva Reserva { get; set; } = null!;
    }
}
