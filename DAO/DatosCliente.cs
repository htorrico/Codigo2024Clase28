using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DatosCliente
    {
       public static List<Cliente> ListarClientes(string nombre, string cargo)
        {
            SqlCommand command = null; ;
            SqlParameter sqlParameter = null;
            SqlParameter sqlParameter2 = null;
            List<Cliente> clientes = null;

            try
            {
                clientes = new List<Cliente>();

                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_BuscarClientesPorFiltros", conexion);
                    command.CommandType = CommandType.StoredProcedure;


                    sqlParameter = new SqlParameter("@NombreContacto", SqlDbType.VarChar, 50);
                    sqlParameter.Value = nombre;


                    sqlParameter2 = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 50);
                    sqlParameter2.Value = cargo;

                    command.Parameters.Add(sqlParameter);
                    command.Parameters.Add(sqlParameter2);


                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            IdCliente = reader["IdCliente"].ToString(),
                            NombreContacto = Convert.ToString(reader["NombreContacto"]),
                            CargoContacto = Convert.ToString(reader["CargoContacto"]),
                            Direccion = Convert.ToString(reader["Direccion"]),
                            Ciudad = (reader["Ciudad"]).ToString(),
                            //Operador Ternario
                            Region = reader["Region"] == null ? "" : reader["Region"].ToString()
                        }
                       );
                    }
                  
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
            finally
            {
                command = null;
                sqlParameter = null;
                sqlParameter2 = null;
                clientes = null;

            }

           

        }

    }
}
