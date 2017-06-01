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
    public partial class TelaAviso1 : Form
    {
        public TelaAviso1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                             Ok, não tem problema! \n Vamos voltar aos assuntos e livros que poderão lhe ajudar a chegar na onde você deseja, fique tranquilo/a.");
            Hide();
            TelaResultados abreTelaResultados = new TelaResultados();
            abreTelaResultados.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TelaPraticar abreTelaPraticar = new TelaPraticar();
            abreTelaPraticar.ShowDialog();
        }
    }
}
