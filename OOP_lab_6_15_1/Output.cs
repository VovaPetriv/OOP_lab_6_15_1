using System;

namespace OOP_lab_6_15_1
{
    class Output : IOutput
    {
        private static string _format = "{0,-35} {1,-15} {2,-20} {3}";

        public void Write()
        {
            Console.WriteLine("Введiть критерiй (Brand / Color)");

            switch(Console.ReadLine())
            {
                case "Brand":
                case "brand":
                    Console.Write("Марка: ");
                    WriteBrand(new Input().ReadBrand());
                    break;

                case "Color":
                case "color":
                    Console.Write("Колiр: ");
                    WriteColor(new Input().ReadColor());
                    break;
            }
        }

        public void WriteBrand(string brand)
        {
            Console.WriteLine("Результати:");
            Console.WriteLine(_format, "Марка", "Номер", "Колiр", "Данi про власника");

            for (int i = 0; i < Program.owners.Length; ++i)
            {
                if (Program.owners[i].CarBrand == brand)
                {
                    Console.WriteLine(_format, Program.owners[i].CarBrand, Program.owners[i].CarNumber, Program.owners[i].CarColor, Program.owners[i].PersonalInfo);
                }
            }

            Write();
        }

        public void WriteColor(string color)
        {
            Console.WriteLine("Результати:");
            Console.WriteLine(_format, "Марка", "Номер", "Колiр", "Данi про власника");

            for (int i = 0; i < Program.owners.Length; ++i)
            {
                if (Program.owners[i].CarColor == color)
                {
                    Console.WriteLine(_format, Program.owners[i].CarBrand, Program.owners[i].CarNumber, Program.owners[i].CarColor, Program.owners[i].PersonalInfo);
                }
            }

            Write();
        }
    }
}
