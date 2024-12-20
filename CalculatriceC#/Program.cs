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



    if (menuChoix <= 4)
    {
        switch (menuChoix)
        {
            case 1:
                {
                    bool stop = false;

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

                        if (valeurs != 999)
                        {

                            mesValeurs.Add(valeurs);
                        }
                        else if (valeurs == 999)
                        {
                            stop = true;
                        }
                    }
                    while (stop == false);
                    Console.Clear();
                }
                break;

            case 2:
                {
                    string operateur;
                    int sommes;
                    int valeursChoix1;
                    int valeursChoix2;
                    int result;

                    Console.WriteLine("\n\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                    Console.WriteLine("\u2551 Veuillez choisir votre opérateur \u2551");
                    Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
                    operateur = Console.ReadLine();
                    Console.Write("Selectionner votre première valeur : ");
                    valeursChoix1 = int.Parse(Console.ReadLine());
                    Console.Write("Selectionner votre deuxième valeur : ");
                    valeursChoix2 = int.Parse(Console.ReadLine());

                    switch (operateur)
                    {
                        case "+":
                            {
                                sommes = mesValeurs[valeursChoix1] + mesValeurs[valeursChoix2];
                                mesValeurs.Add(sommes);
                                result = sommes;
                            }
                            break;

                        case "-":
                            {
                                sommes = mesValeurs[valeursChoix1] - mesValeurs[valeursChoix2];
                                mesValeurs.Add(sommes);
                                result = sommes;
                            }
                            break;

                        case "*":
                            {
                                sommes = mesValeurs[valeursChoix1] * mesValeurs[valeursChoix2];
                                mesValeurs.Add(sommes);
                                result = sommes;
                            }
                            break;

                        case "/":
                                sommes = mesValeurs[valeursChoix1] / mesValeurs[valeursChoix2];
                                mesValeurs.Add(sommes);
                                result = sommes;
                            break;
                    }

                    Console.Clear();
                }
                break;

            case 3:
                {
                    Console.Clear();
                    int resultList = mesValeurs.LastOrDefault();

                    Console.WriteLine("\n\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                    Console.WriteLine("\u2551\t\t" + resultList + "\t\t\u2551");
                    Console.WriteLine("╚\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D\n");

                }
                break;

            case 0:
                {
                    Environment.Exit(0);
                }
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550═══\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
        Console.WriteLine("║Veuillez selectonner un chiffre entre 0 & 4║");
        Console.WriteLine("╚\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550═══\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D\n");
        Console.ResetColor();
    }

}
while (menu);