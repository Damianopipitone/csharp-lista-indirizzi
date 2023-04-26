using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        public string name;
        public string surname;
        public string street;
        public string city;
        public string province;
        public int ZIP;
        List<Indirizzo> lista;
        
        // COSTRUTTORE

        public Indirizzo(string name, string surname, string street, string city, string province, int ZIP)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.ZIP = ZIP;
            this.lista = new List<Indirizzo>();
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetStreet()
        {
            return street;
        }

        public string GetCity()
        {
            return city;
        }

        public int GetZIP()
        {
            return ZIP;
        }

        // METODI 

        public override string ToString()
        {
            string addressInfo = "-----------------------------";
            addressInfo += "\tNome: " + this.name + "\n";
            addressInfo += "\tCognome: " + this.surname + "\n";
            addressInfo += "\tStrada: " + this.street + "\n";
            addressInfo += "\tCittà: " + this.city + "\n";
            addressInfo += "\tNumero civico: " +  this.ZIP + "\n";
            return addressInfo;
        }
    }   


    
}   
    
