using DatabaseFinalProject;
using FinalProject.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//berisi method-method yang memuat perintah untuk melakukan query command ataupun transaction

namespace FinalProject.Repositories
{
    internal class Repository
    {
        static string ConnectionString = "Data Source=DESKTOP-N6TO1LN;Initial Catalog=db_final_project;Integrated Security=True;Connect Timeout=30";

        static SqlConnection connection;
        
        public static void TambahKaryawan(int id, string namaDepan, string namaBelakang, string pendidikanTerakhir, string noHP, string alamat)
        {
            //Pembuatan koneksi
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO karyawan (id_karyawan, nama_depan_karyawan, nama_belakang_karyawan, pendidikan_terakhir, no_hp_karyawan, alamat_karyawan) VALUES (@id, @namaDepan, @namaBelakang, @pendidikanTerakhir, @noHP, @alamat)";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNamaDepan = new SqlParameter();
                pNamaDepan.ParameterName = "@namaDepan";
                pNamaDepan.Value = namaDepan;
                pNamaDepan.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNamaBelakang = new SqlParameter();
                pNamaBelakang.ParameterName = "@namaBelakang";
                pNamaBelakang.Value = namaBelakang;
                pNamaBelakang.SqlDbType = SqlDbType.VarChar;

                SqlParameter pPendidikanTerakhir = new SqlParameter();
                pPendidikanTerakhir.ParameterName = "@pendidikanTerakhir";
                pPendidikanTerakhir.Value = pendidikanTerakhir;
                pPendidikanTerakhir.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNoHP = new SqlParameter();
                pNoHP.ParameterName = "@noHP";
                pNoHP.Value = noHP;
                pNoHP.SqlDbType = SqlDbType.VarChar;

                SqlParameter pAlamat = new SqlParameter();
                pAlamat.ParameterName = "@alamat";
                pAlamat.Value = alamat;
                pAlamat.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);
                command.Parameters.Add(pNamaDepan);
                command.Parameters.Add(pNamaBelakang);
                command.Parameters.Add(pPendidikanTerakhir);
                command.Parameters.Add(pNoHP);
                command.Parameters.Add(pAlamat);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DITAMBAHKAN");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DITAMBAHKAN");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        public static void UpdateKaryawan(int id, string namaDepan, string namaBelakang, string pendidikanTerakhir, string noHP, string alamat)
        {
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE karyawan SET nama_depan_karyawan = @namaDepan, nama_belakang_karyawan = @namaBelakang, pendidikan_terakhir = @pendidikanTerakhir, no_hp_karyawan = @noHP, alamat_karyawan = @alamat WHERE id_karyawan = @id";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNamaDepan = new SqlParameter();
                pNamaDepan.ParameterName = "@namaDepan";
                pNamaDepan.Value = namaDepan;
                pNamaDepan.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNamaBelakang = new SqlParameter();
                pNamaBelakang.ParameterName = "@namaBelakang";
                pNamaBelakang.Value = namaBelakang;
                pNamaBelakang.SqlDbType = SqlDbType.VarChar;

                SqlParameter pPendidikanTerakhir = new SqlParameter();
                pPendidikanTerakhir.ParameterName = "@pendidikanTerakhir";
                pPendidikanTerakhir.Value = pendidikanTerakhir;
                pPendidikanTerakhir.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNoHP = new SqlParameter();
                pNoHP.ParameterName = "@noHP";
                pNoHP.Value = noHP;
                pNoHP.SqlDbType = SqlDbType.VarChar;

                SqlParameter pAlamat = new SqlParameter();
                pAlamat.ParameterName = "@alamat";
                pAlamat.Value = alamat;
                pAlamat.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);
                command.Parameters.Add(pNamaDepan);
                command.Parameters.Add(pNamaBelakang);
                command.Parameters.Add(pPendidikanTerakhir);
                command.Parameters.Add(pNoHP);
                command.Parameters.Add(pAlamat);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DIUPDATE");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DIUPDATE");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        public static void HapusKaryawan(int id)
        {
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM karyawan WHERE id_karyawan = @id";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DIHAPUS");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DIHAPUS");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
       
        public static void TambahCustomer(int id, string nama, string alamat)
        {
            //Pembuatan koneksi
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO customer (id_customer, nama_customer, alamat_customer) VALUES (@id, @nama, @alamat)";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNama = new SqlParameter();
                pNama.ParameterName = "@nama";
                pNama.Value = nama;
                pNama.SqlDbType = SqlDbType.VarChar;

                SqlParameter pAlamat = new SqlParameter();
                pAlamat.ParameterName = "@alamat";
                pAlamat.Value = alamat;
                pAlamat.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);
                command.Parameters.Add(pNama);
                command.Parameters.Add(pAlamat);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DITAMBAHKAN");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DITAMBAHKAN");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        public static void UpdateCustomer(int id, string nama, string alamat)
        {
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE customer SET nama_customer = @nama, alamat_customer = @alamat WHERE id_customer = @id";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNama = new SqlParameter();
                pNama.ParameterName = "@nama";
                pNama.Value = nama;
                pNama.SqlDbType = SqlDbType.VarChar;

                SqlParameter pAlamat = new SqlParameter();
                pAlamat.ParameterName = "@alamat";
                pAlamat.Value = alamat;
                pAlamat.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);
                command.Parameters.Add(pNama);
                command.Parameters.Add(pAlamat);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DIUPDATE");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DIUPDATE");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        public static void HapusCustomer(int id)
        {
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM customer WHERE id_customer = @id";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DIHAPUS");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DIHAPUS");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        
        public static void TambahBarang(int id, string nama, string satuan, int stok, int hargaBeli, int hargaJual)
        {
            //Pembuatan koneksi
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO barang (id_barang, nama_barang, satuan_barang, stok_barang, harga_beli_barang, harga_jual_barang) VALUES (@id, @nama, @satuan, @stok, @hargaBeli, @hargaJual)";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNama = new SqlParameter();
                pNama.ParameterName = "@nama";
                pNama.Value = nama;
                pNama.SqlDbType = SqlDbType.VarChar;

                SqlParameter pSatuan = new SqlParameter();
                pSatuan.ParameterName = "@satuan";
                pSatuan.Value = satuan;
                pSatuan.SqlDbType = SqlDbType.VarChar;

                SqlParameter pStok = new SqlParameter();
                pStok.ParameterName = "@stok";
                pStok.Value = stok;
                pStok.SqlDbType = SqlDbType.VarChar;

                SqlParameter pHargaBeli = new SqlParameter();
                pHargaBeli.ParameterName = "@hargaBeli";
                pHargaBeli.Value = hargaBeli;
                pHargaBeli.SqlDbType = SqlDbType.VarChar;

                SqlParameter pHargaJual = new SqlParameter();
                pHargaJual.ParameterName = "@hargaJual";
                pHargaJual.Value = hargaJual;
                pHargaJual.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);
                command.Parameters.Add(pNama);
                command.Parameters.Add(pSatuan);
                command.Parameters.Add(pStok);
                command.Parameters.Add(pHargaBeli);
                command.Parameters.Add(pHargaJual);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DITAMBAHKAN");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DITAMBAHKAN");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        public static void UpdateBarang(int id, string nama, string satuan, int stok, int hargaBeli, int hargaJual)
        {
            connection = new SqlConnection(ConnectionString);

            //Membuka koneksi
            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                //Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE barang SET nama_barang = @nama, satuan_barang = @satuan, stok_barang = @stok, harga_beli_barang = @hargaBeli, harga_jual_barang = @hargaJual WHERE id_barang = @id";
                command.Transaction = transaction;

                //Membuat parameter
                SqlParameter pID = new SqlParameter();
                pID.ParameterName = "@id";
                pID.Value = id;
                pID.SqlDbType = SqlDbType.VarChar;

                SqlParameter pNama = new SqlParameter();
                pNama.ParameterName = "@nama";
                pNama.Value = nama;
                pNama.SqlDbType = SqlDbType.VarChar;

                SqlParameter pSatuan = new SqlParameter();
                pSatuan.ParameterName = "@satuan";
                pSatuan.Value = satuan;
                pSatuan.SqlDbType = SqlDbType.VarChar;

                SqlParameter pStok = new SqlParameter();
                pStok.ParameterName = "@stok";
                pStok.Value = stok;
                pStok.SqlDbType = SqlDbType.VarChar;

                SqlParameter pHargaBeli = new SqlParameter();
                pHargaBeli.ParameterName = "@hargaBeli";
                pHargaBeli.Value = hargaBeli;
                pHargaBeli.SqlDbType = SqlDbType.VarChar;

                SqlParameter pHargaJual = new SqlParameter();
                pHargaJual.ParameterName = "@hargaJual";
                pHargaJual.Value = hargaJual;
                pHargaJual.SqlDbType = SqlDbType.VarChar;

                //Menambahkan parameter ke command
                command.Parameters.Add(pID);
                command.Parameters.Add(pNama);
                command.Parameters.Add(pSatuan);
                command.Parameters.Add(pStok);
                command.Parameters.Add(pHargaBeli);
                command.Parameters.Add(pHargaJual);

                //Menjalankan command
                int result = command.ExecuteNonQuery();
                transaction.Commit();

                if (result > 0)
                {
                    Console.WriteLine("DATA BERHASIL DIUPDATE");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }
                else
                {
                    Console.WriteLine("DATA GAGAL DIUPDATE");
                    Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                    Console.ReadKey();
                    Program.DaftarMenu();
                }

                //Menutup koneksi
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
        }
        public static void HapusBarang(int id)
    {
        connection = new SqlConnection(ConnectionString);

        //Membuka koneksi
        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            //Membuat instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM barang WHERE id_barang = @id";
            command.Transaction = transaction;

            //Membuat parameter
            SqlParameter pID = new SqlParameter();
            pID.ParameterName = "@id";
            pID.Value = id;
            pID.SqlDbType = SqlDbType.VarChar;

            //Menambahkan parameter ke command
            command.Parameters.Add(pID);

            //Menjalankan command
            int result = command.ExecuteNonQuery();
            transaction.Commit();

            if (result > 0)
            {
                Console.WriteLine("DATA BERHASIL DIHAPUS");
                Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                Console.ReadKey();
                Program.DaftarMenu();
            }
            else
            {
                Console.WriteLine("DATA GAGAL DIHAPUS");
                Console.WriteLine("KEMBALI KE DAFTAR MENU (TEKAN ENTER)");
                Console.ReadKey();
                Program.DaftarMenu();
            }

            //Menutup koneksi
            connection.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
    }
    }
}
