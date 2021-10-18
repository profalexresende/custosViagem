using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem
{
    class Custos
    {
        public double totalPercurso { get; set; }

        public Custos()
        {
            this.totalPercurso = 0;
        }

        public Custos(double total)
        {
            this.totalPercurso = total;
        }

        public void calcularViagem(Percurso p)
        {
            this.totalPercurso = p.valorCombustivel + p.valorPedagio;
        }
    }
}
