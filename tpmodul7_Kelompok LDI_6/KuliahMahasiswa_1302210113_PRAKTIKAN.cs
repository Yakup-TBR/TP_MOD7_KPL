using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_Kelompok_LDI_6
{
    internal class KuliahMahasiswa_1302210113_PRAKTIKAN
    {
        public void readJSON()
        {
            string jsonString = File.ReadAllText(@"C:\Users\Yakup Asmaidy\OneDrive\Dokumen\Semester_4\Kontruksi Perangkat Lunak\tpmodul7_Kelompok LDI_6\tpmodul7_Kelompok LDI_6\tp7_2_1302210113.json");

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
