using System;
using System.ComponentModel.DataAnnotations;

namespace api1
{
    public class MFuncionario
    {
        [Key]
        public int FuncionarioID { get; set; }
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
