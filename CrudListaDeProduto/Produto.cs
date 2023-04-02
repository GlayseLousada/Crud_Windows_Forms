using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudListaDeProduto
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public decimal Preço { get; set; }

        public DateTime DataDeVencimento { get; set; }
    }
}