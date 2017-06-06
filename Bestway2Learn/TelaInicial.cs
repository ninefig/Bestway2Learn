using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestway2Learn
{
    public partial class TelaInicial : Form
    {
        private Conexao conn;
        public static SqlConnection ConnectOpen;
        public static String Materia;
        public static String txtMateria;
        public TelaInicial()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnTecnologia_Click(object sender, EventArgs e)
        {
            Hide();
            Materia = "Tecnologia"; 
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();
        }

        private void btnCiencias_Click(object sender, EventArgs e)
        {
            Hide();
            Materia = "Ciencias";
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            Hide();
            Materia = "Portugues";
            TelaResultados abreResultados = new TelaResultados();
            abreResultados.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtAssunto.Text != "")
            {
                string strCommand = "Select * from livros where materia = '" + txtAssunto.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Hide();
                    txtMateria = txtAssunto.Text;
                    TelaResultados abreResultados = new TelaResultados();
                    abreResultados.ShowDialog();
                }                

                string strCommandd = "Select * from videos where materia = '" + txtAssunto.Text + "'";
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(strCommandd, ConnectOpen);
                    da2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    Hide();
                    txtMateria = txtAssunto.Text;
                    TelaResultados abreResultados = new TelaResultados();
                    abreResultados.ShowDialog();
                }
            }

            else
                MessageBox.Show("Insira um assunto e tente novamente.");
        }

            private void menuFontes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Link do vídeo: https://www.youtube.com/watch?v=CN_SCpGuJ_w \n \n Link do icon: https://www.iconfinder.com/data/icons/education-15/500/reader-512.png");
        }

        private void menuSobre_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bestway2Learn foi inspirado no vídeo: COMO SE TORNAR UM MESTRE NOS ESTUDOS | A TÉCNICA FEYNMAN disponível no youtube.com");
        }

        private void txtAssunto_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
