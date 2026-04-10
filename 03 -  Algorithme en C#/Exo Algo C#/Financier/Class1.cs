namespace Financier
{
    //= bibliotèque de classe

    public class Credit     // si on met pas public, il n'y aura pas de visibilité en dehors du namespace
    {
        // Attributs : ce sont les caractéristiques
        // (normalement ils sont "private"  => utilisation de propriété : un accesseur "get" sur java pour accéder à l'attribut, un modifieur "set" 
                                                         // sur C# pour accessibilité et mofiications des attributs privés
                                                         //  1. clic droit sur l'attribut
                                                         //  2. clic sur "actions rapides et refactorisation"
                                                         //  3. clic sur "encapsuler le champs: nom de l'attribut (et utiliser la propriété) 
        private double tauxMensuel;
        private double montantEmprunt;
        private int nbMois;
        private double coutTotalCredit;
        private double[] partInteret;
        private double[] partCapital;
        private double[] capitalRestantDu;

        public Credit(double _montant, double _tauxA, int _nbAnnees)  // Constructeur : rôle => donne une forme/un état à l'objet
                                                                      // Constructeur surchargé : il a plusieurs paramètres
        {
            this.nbMois = _nbAnnees * 12;                              
            this.tauxMensuel = _tauxA / 1200;
            this.montantEmprunt = _montant;

           partInteret  = new double[nbMois];
           partCapital = new double[nbMois];
           capitalRestantDu = new double[nbMois];


        }

        //Propriétés qui permettent l'accessibilité et la modification des attributs 
        public double TauxMensuel { get => tauxMensuel; set => tauxMensuel = value; }
        public double MontantEmprunt { get => montantEmprunt; set => montantEmprunt = value; }
        public int NbMois { get => nbMois; set => nbMois = value; }
        


        // Méthodes de la classe = traitements (c'est ce que peut faire un objet)
        // Méthode = procédure + fonction
        // Procédure = renvoie rien (elle exéucute une séquence d'instruction)
        // Fonction = renvoie toujours qqch (a obligatoirement un retour)

        public double CalculMensualite()
        {
            double mensualite;

            double quotient = (1 - Math.Pow((1 + this.TauxMensuel), -this.NbMois));
            mensualite = MontantEmprunt * TauxMensuel / quotient;

            return Math.Round(mensualite, 2);
        }

        public override string ToString()                      // "override" permet d'utiliser l'implémentation de base ( grace à "base." et on ajoute ce qu'on veut
        {
            string description = $"CREDIT : montant du credit : {this.MontantEmprunt} Taux mensuel : {this.TauxMensuel} Durée de remboursement : {this.NbMois}";  //description, non obligatoire, on l'utilise pour voir ce qu'on fait
            return base.ToString() + ":" + description;
        }

        // Méthode qui créé un tableau d'amortissement

        public void AfficherTableauAmrt(ref double[] _partInteret, ref double[] _partCapital, ref double[] _capitalRestantDu)
        {
           
            double mensualite;
            
            string result;
            double coutTotalCredit = 0;

            result = "";

            _capitalRestantDu[0] = montantEmprunt;
            _partInteret[0] = 0;
            _partCapital[0] = 0;

            mensualite = montantEmprunt * tauxMensuel / (1 - Math.Pow((1 + tauxMensuel), -nbMois));

            for (int i = 1; i < nbMois; i++)
            {
               _partInteret[i] = _capitalRestantDu[i - 1] * tauxMensuel;
                _partCapital[i] = mensualite - _partInteret[i];
                _capitalRestantDu[i] = _capitalRestantDu[i - 1] - _partCapital[i];
                coutTotalCredit += _partInteret[i];

            }

            for (int j = 0; j < nbMois; j++)
            {
                result = j + "  ";
                result += Math.Round(_partInteret[j], 2).ToString() + "  ";
                result += Math.Round(_partCapital[j], 2).ToString() + "  ";
                result += Math.Round(_capitalRestantDu[j], 2).ToString() + "  ";
                result += Math.Round(mensualite, 2).ToString() + "  ";
                Console.WriteLine(result);

            }

            Console.WriteLine("Le coût total du crédit est :" + Math.Round(coutTotalCredit,2));
            
        }

        // Méthode qui permet de retouner le coût total du crédit (en dehors de l'argent qu'on nous a prêté donc il faut additioner que les parts interet)
        public double CoutTotalDuCredit()
        {

            this.AfficherTableauAmrt(ref partInteret, ref partCapital, ref capitalRestantDu);
            double somme = 0;
            foreach (double values in partInteret)
            {
                somme += values;
            }

            return somme;
        }


    }
}
