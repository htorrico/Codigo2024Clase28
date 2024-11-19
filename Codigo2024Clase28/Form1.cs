

using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Codigo2024Clase28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarCategorias_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("data source=DESKTOP-BCQFL9J\\SQLEXPRESS;" +
                  "initial catalog = NeptunoDB; Integrated Security=true; " +
                  "TrustServerCertificate=true");
            try
            {

                conexion.Open();

                SqlCommand command = new SqlCommand("Select * from categorias", conexion);

                DataTable dataTable = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);

                conexion.Close();

                dgvCategorias.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                conexion.Close();
                throw ex;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("data source=DESKTOP-BCQFL9J\\SQLEXPRESS;" +
                 "initial catalog = NeptunoDB; User Id=userPrueba; Pwd=123456;  " +
                 "TrustServerCertificate=true");
            try
            {

                conexion.Open();

                SqlCommand command = new SqlCommand("Select * from categorias", conexion);

                DataTable dataTable = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);

                conexion.Close();

                dgvCategorias.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                conexion.Close();
                throw ex;
            }
        }
    }
}
