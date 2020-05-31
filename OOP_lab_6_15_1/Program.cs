using System;

namespace OOP_lab_6_15_1
{
    class Program : IProgram
    {
        public static Owner[] owners;

        static void Main(string[] args)
        {
            new Input().Read();
            new Output().Write();
        }

        public void Initialisation(string allBase)
        {
            string[] elements = allBase.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            owners = new Owner[elements.Length / 4];

            for (int i = 0; i < elements.Length; i += 4)
            {
                owners[i / 4] = new Owner(elements[i], elements[i + 1], elements[i + 2], elements[i + 3]);
            }
        }
    }
}
