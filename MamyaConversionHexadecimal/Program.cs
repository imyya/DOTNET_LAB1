using System;
using System.Collections.Generic;

class MamyaConversionHexadecimal
{
    static void Main(string[] args)
    {
        List<int> entiersConvertis = new List<int>();
        List<string> valeursHexadecimales = new List<string>();

        while (true)
        {
            Console.WriteLine("Entrez un entier à convertir en hexadécimal (ou 'q' pour quitter) :");
            string input = Console.ReadLine();

            if (input.ToLower() == "q" || input.ToLower() == "quitter")
            {
                break;
            }

            if (int.TryParse(input, out int entier))
            {
                string hexValue = ConvertToHexadecimal(entier);
                entiersConvertis.Add(entier);
                valeursHexadecimales.Add(hexValue);

                Console.WriteLine($"Valeur hexadécimale de {entier} : {hexValue}");
            }
            else
            {
                Console.WriteLine("Veuillez entrer un entier valide.");
            }
        }

            if (entiersConvertis.Count == 0)
            {
                Console.WriteLine("\nAucune conversion n'a été réalisée.");
            }
            else
            {
                Console.WriteLine("\nListe des conversions réalisées :");
                for (int i = 0; i < entiersConvertis.Count; i++)
                {
                    Console.WriteLine($"{entiersConvertis[i]} -> {valeursHexadecimales[i]}");
                }
            }
        }

    static string ConvertToHexadecimal(int entier)
    {
        const string hexChars = "0123456789ABCDEF";
        string hexResult = "";

        do
        {
            int reste = entier % 16;
            hexResult = hexChars[reste] + hexResult;
            entier /= 16;
        } while (entier > 0);

        return hexResult;
    }
}
