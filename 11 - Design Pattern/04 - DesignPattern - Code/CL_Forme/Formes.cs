using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Forme
{
    public class Formes : Forme
    {
        private List<Forme> sesFormes;

        public Formes(int x, int y) : base(x, y)                    // si on avait une liste existante de formes, on le mettrait entre parentheses
                                                                    // ici on met tout ce que "Formes" a besoin lors de sa création
                                                                    // sauf qu'on a décidé qu"il pouvait avoir zero forme au debut, 
                                                                    // au moment ou on le créé, le groupe est vide généralement,
                                                                    // donc d'abord on créé une liste, puis une méthode pour la remplir
        {
            this.sesFormes = new List<Forme>();
        }

        public void AjouterForme(Forme forme)
        {
            sesFormes.Add(forme);
        }

        public override void SeRepresenterEnConsole()
        {
            Console.WriteLine("Je suis une forme composée des formes suivantes :");

            foreach (Forme forme in sesFormes)
            {
                forme.SeRepresenterEnConsole();
            }
        }

        public override void Accept(IVisiteurDeForme visiteurDeForme)
        {
            visiteurDeForme.Visit(this);                            //ecrit la ligne "je suis une forme composé de ..."

            foreach (Forme forme in sesFormes)                      //
            {
                forme.Accept(visiteurDeForme);
            }
        }
    }
}
