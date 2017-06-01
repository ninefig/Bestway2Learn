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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnTecnologia_Click(object sender, EventArgs e)
        {
            Hide();
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();            
        }

        private void btnCiencias_Click(object sender, EventArgs e)
        {
            Hide();
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            Hide();
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Hide();
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();
        }
    }
}
