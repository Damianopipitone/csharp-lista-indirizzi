// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;
using static System.Net.Mime.MediaTypeNames;
using System;

StreamReader file = File.OpenText("C:\\Users\\Utente\\Desktop\\esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\file di testo\\addresses.csv");

Indirizzo address = new Indirizzo();

List<Indirizzo> addressList = new List<Indirizzo>();
