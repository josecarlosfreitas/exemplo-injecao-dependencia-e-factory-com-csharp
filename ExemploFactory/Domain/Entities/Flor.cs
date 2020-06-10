using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFactory.Domain.Entities
{
    public class Flor : IFlor
    {
        public string Nome { get; set; }
        public TipoFlorEnum tipoFlor { get; set; }
    }
}
