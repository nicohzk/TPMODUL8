using System;
using Tpmodul8_103022300127;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig x = new CovidConfig();
        x.ReadJSON();
        x.UbahSatuan();
        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {x.satuan_suhu}");
        double suhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
        int hari = Convert.ToInt32(Console.ReadLine());

        if (x.satuan_suhu == "celcius")
        {
            if (suhu < 36.5 || suhu > 37.5 || hari < x.batas_hari_deman)
            {
                Console.WriteLine(x.pesan_ditolak);
            }
            else
            {
                Console.WriteLine(x.pesan_diterima);
            }
        }
        else if (x.satuan_suhu == "fahrenheit") {
            if (suhu < 97.7 || suhu > 99.5 || hari < x.batas_hari_deman)
            {
                Console.WriteLine(x.pesan_ditolak);
            }
            else
            {
                Console.WriteLine(x.pesan_diterima);
            }
        }
    }
}