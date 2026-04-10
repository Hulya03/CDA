using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Achat
{
    public class Achat
    {
        private string nom;
        private DateTime date;
        private decimal montant;
        private string codePostal;

        public Achat() {
            this.nom = "";
            this.date = DateTime.MinValue;             // Représente la plus petite valeur possible de DateTime
            this.montant = 0;
            this.codePostal = "";
        }

        public Achat(string nom, DateTime date, decimal montant, string codePostal)
        {
            this.nom = nom;
            this.date = date;                   
            this.montant = montant;
            this.codePostal = codePostal;
        }

        public string Nom { get => nom; }
        public DateTime Date { get => date; }
        public decimal Montant { get => montant; }
        public string CodePostal { get => codePostal; }

    }
}
