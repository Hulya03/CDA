using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Forme
{
    public abstract class Forme
    {
        protected int x;
        protected int y;

        public int X { get => x; /*set => x = value;*/ }
        public int Y { get => y; /*set => y = value; */}

        public Forme(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void SeRepresenterEnConsole();

        public abstract void Accept(IVisiteurDeForme visiteurDeForme);
    }
}
