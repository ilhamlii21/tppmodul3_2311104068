using System;

namespace tppmodul3_2311104068
{
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    public class DoorMachine
    {
        private DoorState state;

        public DoorMachine()
        {
            state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (state == DoorState.Terkunci)
            {
                state = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void KunciPintu()
        {
            if (state == DoorState.Terbuka)
            {
                state = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}
