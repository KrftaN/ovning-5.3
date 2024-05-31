using System;

namespace övning_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = {
                "Vad är huvudstaden i Sverige?",
                "Vad är 5 + 7?",
                "Vilken färg har himlen?",
                "Vad är världens högsta berg?"
            };

            string[] svar = {
                "Stockholm",
                "12",
                "Blå",
                "Mount Everest"
            };

            Console.WriteLine("Välj en fråga genom att ange ett tal från 1 till 4:");
            int frågaNummer = int.Parse(Console.ReadLine());

            if (frågaNummer < 1 || frågaNummer > 4)
            {
                Console.WriteLine("Ogiltigt val. Vänligen ange ett tal mellan 1 och 4.");
            }
            else
            {
                int index = frågaNummer - 1;
                Console.WriteLine(frågor[index]);

                string användarSvar = Console.ReadLine();

                if (användarSvar.Equals(svar[index], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Rätt svar!");
                }
                else
                {
                    Console.WriteLine($"Fel svar. Rätt svar är: {svar[index]}");
                }
            }
        }
    }
}
