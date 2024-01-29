using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MCliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Nacionalidade { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}