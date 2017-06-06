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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            TelaInicial abreTelaInicial = new TelaInicial();
            abreTelaInicial.ShowDialog();
        }

        private void TelaResultados_Load(object sender, EventArgs e)
        {
                        switch (TelaInicial.Materia)
            {
                case "Tecnologia":
                    var conn = TelaInicial.ConnectOpen;
                    string sql = "Select * from livros where materia = 'tecnologia' ";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dtgridLivros.DataSource = dt;
                    }

                    string sql2 = "Select * from Videos where materia = 'tecnologia' ";
                    DataTable data = new DataTable();
                    SqlDataAdapter dataadapter = new SqlDataAdapter(sql2, conn);
                    dataadapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        dtgridVideos.DataSource = data;
                    }
                    break;

                case "Ciencias":
                    var conn1 = TelaInicial.ConnectOpen;
                    string sql1 = "Select * from livros where materia = 'ciencias' ";
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn1);
                    da1.Fill(dt1);

                    if (dt1.Rows.Count > 0)
                    {
                        dtgridLivros.DataSource = dt1;
                    }

                    string sql3 = "Select * from Videos where materia = 'ciencias' ";
                    DataTable data3 = new DataTable();
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, conn1);
                    dataadapter3.Fill(data3);

                    if (data3.Rows.Count > 0)
                    {
                        dtgridVideos.DataSource = data3;
                    }
                    break;

                case "Portugues":
                    var conn10 = TelaInicial.ConnectOpen;
                    string sql10 = "Select * from livros where materia = 'portugues' ";
                    DataTable dt10 = new DataTable();
                    SqlDataAdapter da10 = new SqlDataAdapter(sql10, conn10);
                    da10.Fill(dt10);

                    if (dt10.Rows.Count > 0)
                    {
                        dtgridLivros.DataSource = dt10;
                    }

                    string sql11 = "Select * from Videos where materia = 'portugues' ";
                    DataTable data11 = new DataTable();
                    SqlDataAdapter dataadapter11 = new SqlDataAdapter(sql11, conn10);
                    dataadapter11.Fill(data11);

                    if (data11.Rows.Count > 0)
                    {
                        dtgridVideos.DataSource = data11;
                    }
                    break;

                default:                    
                    var conn6 = TelaInicial.ConnectOpen;
                    String OutroAssuntos = TelaInicial.txtMateria;
                    string sql6 = "Select * from livros where materia = '"+ OutroAssuntos + "'";
                    DataTable dt6 = new DataTable();
                    SqlDataAdapter da6 = new SqlDataAdapter(sql6, conn6);
                    da6.Fill(dt6);

                    if (dt6.Rows.Count > 0)
                    {
                        dtgridLivros.DataSource = dt6;
                    }
                    else
                        MessageBox.Show("Não foi possível encontrar livros sobre este assunto. Tente novamente.");

                    string sql7 = "Select * from Videos where materia = '" + OutroAssuntos + "'";
                    DataTable data7 = new DataTable();
                    SqlDataAdapter dataadapter7 = new SqlDataAdapter(sql7, conn6);
                    dataadapter7.Fill(data7);

                    if (data7.Rows.Count > 0)
                    {
                        dtgridVideos.DataSource = data7;
                    } else
                        MessageBox.Show("Não foi possível encontrar videos sobre este assunto. Tente novamente.");
                        break;
            }
        }         
    }
}
