using DatabaseFinalProject;
using FinalProject.Repositories;
using FinalProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Berisi method-method yang digunakan user untuk melakukan proses CRUD dengan input yang dinamis

namespace FinalProject.Controllers
{
    internal class Controller : View
    {
        public static void MenuMenambahkanKaryawan()
        {
            //Menampilkan input untuk menambahkan data pada tabel karyawan
            Console.Clear();
            int inputID;
            Console.Write("ID\t\t\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            string inputNamaDepan;
            Console.Write("NAMA DEPAN\t\t: ");
            inputNamaDepan = Console.ReadLine();

            string inputNamaBelakang;
            Console.Write("NAMA BELAKANG\t\t: ");
            inputNamaBelakang = Console.ReadLine();

            string inputPendidikanTerakhir;
            Console.Write("PENDIDIKAN TERAKHIR\t: ");
            inputPendidikanTerakhir = Console.ReadLine();

            string inputNoHP;
            Console.Write("NO HANDPHONE\t\t: ");
            inputNoHP = Console.ReadLine();

            string inputAlamat;
            Console.Write("ALAMAT\t\t\t: ");
            inputAlamat = Console.ReadLine();

            Program.TambahKaryawan(inputID, inputNamaDepan, inputNamaBelakang, inputPendidikanTerakhir, inputNoHP, inputAlamat);
        }
        public static void MenuUpdateKaryawan()
        {
            //Menampilkan input untuk update data pada tabel karyawan berdasarkan ID karyawan
            Console.Clear();
            int inputID;
            Console.Write("ID KARYAWAN YANG INGIN DIUPDATE\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            string inputNamaDepan;
            Console.Write("NAMA DEPAN\t\t: ");
            inputNamaDepan = Console.ReadLine();

            string inputNamaBelakang;
            Console.Write("NAMA BELAKANG\t\t: ");
            inputNamaBelakang = Console.ReadLine();

            string inputPendidikanTerakhir;
            Console.Write("PENDIDIKAN TERAKHIR\t: ");
            inputPendidikanTerakhir = Console.ReadLine();

            string inputNoHP;
            Console.Write("NO HANDPHONE\t\t: ");
            inputNoHP = Console.ReadLine();

            string inputAlamat;
            Console.Write("ALAMAT\t\t\t: ");
            inputAlamat = Console.ReadLine();

            Program.UpdateKaryawan(inputID, inputNamaDepan, inputNamaBelakang, inputPendidikanTerakhir, inputNoHP, inputAlamat);
        }


        public static void MenuMenghapusKaryawan()
        {
            //Menampilkan input untuk menghapus data pada tabel karyawan berdasarkan ID karyawan
            Console.Clear();
            int inputID;
            Console.Write("ID KARYAWAN YANG INGIN DIHAPUS\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            Program.HapusKaryawan(inputID);
        }


        public static void MenuMenambahkanCustomer()
        {
            //Menampilkan input untuk menambahkan data pada tabel customer
            Console.Clear();
            int inputID;
            Console.Write("ID\t\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            string inputNama;
            Console.Write("NAMA CUSTOMER\t: ");
            inputNama = Console.ReadLine();

            string inputAlamat;
            Console.Write("ALAMAT\t\t: ");
            inputAlamat = Console.ReadLine();

            Program.TambahCustomer(inputID, inputNama, inputAlamat);
        }


        public static void MenuUpdateCustomer()
        {
            //Menampilkan input untuk update data pada tabel customer berdasarkan ID customer
            Console.Clear();
            int inputID;
            Console.Write("ID CUSTOMER YANG INGIN DIUPDATE\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            string inputNama;
            Console.Write("NAMA\t\t: ");
            inputNama = Console.ReadLine();

            string inputAlamat;
            Console.Write("ALAMAT\t\t\t: ");
            inputAlamat = Console.ReadLine();

            Program.UpdateCustomer(inputID, inputNama, inputAlamat);
        }

        public static void MenuMenghapusCustomer()
        {
            //Menampilkan input untuk menghapus data pada tabel customer berdasarkan ID customer
            Console.Clear();
            int inputID;
            Console.Write("ID CUSTOMER YANG INGIN DIHAPUS\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            Program.HapusCustomer(inputID);
        }


        public static void MenuMenambahkanBarang()
        {
            //Menampilkan input untuk menambahkan data pada tabel barang
            Console.Clear();
            int inputID;
            Console.Write("ID\t\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            string inputNama;
            Console.Write("NAMA\t\t: ");
            inputNama = Console.ReadLine();

            string inputSatuan;
            Console.Write("SATUAN\t\t: ");
            inputSatuan = Console.ReadLine();

            int inputStok;
            Console.Write("STOK\t\t: ");
            inputStok = (Convert.ToInt32(Console.ReadLine()));

            int inputHargaBeli;
            Console.Write("HARGA BELI\t: ");
            inputHargaBeli = (Convert.ToInt32(Console.ReadLine()));

            int inputHargaJual;
            Console.Write("HARGA JUAL\t: ");
            inputHargaJual = (Convert.ToInt32(Console.ReadLine()));

            Program.TambahBarang(inputID, inputNama, inputSatuan, inputStok, inputHargaBeli, inputHargaJual);
        }

        public static void MenuUpdateBarang()
        {
            //Menampilkan input untuk update data pada tabel barang berdasarkan ID barang
            Console.Clear();
            int inputID;
            Console.Write("ID BARANG YANG INGIN DIUPDATE\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            string inputNama;
            Console.Write("NAMA\t\t: ");
            inputNama = Console.ReadLine();

            string inputSatuan;
            Console.Write("SATUAN\t\t: ");
            inputSatuan = Console.ReadLine();

            int inputStok;
            Console.Write("STOK\t: ");
            inputStok = (Convert.ToInt32(Console.ReadLine()));

            int inputHargaBeli;
            Console.Write("HARGA BELI\t: ");
            inputHargaBeli = (Convert.ToInt32(Console.ReadLine()));

            int inputHargaJual;
            Console.Write("HARGA JUAL\t: ");
            inputHargaJual = (Convert.ToInt32(Console.ReadLine()));

            Program.UpdateBarang(inputID, inputNama, inputSatuan, inputStok, inputHargaBeli, inputHargaJual);
        }

        public static void MenuMenghapusBarang()
        {
            //Menampilkan input untuk menghapus data pada tabel barang
            Console.Clear();
            int inputID;
            Console.Write("ID BARANG YANG INGIN DIHAPUS\t: ");
            inputID = (Convert.ToInt32(Console.ReadLine()));

            Program.HapusBarang(inputID);
        }
    }
}
