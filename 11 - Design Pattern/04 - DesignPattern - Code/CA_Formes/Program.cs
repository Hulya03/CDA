using CA_Forme;
using CL_Forme;
using System.Drawing;

CL_Forme.Rectangle r1 = new CL_Forme.Rectangle(2, 77, 60, 40);

VisiteurFormePourConsole v1 = new VisiteurFormePourConsole(); 

r1.Accept(v1);



//forme composée de plusieurs formes :

Cercle c1 = new Cercle(11,22,52);
CL_Forme.Rectangle r2 = new CL_Forme.Rectangle(21, 11, 67, 10);
Cercle c2 = new Cercle(77, 50, 99);

Formes dessin = new Formes(7,8);

//ajouter forme par la méthode car liste de formes est en privé 

dessin.AjouterForme(r1);
dessin.AjouterForme(r2);
dessin.AjouterForme(c1);
dessin.AjouterForme(c2);

dessin.Accept(v1);