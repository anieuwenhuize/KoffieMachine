using System;

namespace KoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak de koffiemachine aan
            KoffieMachine koffieMachine = new KoffieMachine();

            // neem een bekertje koffie
            Bekertje mijnEersteBakje = koffieMachine.GeefCappuccino();

            // bekertje.Print();
            mijnEersteBakje.Print();

            // Doe dit net zo vaak totdat er een exception optreedt
            Console.Read();
        }
    }
}
