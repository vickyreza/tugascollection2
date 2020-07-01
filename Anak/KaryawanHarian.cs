using System;
using System.Collections.Generic;
using tugaspolydancol.Induk;
using System.Text;


namespace tugaspolydancol.Anak
{
    public class KaryawanHarian : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public int JumlahJamKerja { get; set; }
        public int UpahPerJam { get; set; }
        public override int Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}
