using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.Write("Pilih Menu Aplikasi\n");
            Console.Write("\n1. Tambah Custumer \n2. Hapus Custumer \n3. Tampilkan Customer \n4. Keluar \n");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Tambah Data Costumer");

            Console.Write("Kode Customer : ");
            string Kode = Console.ReadLine();
            Console.Write("Nama Customer : ");
            string Nama = Console.ReadLine();
            Console.Write("Total Piutang : ");
            string Total = Console.ReadLine();

            Customer cus = new Customer();
            cus.Kode = Kode;
            cus.Nama = Nama;
            cus.Total = Total;

            daftarCustomer.Add(cus);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Hapus Data Customer");

            Console.Write("Kode Customer : ");
            string Kode = Console.ReadLine();

            bool found = false;
            int i = 0, indexHapus = -1;
            foreach (Customer cus in daftarCustomer)
            {
                if (cus.Kode == Kode)
                {
                    found = true;
                    indexHapus = i;
                }
                i++;
            }

            if (found)
            {
                daftarCustomer.RemoveAt(indexHapus);
                Console.WriteLine("Daftar Customer Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("Kode Customer Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Customer\n");

            //Console.WriteLine("Kode\t\tNama\t\tTotal Piutang");

            int i = 1;
            foreach (Customer cus in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}", i, cus.Kode, cus.Nama, cus.Total);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
