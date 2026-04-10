using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Forme
{
    public class Rectangle : Forme
    {
        private int longueur;
        private int largeur;

        public Rectangle(int x, int y, int longueur, int largeur) :base(x,y)   //Puisque Rectangle est une Forme,
                                                                               //elle ne peut pas exister sans que la partie "Forme" soit initialisée d'abord                                                                              
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public int Longueur { get => longueur; /*set => longueur = value;*/ }
        public int Largeur { get => largeur; /*set => largeur = value;*/ }


        //version sans visiteur
        public override void SeRepresenterEnConsole()
        {
            Console.WriteLine($"Je suis un rectangle à la position x = {this.x}, y= {this.y} \n" +
                $"de longueur = {this.longueur} et de largeur = {this.largeur}" );
        }


        // pour la version avec visiteur 
        // sert de porte d'entrée pour le visiteur
        public override void Accept(IVisiteurDeForme visiteurDeForme)
        {
            visiteurDeForme.Visit(this);
        }

    }
}
