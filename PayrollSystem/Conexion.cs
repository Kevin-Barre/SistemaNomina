using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms; 


namespace PayrollSystem
{
    public class Conexion 
    {
        public static SqlConnection conexion = null; 

        public static SqlConnection getCon()
        {
            if (conexion == null)
            {
                try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "KEVIN-ALCIDES";
                    builder.InitialCatalog = "Earnings";
                    builder.UserID = "sa";
                    builder.Password = "Kevin1199";
                    conexion = new SqlConnection(builder.ToString());
                    conexion.Open(); 


                } catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    System.Environment.Exit(1);
                }
            } 
            return conexion; 
        }
       
    }
}
