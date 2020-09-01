using System;

namespace RestApiModeloDDD.Domain.Entitys
{
    public class Clientes : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
    }
}
