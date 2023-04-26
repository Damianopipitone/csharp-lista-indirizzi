// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;
using static System.Net.Mime.MediaTypeNames;
using System;

List<Indirizzo> addressList = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:\\Users\\Utente\\Desktop\\esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\file di testo\\addresses.csv");

    int rowCounter = 0;

    while (!file.EndOfStream)
    {
        string rowRead = file.ReadLine();
        rowCounter++;

        if (rowCounter > 1)
        {
            string[] splitInfo = rowRead.Split(",");

            if (splitInfo.Length != 6)
            {
                Console.WriteLine("La riga " + rowCounter + "non rispetta i parametri previsit!");
            }
            else
            {

            }
        }
    }

    

        
}