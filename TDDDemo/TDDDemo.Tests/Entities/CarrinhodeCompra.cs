using System;
using System.Collections.Generic;
using System.Text;

namespace TDDDemo.Tests.Entities
{
    public class CarrinhodeCompra
    {
        public CarrinhodeCompra()
        {
            itens = new List<Produto>();
        }
        public IReadOnlyCollection<Produto> Itens { get => itens; }
        private List<Produto> itens { get; set; }

        public bool Add(Produto item)
        {
            //REGRAS
            itens.Add(item);
            return true;
        }
    }
}
