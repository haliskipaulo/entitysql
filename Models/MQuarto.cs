using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MQuarto
    {
        [Key]
        public int QuartoID { get; set; }
        public int FilialID { get; set; }
        public int NumeroQuarto { get; set; }
        public string? TipoQuarto { get; set; }
        public bool Adaptado { get; set; }
        public int CapacidadeMaxima { get; set; }
        public float CapacidadeOpcional { get; set; }
        public MFilial Filial { get; set; } = null!;
    }
}
