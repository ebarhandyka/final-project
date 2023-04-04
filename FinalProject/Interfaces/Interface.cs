using DatabaseFinalProject;
using FinalProject.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mengatur segala aktivitas yang dilakukan oleh user

namespace FinalProject.Interfaces
{
    internal class Interface : Controller
    {
        static string ConnectionString = "Data Source=DESKTOP-N6TO1LN;Initial Catalog=db_final_project;Integrated Security=True;Connect Timeout=30";

        static SqlConnection connection;
        public static void DaftarMenu()
        {

            connection = new SqlConnection(ConnectionString);
            connection.Open();
            Console.Clear();
            Console.WriteLine("     DATABASE JHONET FOTOCOPY   ");
            Console.WriteLine(" ********* DAFTAR MENU *********");
            Console.WriteLine("\n");
            Console.WriteLine("====== MENU EDIT KARYAWAN ======");
            Console.WriteLine("1.  LIST KARYAWAN");
            Console.WriteLine("2.  TAMBAH KARYAWAN");
            Console.WriteLine("3.  UPDATE KARYAWAN");
            Console.WriteLine("4.  HAPUS KARYAWAN");
            Console.WriteLine("\n");
            Console.WriteLine("====== MENU EDIT CUSTOMER ======");
            Console.WriteLine("5.  LIST CUSTOMER");
            Console.WriteLine("6.  TAMBAH CUSTOMER");
            Console.WriteLine("7.  UPDATE CUSTOMER");
            Console.WriteLine("8.  HAPUS CUSTOMER");
            Console.WriteLine("\n");
            Console.WriteLine("======= MENU EDIT BARANG =======");
            Console.WriteLine("9.  LIST BARANG");
            Console.WriteLine("10. TAMBAH BARANG");
            Console.WriteLine("11. UPDATE BARANG");
            Console.WriteLine("12. HAPUS BARANG");
            Console.Write("\nINPUT\t: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    ListKaryawan();
                    break;
                case 2:
                    MenuMenambahkanKaryawan();
                    break;
                case 3:
                    MenuUpdateKaryawan();
                    break;
                case 4:
                    MenuMenghapusKaryawan();
                    break;
                case 5:
                    ListCustomer();
                    break;
                case 6:
                    MenuMenambahkanCustomer();
                    break;
                case 7:
                    MenuUpdateCustomer();
                    break;
                case 8:
                    MenuMenghapusCustomer();
                    break;
                case 9:
                    ListBarang();
                    break;
                case 10:
                    MenuMenambahkanBarang();
                    break;
                case 11:
                    MenuUpdateBarang();
                    break;
                case 12:
                    MenuMenghapusBarang();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("INPUT SALAH");
                    Console.WriteLine("SILAHKAN PILIH OPSI YANG TERSEDIA PADA MENU");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                    break;
            }
        }
    }
}
