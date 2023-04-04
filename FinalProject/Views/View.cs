using DatabaseFinalProject;
using FinalProject.Controllers;
using FinalProject.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//menampilkan data-data yang didapat dari repository

namespace FinalProject.Views
{
    internal class View : Repository
    {
        static string ConnectionString = "Data Source=DESKTOP-N6TO1LN;Initial Catalog=db_final_project;Integrated Security=True;Connect Timeout=30";

        static SqlConnection connection;
        public static void ListKaryawan()
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            //Membuat instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM karyawan";

            //Membuka koneksi
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("LIST KARYAWAN");
                    Console.WriteLine("====================");
                    Console.WriteLine("ID KARYAWAN\t\t: " + reader[0]);
                    Console.WriteLine("NAMA KARYAWAN\t\t: " + reader[1] + " " + reader[2]);
                    Console.WriteLine("PENDIDIKAN TERAKHIR\t: " + reader[3]);
                    Console.WriteLine("NO HANDPHONE\t\t: " + reader[4]);
                    Console.WriteLine("ALAMAT\t\t\t: " + reader[5]);
                    Console.WriteLine("====================");
                }
            }
            else
            {
                Console.WriteLine("DATA TIDAK DITEMUKAN");
                Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                Console.ReadKey();
                Program.DaftarMenu();
            }
            reader.Close();
            connection.Close();
            Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
            Console.ReadKey();
            Program.DaftarMenu();
        }
        public static void ListCustomer()
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            //Membuat instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM customer";

            //Membuka koneksi
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("LIST CUSTOMER");
                    Console.WriteLine("====================");
                    Console.WriteLine("ID CUSTOMER\t: " + reader[0]);
                    Console.WriteLine("NAMA CUSTOMER\t: " + reader[1]);
                    Console.WriteLine("ALAMAT\t\t: " + reader[2]);
                    Console.WriteLine("====================");
                }
            }
            else
            {
                Console.WriteLine("DATA TIDAK DITEMUKAN");
                Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                Console.ReadKey();
                Program.DaftarMenu();
            }
            reader.Close();
            connection.Close();
            Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
            Console.ReadKey();
            Program.DaftarMenu();
        }
        public static void ListBarang()
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            //Membuat instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM barang";

            //Membuka koneksi
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("LIST BARANG");
                    Console.WriteLine("====================");
                    Console.WriteLine("ID BARANG\t: " + reader[0]);
                    Console.WriteLine("NAMA BARANG\t: " + reader[1]);
                    Console.WriteLine("STOK\t\t: " + reader[3] + " " + reader[2]);
                    Console.WriteLine("HARGA BELI\t: Rp." + reader[4] + " /" + reader[2]);
                    Console.WriteLine("HARGA JUAL\t: Rp." + reader[5] + " /" + reader[2]);
                    Console.WriteLine("====================");

                }
            }
            else
            {
                Console.WriteLine("DATA TIDAK DITEMUKAN");
                Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                Console.ReadKey();
                Program.DaftarMenu();
            }
            reader.Close();
            connection.Close();
            Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
            Console.ReadKey();
            Program.DaftarMenu();
        }
    }
}
