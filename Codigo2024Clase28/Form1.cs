

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




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=DESKTOP-BCQFL9J\\SQLEXPRESS;" +
                  "initial catalog = NeptunoDB;  User Id=userPrueba; Pwd=123456;  " +
                  "TrustServerCertificate=true"))
                {
                    SqlCommand command = new SqlCommand("Select * from categorias", conexion);

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    dgvCategorias.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=DESKTOP-BCQFL9J\\SQLEXPRESS;" +
                  "initial catalog = NeptunoDB;  User Id=userPrueba; Pwd=123456;  " +
                  "TrustServerCertificate=true"))
                {
                    conexion.Open();

                    int id = Convert.ToInt32(txtID.Text);
                    string nombre = txtName.Text;

                    SqlCommand command = new SqlCommand("INSERT INTO Categorias (idcategoria,nombrecategoria) " +
                        "VALUES ( "+ id+",'"+nombre+"')", conexion);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Registro exitoso");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}