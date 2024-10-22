using System;
using System.Collections.Generic;
using System.Text;
using Interface.Domain.Entities;
using Interface.Domain.Enum;
using Interface.Service;

namespace Interface.Controller
{
    class RoupaController
    {
        private readonly RoupaService _roupaService;
        public RoupaController()
        {
            _roupaService = new RoupaService();
        }
        public void CalcularPreco(string nome, TipoRoupa tipo, TamanhoRoupa tamanho)
        {
            if (Valid(nome, tipo, tamanho))
            {
                Roupa roupa = new Roupa()
                {
                    Nome = nome,
                    TipoRoupa = tipo,
                    TamanhoRoupa = tamanho
                };
                _roupaService.CalcularPreco(roupa);
            }
        }
        public bool Valid(string nome, TipoRoupa tipo, TamanhoRoupa tamanho)
        {
            if (nome != null && tipo != TipoRoupa.NA && tamanho != TamanhoRoupa.NA)
            {
                return true;
            }
            return false;
        }
    }
}
