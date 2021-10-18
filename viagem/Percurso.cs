using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viagem
{
    class Percurso
    {
        public double KMPercorrida { get; set; }
        public double valorCombustivel { get; set; }
        public double valorPedagio { get; set; }

        public Percurso()
        {
            this.KMPercorrida = 0;
            this.valorCombustivel = 0;
            this.valorPedagio = 0;
        }

        public Percurso(double km,double combustivel,double pedagio)
        {
            this.KMPercorrida = km;
            this.valorCombustivel = combustivel;
            this.valorPedagio = pedagio;
        }
        public void listarPercurso()
        {
            MessageBox.Show("KM Percorrida: " + this.KMPercorrida.ToString() +
                "\nValor do Combustível: " + this.valorCombustivel.ToString() +
                "\nValor do Pedágio: " + this.valorPedagio.ToString());
        }

    }
}
