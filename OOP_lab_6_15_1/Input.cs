using System;
using System.IO;

namespace OOP_lab_6_15_1
{
    class Input : IInput
    {
        public void Read()
        {
            new Program().Initialisation(new StreamReader("base.txt").ReadToEnd());
        }

        public string ReadColor()
        {
            return Console.ReadLine();
        }

        public string ReadBrand()
        {
            return Console.ReadLine();
        }
    }
}
