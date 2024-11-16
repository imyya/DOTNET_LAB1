using System;
class Lab1
{
    public static void Main(string[] args)
    {
        Play();
    }

    public static void Play()
    {
        List<int> choix = new List<int>();
        bool continuePlay = true;
        int borne1 = 0;
        int borne2 = 0;
        int note = 0;
        while (continuePlay){
        try{
                Console.WriteLine("Donner la premiere borne de l'intervalle");
                borne1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Donner la deuxieme borne de l'intervalle");
                borne2 = Convert.ToInt32(Console.ReadLine());

                if (borne1 > borne2)
                {
                    throw new ArgumentOutOfRangeException("La premiere borne doit être inférieure à la deuxieme");
                }

                int randomNumber = new Random().Next(borne1, borne2);
                Console.WriteLine(randomNumber);

                Console.WriteLine($"Choisissez un nombre entre {borne1} et {borne2}");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 1 || number > 10)
                {
                    throw new ArgumentOutOfRangeException("Le nombre doit être compris entre [1, 10]");

                }

                while (number != randomNumber)
                {
                    choix.Add(number);
                    Console.WriteLine($"Mauvais choix. Cliquez sur q pour quitter ou entrez un autre nombre entre {borne1} et {borne2}");
                    string choice = Console.ReadLine() ?? string.Empty;
                    if (choice == "q")
                    {
                        continuePlay = false;
                        break;
                    }
                    number = Convert.ToInt32(choice);
                }

                if (number == randomNumber)
                {
                    choix.Add(number);

                    Console.WriteLine("Bravo! Vous avez gagné");
                    continuePlay = false;
                }

            int tentatives = choix.Count;
            int possibilites = borne2 - borne1 + 1;
            note = possibilites / tentatives;
            Console.WriteLine($"Vous avez eu une note de {note}");
            Console.WriteLine("Voici vos choix precedenents:" + string.Join(",", choix));
            }

        
        catch (FormatException)
        {
            Console.WriteLine("Entree invalide. Veuillez entrer un nombre entier.");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (System.DivideByZeroException e)
        {
            Console.WriteLine("Erreur: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erreur: " + e.Message);
        }

        // finally
        // {

        // }
    }
    }
}


