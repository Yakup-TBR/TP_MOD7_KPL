﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_Kelompok_LDI_6
{
    internal class KuliahMahasiswa1302210094
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"F:\Kuliah Rifqi\Semester 4\PRAKTIKUM KONSTRUKSI PERANGKAT LUNAK\TP_MOD7_KPL\tpmodul7_Kelompok LDI_6\tp7_1_1302210094.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int iter = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {course.code}-{course.name}");
                iter++;
            }
        }
    }
}
