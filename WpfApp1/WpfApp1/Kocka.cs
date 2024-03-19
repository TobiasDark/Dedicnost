using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kocka : Zvire
    {
        public Kocka(string barva, string jmeno, int nohy, bool letat) : base(barva, jmeno, nohy, letat)
        {
        }

        public string Zvuk()
        {
            return $"Meoow";
        }


    }
}
