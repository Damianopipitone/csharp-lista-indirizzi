﻿// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Linq.Expressions;

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
                Console.WriteLine("La riga " + rowCounter + " non rispetta i parametri previsit!");
            }
            else
            {
                int civicNumber = int.Parse(splitInfo[5]);

                try
                {
                    Indirizzo address = new Indirizzo(splitInfo[0], splitInfo[1], splitInfo[2], splitInfo[3], splitInfo[4], civicNumber);
                    addressList.Add(address);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("C'è stato un errore alla riga numero " + rowCounter);
                    Console.WriteLine(ex.Message);

                    if (ex.ParamName == "")
                    {
                        Console.WriteLine("Manca il nome...");
                    }
                }
            }
        }
    } 
    file.Close();
}

    catch (Exception e)
    {
        Console.WriteLine("Qualcosa è andato storto...");
        Console.WriteLine(e.Message);
    }

foreach (Indirizzo indirizzo in addressList)
{
    Console.WriteLine(indirizzo);
}

