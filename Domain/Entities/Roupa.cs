using System;
using System.Collections.Generic;
using System.Text;
using Interface.Domain.Enum;
using Interface.Domain.Contracts;

namespace Interface.Domain.Entities
{
    public class Roupa : ICalculaDesconto, ICalculaPreco
    {
        public string Nome { get; set; }
        public TipoRoupa Tipo { get; set; }
        public TamanhoRoupa Tamanho { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double CalculaDesconto()
        {
            if (Quantidade <= 9)
            {
                return Preco;
            }
            else if (Quantidade > 9 && Quantidade <= 19)
            {
                return Preco * 0.1;
            }
            else if (Quantidade > 19 && Quantidade <= 29)
            {
                return Preco * 0.2;
            }
            else if (Quantidade > 30)
            {
                return Preco * 0.3;
            }
            return 0.0;
        }
        public double CalculaPreco() => (Preco - CalculaDesconto()) * Quantidade;
    }
}
