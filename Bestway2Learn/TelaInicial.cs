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

        private void menuFontes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Link do vídeo: https://www.youtube.com/watch?v=CN_SCpGuJ_w \n \n Link do icon: https://www.iconfinder.com/data/icons/education-15/500/reader-512.png");
        }

        private void menuSobre_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bestway2Learn foi inspirado no vídeo: COMO SE TORNAR UM MESTRE NOS ESTUDOS | A TÉCNICA FEYNMAN disponível no youtube.com");
        }
    }
}
