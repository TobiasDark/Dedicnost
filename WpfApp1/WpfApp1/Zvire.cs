using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Zvire
    {
        public Zvire(string barva, string jmeno, int nohy,bool letat )
        {
            this.Barva = barva;
            this.Nohy = nohy;
            this.Letat = letat;
            this.Jmeno = jmeno;
        }

        public string Barva { get; set; }
        public string Jmeno { get; set; }
        public int Nohy { get; set; }
        public bool Letat { get; set; }
    }
}
