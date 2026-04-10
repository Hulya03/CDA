using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    class Roue
    {
        private string marqueRoue;
        private bool roueTourne;

        public string MarqueRoue { get => marqueRoue; /*set => marqueRoue = value;*/ }
        public bool RoueTourne { get => roueTourne; /*set => roueTourne = value;*/ }

        public Roue(string marqueRoue, bool roueTourne)
        {
            this.marqueRoue = marqueRoue;
            this.roueTourne = roueTourne;
        }

        public Roue() :this("", false)
        {
        }

        public Roue(Roue roueACopier) : this(roueACopier.marqueRoue, roueACopier.roueTourne)
        {
        }

        public bool TournerRoue()
        {
            if (roueTourne == false)
            {
                roueTourne= true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ArreterTourner()
        {
            if (roueTourne == true)
            {
                roueTourne= false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string result;
            result = $"= [ marqueRoue : {marqueRoue}, roueTourne : {roueTourne} ]";
            return result;
        }
    }
}
