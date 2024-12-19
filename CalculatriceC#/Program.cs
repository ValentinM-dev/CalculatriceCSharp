bool menu = true;
List<int> mesValeurs = new List<int> { };


do
{
    Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
    Console.WriteLine("\u2551 Calculatrice C# \u2551");
    Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
    Console.WriteLine($"1--- Entrez vos valeurs ({mesValeurs.Count})");
    Console.WriteLine("2--- Choisissez votre operateur");
    Console.WriteLine("3--- Afficher le résultat");
    Console.WriteLine("0--- Quittez");

    Console.WriteLine("--- Veuillez effectuer votre choix ---\t");
    int menuChoix = int.Parse(Console.ReadLine());




    switch (menuChoix)
    {
        case 1:
            {
                bool stop = true;

                do
                {
                    Console.Clear();
                    Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                    Console.WriteLine("\u2551 Calculatrice C# \u2551");
                    Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
                    Console.WriteLine("\n\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                    Console.WriteLine("\u2551 Veuillez entrer vos valeurs \u2551");
                    Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
                    int valeurs = int.Parse(Console.ReadLine());
                    mesValeurs.Add(valeurs);
                    string confirmation;
                    Console.WriteLine("\n\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550═\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                    Console.WriteLine("║Voulez vous continuer de saisir des valeurs║");
                    confirmation = Console.ReadLine();
                    if (confirmation == "oui" || confirmation == "o")
                    {
                        Console.Clear();
                        
                    }
                    
                    else
                    {
                        stop = false;
                    }
                }
                while (stop == false);
                Console.Clear();
            }
            break;

    }
   
}
while (menu) ;