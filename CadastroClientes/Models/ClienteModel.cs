﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CadastroClientes.Models
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }
        public string? NomeCliente { get; set; }

        public string? CpfCliente { get; set; }

        public List<Endereco>? EnderecoCliente { get; set; }
    }

    public class Endereco
    {
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}
