using CL_Commerce;

Produit telephone = new Produit(1204, "Iphone 4", 50, 5);

Fournisseur fournisseur = new Fournisseur();
SiteWeb amazon = new SiteWeb();

telephone.EnregistrerObservateur(fournisseur);
telephone.EnregistrerObservateur(amazon);

telephone.VarierLesNombresProduitsDansStock(-45);

Console.WriteLine(telephone.Quantite);

