using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MFilial
    {
        [Key]
        public int FilialID { get; set; }
        public string? Nome { get; set; }
        public int NumeroQuartosSolteiro { get; set; }
        public int NumeroQuartosCasal { get; set; }
        public int NumeroQuartosFamilia { get; set; }
        public int NumeroQuartosPresidencial { get; set; }
        public string? Endereco { get; set; }
        public int QuantidadeEstrelas { get; set; }
    }
}