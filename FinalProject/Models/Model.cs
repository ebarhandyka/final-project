using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Berisi entitas-entitas pada database

namespace FinalProject.Models
{
    internal class Model
    {
        static string ConnectionString = "Data Source=DESKTOP-N6TO1LN;Initial Catalog=db_final_project;Integrated Security=True;Connect Timeout=30";

        static SqlConnection connection;
        public static void SqlQuery()
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            //Membuat instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText =
                "CREATE TABLE ";

            //Membuka koneksi
            connection.Open();
        }
    }
}
