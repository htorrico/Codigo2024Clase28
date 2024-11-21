using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Codigo2024Clase28
{
    public partial class Form2 : Form
    {    
        public Form2()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    string commandstring = " SELECT" +
                        " categoriaProducto," +
                        "'Cantidad'=COUNT(IdProducto)," +
                        "'SumaPrecioUnidad'=SUM(PrecioUnidad)," +
                        "'PromedioUnidadesEnExistencia'=AVG(UnidadesEnExistencia)" +
                        "FROM PRODUCTOS" +
                        "GROUP BY categoriaProducto";


                    SqlCommand command = new SqlCommand(commandstring, conexion);

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    dgvProductos.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnListarProcedimiento_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
          
                    SqlCommand command = new SqlCommand("USP_ListarProductoAgrupado", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    dgvProductos.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
