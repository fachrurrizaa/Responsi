using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        Penjualan penjualan = new Penjualan();
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        System.Environment.Exit(0);
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Penjualan penjualan = new Penjualan();

            Console.Write("Nota: ");
            penjualan.Nota = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Customer : ");
            penjualan.Nama = Console.ReadLine();
            Console.Write("Jenis[T/K] : ");
            penjualan.Jenis = Console.ReadLine();

            if(penjualan.Jenis == "t" || penjualan.Jenis == "T"){
                penjualan.Jenis = "Tunai";
            }else if(penjualan.Jenis == "k" || penjualan.Jenis == "K"){
                penjualan.Jenis = "Kredit";
            }
            
            Console.Write("Total : ");
            penjualan.Total = Convert.ToDouble(Console.ReadLine());
          
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("Data Penjualan");

            int no = 1;

            foreach(Penjualan penjualan in daftarPenjualan){
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Jenis, penjualan.Total);
                Console.WriteLine();
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
