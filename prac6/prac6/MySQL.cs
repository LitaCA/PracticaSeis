using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace prac6
{
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}

		protected void abrirConexion(){
			string connectionString =
          		"Server=127.0.0.1;" +
	          	"Database=escuela;" +
	          	"User ID=root;" +
	          	"Password=daniela19;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
	       
		}

		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}

