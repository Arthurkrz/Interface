using System;
using System.Collections.Generic;
using System.Text;
using Interface.Domain.Entities;
using Interface.Domain.Enum;
using Interface.Service;

namespace Interface.Controller
{
    class EletronicoController
    {
        private readonly EletronicoService _eletronicoService;
        public EletronicoController()
        {
            _eletronicoService = new EletronicoService();
        }
        public void CalcularPreco(string nome, double voltagem, TipoEletronico tipo)
        {
            if (Valid(nome, voltagem, tipo))
            {
                Eletronico eletronico = new Eletronico()
                {
                    Nome = nome,
                    Voltagem = voltagem,
                    TipoEletronico = tipo
                };
                _eletronicoService.CalcularPreco(eletronico);
            }
        }
        public bool Valid(string nome, double voltagem, TipoEletronico tipo)
        {
            if (nome != null && voltagem > 0.0 && tipo != TipoEletronico.NA)
            {
                return true;
            }
            return false;
        }
    }
}
