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
 
        // COSTRUTTORE

        public Indirizzo(string name, string surname, string street, string city, string province, int ZIP)
        {
            /*if(name == "" || surname == "" || street == "" || city == "" || province == "")
            {
                throw new ArgumentException("Mancano dei parametri");
            } */
            if (name == "")
            {
                throw new ArgumentException("Devi inserire il nome");
            } if (surname == "")
            {
                throw new ArgumentException("Devi inserire il cognome");
            } if(street == "")
            {
                throw new ArgumentException("Devi inserire la strada");
            } if (city == "")
            {
                throw new ArgumentException("Devi inserire la città");             
            } if (province == "")
            {
                throw new ArgumentException("Devi inserire la provincia");
            }
            
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.ZIP = ZIP;
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
            string addressInfo = "-----------------------------" + "\n";
            addressInfo += "\tNome: " + this.name + "\n";
            addressInfo += "\tCognome: " + this.surname + "\n";
            addressInfo += "\tStrada: " + this.street + "\n";
            addressInfo += "\tCittà: " + this.city + "\n";
            addressInfo += "\tNumero civico: " +  this.ZIP + "\n";
            return addressInfo;
        }
    }   


    
}   
    
