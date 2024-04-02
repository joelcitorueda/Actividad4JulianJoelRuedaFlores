using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL
{
	public class conexion
	{
		public static string CONECTAR
		{
			get { return @"Data Source=DESKTOP-EROEUF5; Initial Catalog=SISTEMAGESTION; Integrated Security=True; TrustServerCertificate=true;"; }
			//get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
		}
		public static DataSet EjecutarDataSet(string consulta)
		{
			string p = conexion.CONECTAR;
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			conectar.Open();
			SqlCommand cmd = new SqlCommand(consulta, conectar);
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			DataSet ds = new DataSet();
			da.Fill(ds, "TABLA");
			return ds;
		}

		public static void Ejecutar(string consulta)
		{
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			conectar.Open();
			SqlCommand cmd = new SqlCommand(consulta, conectar);
			cmd.CommandTimeout = 5000;
			cmd.ExecuteNonQuery();
		}

		public static int EjecutarEscalar(string consulta)
		{
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			conectar.Open();

			SqlCommand cmd = new SqlCommand(consulta, conectar);
			cmd.CommandTimeout = 5000;
			int dev = Convert.ToInt32(cmd.ExecuteScalar());
			return dev;
		}
		public static DataTable EjecutarDataTabla(string consulta, string tabla)
		{
			string p = conexion.CONECTAR;
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			SqlCommand cmd = new SqlCommand(consulta, conectar);
			cmd.CommandTimeout = 5000;
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable(tabla);
			da.Fill(dt);
			return dt;
		}
		private string connectionString; // Cadena de conexión a la base de datos

		// Constructor que recibe la cadena de conexión
		public conexion(string connectionString)
		{
			this.connectionString = connectionString;
		}
		public DataTable EjecutarDataTabla(string query, string nombreTabla, int idCliente)
		{
			DataTable dataTable = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					// Abrir la conexión
					connection.Open();

					// Crear un comando SQL con parámetros
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@IDCliente", idCliente);

					// Ejecutar el comando y llenar el DataTable con los resultados
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					adapter.Fill(dataTable);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al ejecutar la consulta SQL: " + ex.Message);
			}
			return dataTable;
		}
	}
}
