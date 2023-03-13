// See https://aka.ms/new-console-template for more information

namespace MOD4_1302210125
{
    class Mainprogram
    {
        public static void Main(string[] args)
        {
            KodeBuah table_Kode_Buah = new KodeBuah();
            Console.WriteLine("Nama Buah Aprikot");
            table_Kode_Buah.getKodeBuah("G00 ");
            Console.WriteLine("\n");
            Console.WriteLine("Nama Kode Buah ");
            table_Kode_Buah.getallKodeBuah();
            Console.WriteLine("\n");

            Console.WriteLine("MOVE STATUS");

            karaktergame karakter = new karaktergame();

            karakter.key();
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
            foreach (KeyValuePair<string, string> i in dic_Kode_Buah)
            {
                Console.WriteLine("- " + i.Key + " : " + i.Value);
            }
        }

    }

    class karaktergame
    {
        enum State { Terbang, Jongkok, Berdiri};

        public void key()
        {
            State state = State.Terbang;

            String[] karakter_status = { "Terbang", "Jongkok", "Berdiri" };
            do
            {
                Console.WriteLine("karakter " + karakter_status[(int)state]);
                Console.Write("Keyword : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.Terbang:
                        if (command == "TERBANGGGGG")
                        {
                            state = State.Jongkok;
                        }
                        break;
                    case State.Jongkok:
                        if (command == "ENCOOOK")
                        {
                            state = State.Berdiri;
                        }
                        break;
                    case State.Berdiri:
                        if (command == "Lets GOOO")
                        {
                            state = State.Terbang;
                        }
                        break;
                }
            } while (state != State.Terbang);
        }
    }
}