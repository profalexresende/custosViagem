using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Custos c = new Custos();
            Percurso p = new Percurso();

            p.KMPercorrida = Convert.ToDouble(txtKMPercorrida.Text);
            p.valorCombustivel= Convert.ToDouble(txtCombustivel.Text);
            p.valorPedagio= Convert.ToDouble(txtPedagio.Text);

            c.calcularViagem(p);
            MessageBox.Show("Total da Viagem: " + c.totalPercurso.ToString());
        }
    }
}
