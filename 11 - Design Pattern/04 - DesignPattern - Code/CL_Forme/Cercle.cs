using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Forme
{
    public class Cercle : Forme
    {
        private int rayon;

        public Cercle(int x, int y, int rayon) : base(x, y)
        {
            this.rayon = rayon;  
        }

        public int Rayon { get => rayon; /*set => rayon = value; */}


        //version sans visiteur
        public override void SeRepresenterEnConsole()
        {
            Console.WriteLine($"Je suis un cercle à la position x = {this.x}, y= {this.y} \n" +
               $"de rayon = {this.rayon}");
        }

        // pour la version avec visiteur 
        // sert de porte d'entrée pour le visiteur
        public override void Accept(IVisiteurDeForme visiteurDeForme)
        {
            visiteurDeForme.Visit(this);
        }
    }
}
