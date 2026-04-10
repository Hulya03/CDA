using CL_Forme;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Forme
{
    class VisiteurFormePourConsole : IVisiteurDeForme
    {
        public void Visit(CL_Forme.Rectangle rectangle)
        {
            Console.WriteLine($"Je suis un rectangle à la position x = {rectangle.X}, y= {rectangle.Y} \n" +
                        $"de longueur = {rectangle.Longueur} et de largeur = {rectangle.Largeur}");
        }

        public void Visit(Cercle cercle)
        {
            Console.WriteLine($"Je suis un cercle à la position x = {cercle.X}, y = {cercle.Y} \n" +
                        $"de rayon = {cercle.Rayon}");
        }
        public void Visit(Formes formes)
        {
            Console.WriteLine($"Je suis une forme à la position x = {formes.X} et y = {formes.Y} composée des formes suivantes :");

            //on met la méthode pour vister les enfants dans la classe formes quand on accepte le visiteur     
        }
    }
}
