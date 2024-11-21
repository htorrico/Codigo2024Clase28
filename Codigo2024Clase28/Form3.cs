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
    public partial class Form3 : Form
    {

        DataTable datatable = new DataTable();
      
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    SqlCommand command = new SqlCommand("USP_BuscarClientesPorFiltros", conexion);
                    command.CommandType = CommandType.StoredProcedure;


                    SqlParameter sqlParameter = new SqlParameter("@NombreContacto", SqlDbType.VarChar, 50);
                    sqlParameter.Value = txtContacto.Text;


                    SqlParameter sqlParameter2 = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 50);
                    sqlParameter2.Value = txtCargo.Text;

                    command.Parameters.Add(sqlParameter);
                    command.Parameters.Add(sqlParameter2);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(datatable);

                }


                dgvClientes.DataSource = datatable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //ADO .NET DE FORMA DESCONECTADA!!!!
            dgvClientesCargados.DataSource = datatable;

        }

        private void btnBuscarNew_Click(object sender, EventArgs e)
        {

            dgvClientes.DataSource = DatosCliente.ListarClientes(txtContacto.Text, txtCargo.Text);

        }
    }
}
