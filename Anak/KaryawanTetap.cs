using System;
using tugaspolydancol.Induk;
using System.Collections.Generic;
using System.Text;

namespace tugaspolydancol.Anak
{
    public class KaryawanTetap : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public override int Gaji()
        {
            return GajiBulanan;
        }
    }
}
