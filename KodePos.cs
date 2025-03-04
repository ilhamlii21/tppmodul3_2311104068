using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tppmodul3_2311104068
{
    class KodePos
    {
        private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekajati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" },
            { "Samoja", "40273" }
        };

        public string getKodePos(string kelurahan)
        {
            if (tabelKodePos.ContainsKey(kelurahan))
            {
                return tabelKodePos[kelurahan];
            }
            else
            {
                return "Kode pos tidak ditemukan";
            }
        }

        public void MenampilkanSemuaKodePos()
        {
            Console.WriteLine("\nDaftar Kelurahan dan Kode Pos:");
            foreach (var item in tabelKodePos)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
