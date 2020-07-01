using System;
using System.Collections.Generic;
using System.Text;
using tugaspolydancol.Induk;

namespace tugaspolydancol.Anak
{
    public class Sales : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }
        public override int Gaji()
        {
            return JumlahPenjualan*Komisi;
        }

    }
}
