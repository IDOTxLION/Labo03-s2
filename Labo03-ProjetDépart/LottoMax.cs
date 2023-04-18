// Labo 03, H-2023
//
// Classe dérivant Combinaison et qui modélise une combinaison
// de LottoMax
//
// par Pierre Prud'homme et Patrice Roy, 2022
// (retouché par Patrice Roy et Philippe Simard, 2023)
//
// complété par : << votre nom >>
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Labo03
{
   // Note : l'héritage doit être rétabli dans la version à remettre de votre 
   // laboratoire. La mise en commentaire est là pour que le projet compile au
   // moment de vous le remettre entre les mains. 
   class LottoMax : Combinaison
   {
        public LottoMax()
            :base(7,1,50)
        {

        }
        public override string ToString()
        {
            string chaine = string.Empty;

            return chaine;
        }
    }
}
