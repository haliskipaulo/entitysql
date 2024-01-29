using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MServicoLavanderia
    {
        [Key]
        public int ServicoLavanderiaID { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
