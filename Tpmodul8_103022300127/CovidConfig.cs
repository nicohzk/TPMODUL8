using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tpmodul8_103022300127
{
    class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        readonly string filePath = Path.GetFullPath("../../../../datas/covid_config.json");
        public void ReadJSON() {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                CovidConfig x = JsonSerializer.Deserialize<CovidConfig>(json); 
                satuan_suhu = x.satuan_suhu;
                batas_hari_deman = x.batas_hari_deman;
                pesan_ditolak = x.pesan_ditolak;
                pesan_diterima = x.pesan_diterima;
            }
            ;
        }
        public void UbahSatuan()
        {
            satuan_suhu = (satuan_suhu == "celcius") ? "fahrenheit" : "celcius";
        }
    }

}
