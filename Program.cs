using System;
using System.Collections.Generic;
using tugaspolydancol.Induk;
using tugaspolydancol.Anak;


namespace tugaspolydancol
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<KaryawanTetap> karyawanTetap = new List<KaryawanTetap>();
            List<KaryawanHarian> karyawanHarian = new List<KaryawanHarian>();
            List<Sales> sales = new List<Sales>();


        menu:
            Console.WriteLine("=========================================");
            Console.WriteLine("|\tPilih Menu Aplikasi\t\t|");
            Console.WriteLine("=========================================");
            Console.WriteLine("|\t1. Tambah Data Karyawan\t\t|");
            Console.WriteLine("|\t2. Hapus Data Karyawan\t\t|");
            Console.WriteLine("|\t3. Tampilkan Data Karyawan\t|");
            Console.WriteLine("|\t4. Keluar\t\t\t|");
            Console.WriteLine("=========================================");
            Console.Write("Masukkan pilihan [1..4] : ");
            int pilihan;
            int pilihan2;

            pilihan = int.Parse(Console.ReadLine());
            if (pilihan == 1)
            {
                sini:
                Console.WriteLine("=========================================");
                Console.WriteLine("\t1. Input Data Karyawan Tetap\t|");
                Console.WriteLine("\t2. Input Data Karyawan Harian\t|");
                Console.WriteLine("\t3. Input Data Sales\t\t|");
                Console.WriteLine("=========================================");
                Console.Write("Masukkan pilihan [1..3] : ");
                pilihan2 = int.Parse(Console.ReadLine());

                if (pilihan2 == 1)
                {
                    string nik, nama;
                    int gajibulanan;
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Gaji Bulanan : ");
                    gajibulanan = int.Parse(Console.ReadLine());


                    karyawanTetap.Add(new KaryawanTetap() { Nik = nik, Nama = nama, GajiBulanan = gajibulanan });

                }
                else if (pilihan2 == 2)
                {
                    string nik, nama;
                    int jumlahjamkerja;
                    int upahperjam;
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Jam Kerja : ");
                    jumlahjamkerja = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Upah Per jam : ");
                    upahperjam = int.Parse(Console.ReadLine());
                    karyawanHarian.Add(new KaryawanHarian() { Nik = nik, Nama = nama, UpahPerJam = upahperjam, JumlahJamKerja = jumlahjamkerja });


                }
                else if (pilihan2 == 3)
                {
                    string nama, nik;
                    int jumlahpenjualan, komisi;
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Penjualan : ");
                    jumlahpenjualan = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Komisi per penjualan : ");
                    komisi = int.Parse(Console.ReadLine());

                    sales.Add(new Sales() { Nik = nik, Nama = nama, JumlahPenjualan = jumlahpenjualan, Komisi = komisi });

                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Hapus Data Karyawan");
                string hapus;
                Console.WriteLine("Masukan NIK : ");
                hapus = Console.ReadLine();
                int a = 0;
                foreach (Karyawan karyawan in karyawanTetap)
                {
                    if (hapus == karyawan.Nik)
                    {
                        karyawanTetap.RemoveAt(a);
                        break;
                    }
                    a++;
                }
                a = 0;
                foreach (Karyawan karyawan in karyawanHarian)
                {
                    if (hapus == karyawan.Nik)
                    {
                        karyawanHarian.RemoveAt(a);
                        break;
                    }
                    a++;
                }
                a = 0;
                foreach (Karyawan karyawan in sales)
                {
                    if (hapus == karyawan.Nik)
                    {
                        sales.RemoveAt(a);
                        break;
                    }
                    a++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Data Karyawan" +
                    "");
                int no = 1;
                foreach (Karyawan karyawan in karyawanTetap)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Tetap",
                    no, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    no++;
                }
                foreach (Karyawan karyawan in karyawanHarian)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Harian",
                    no, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    no++;
                }
                foreach (Karyawan karyawan in sales)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Sales",
                    no, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    no++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }

            else
            {
                Console.WriteLine("Selesai");
            }

           


            Console.ReadKey(true);
            Console.Clear();

        }



    }
}

