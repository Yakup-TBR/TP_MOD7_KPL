﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_Kelompok_LDI_6
{
    internal class DataMahasiswa1302210027
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"E:\College\semester 4\KPL\MOD 7\TP_MOD7_KPL\tpmodul7_Kelompok LDI_6\tp7_1_1302210027.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}
