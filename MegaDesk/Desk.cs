using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
    }

    public enum surfaceMaterials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rossewood = 300,
        Veneer = 125
    };
}
