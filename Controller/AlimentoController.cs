using System;
using System.Collections.Generic;
using System.Text;
using Interface.Domain.Entities;
using Interface.Service;
using Interface.Domain.Enum;

namespace Interface.Controller
{
    public class AlimentoController
    {
        private readonly ProdutoService _alimentoService;
        public AlimentoController()
        {
            _alimentoService = new ProdutoService();
        }
        public void CalcularPreco(string nome, TipoAlimento tipo, DateTime exp, double preco)
        {
            if (Valid(nome, tipo, exp, preco))
            {
                Alimento alimento = new Alimento()
                {
                    Nome = nome,
                    Tipo = tipo,
                    Exp = exp,
                    Preco = preco
                };
                _alimentoService.CalcularPreco(alimento);
            }
        }
        public bool Valid(string nome, TipoAlimento tipo, DateTime exp, double preco)
        {
            if (nome != null && tipo != TipoAlimento.NA && exp != null && preco > 0.0)
            {
                return true;
            }
            return false;
        }
    }
}
