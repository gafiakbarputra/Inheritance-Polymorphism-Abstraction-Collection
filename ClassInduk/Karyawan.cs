using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_8.ClassInduk
{
    public abstract class Karyawan
    {
        public string Nik, Nama;
        public double GajiBulanan,UpahPerJam,JumlahJamKerja,JumlahPenjualan,Komisi;
        public abstract double Gaji();
    }
}
