// Labo 03, H-2023
//
// Classe pouvant retenir une combinaison d'une loterie dont le type
// sera déterminé à la construction d'une classe dérivée
//
// par Pierre Prud'homme et Patrice Roy, 2022
// (retouché par Patrice Roy et Philippe Simard, 2023)
//
// complété par : << votre nom >>
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Labo03
{
   abstract class Combinaison
   {
      /// <summary>
      /// Constructeur paramétrique
      /// </summary>
      public Combinaison(int nbChiffres, int min, int max)
      {
      }

      public override string ToString()
      {
         string chaine = string.Empty;

         return chaine;
      }
   }
}
