using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdedames
{
    public class pion
    {
        public bool Iswhite;
        public char CharAffichage;
        
        public pion(bool isWhite)
        {
            Iswhite = isWhite;
            if (Iswhite)
                CharAffichage = 'B';
            else
                CharAffichage = 'N';
        }
    }
}
