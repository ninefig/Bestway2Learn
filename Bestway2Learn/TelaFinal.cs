using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestway2Learn
{
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TelaInicial abreTelaInicial = new TelaInicial();
            abreTelaInicial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até a próxima! ;)");
            Close();
        }
    }
}
