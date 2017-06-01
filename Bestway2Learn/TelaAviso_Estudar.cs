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
    public partial class TelaAviso_Estudar : Form
    {
        public TelaAviso_Estudar()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Hide();
            TelaAviso1 abreTelaAviso1 = new TelaAviso1();
            abreTelaAviso1.ShowDialog();
        }
    }
}
