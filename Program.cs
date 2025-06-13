using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Esperto Contra Sabido (Vila do Chaves) ---");
        
        
        int totalSanduiches;
        while (true)
        {
            Console.Write("Quantos sanduíches de presunto serão distribuídos?: ");
            if (int.TryParse(Console.ReadLine(), out totalSanduiches) && totalSanduiches > 0)
                break;
            Console.WriteLine("Fala sério! Digite um número válido maior que zero!");
        }

        int chaves = 0;
        int kiko = 0;
        int rodada = 1;
        int sanduichesRestantes = totalSanduiches;

        Console.WriteLine(); 

        
        while (sanduichesRestantes > 0)
        {
            
            int paraChaves = Math.Min(rodada, sanduichesRestantes);
            Console.Write($"{paraChaves} para você.");
            chaves += paraChaves;
            sanduichesRestantes -= paraChaves;


            if (sanduichesRestantes > 0)
            {
                int paraKiko = Math.Min(rodada, sanduichesRestantes);
                Console.Write("1");
                for (int i = 2; i <= paraKiko; i++)
                {
                    Console.Write($", {i}");
                }
                Console.WriteLine($" para mim!");

                kiko += paraKiko;
                sanduichesRestantes -= paraKiko;
            }
            else
            {
                Console.WriteLine(); 

            }

            rodada++;
        }


        Console.WriteLine($"\nChaves recebeu {chaves} sanduíche(s) de presunto.");
        Console.WriteLine($"Kiko recebeu {kiko} sanduíche(s) de presunto.");
        
       
        if (kiko > chaves )
        {
            Console.WriteLine("\nKiko: Não era brincadeira! Eu sou mesmo esperto!");
        }
    }
}