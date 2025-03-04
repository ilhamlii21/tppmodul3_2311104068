//using System;

//namespace tppmodul3_2311104068
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            KodePos kodePos = new KodePos();
//            Console.WriteLine("Menampilkan Kode Pos: ");
//            kodePos.MenampilkanSemuaKodePos();
//            Console.WriteLine("");
//        }
//    }
//}
using System;
using tppmodul3_2311104068;

class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.KunciPintu();
        pintu.KunciPintu();
        pintu.BukaPintu();
        pintu.BukaPintu();
    }
}
