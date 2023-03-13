// See https://aka.ms/new-console-template for more information

namespace MOD4_1302210125
{
    class Mainprogram
    {
        public static void Main(string[] args)
        {
            KodeBuah table_Kode_Buah = new KodeBuah();
            Console.WriteLine("Nama Buah Aprikot");
            table_Kode_Buah.getKodeBuah("B00");
            Console.WriteLine("\n");
            Console.WriteLine("Nama Kode Buah ");
            table_Kode_Buah.getallKodeBuah();
            Console.WriteLine("\n");
        }
    }
    class KodeBuah
    {
        Dictionary<string,string> dic_Kode_Buah = new Dictionary<string, string>()
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Aalpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
        };

        public void getKodeBuah(string kode)
        {
            if (dic_Kode_Buah.ContainsKey(kode))
            {
                Console.WriteLine("- " + kode + " : " + dic_Kode_Buah[kode]);
            }
            else
            {
                Console.WriteLine(kode + "Kode Tidak Terdaftar");
            }
        }

        public void getallKodeBuah()
        {
            foreach (KeyValuePair<string, int> i in dic_Kode_Buah)
            {
                Console.WriteLine("- " + i.Key + " : " + i.Value);
            }
        }

    }
}
