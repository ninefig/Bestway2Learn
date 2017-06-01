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
    public partial class TelaResultados : Form
    {
        public TelaResultados()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            TelaAviso_Estudar abreAvisoEstudar = new TelaAviso_Estudar();
            abreAvisoEstudar.ShowDialog();
        }
    }
}
