// Labo 03, H-2023
//
// La classe Générateur, non instanciable, offre les services d'une 
// instance de Random pour générer des nombres aléatoires. La constante
// GERME permet d'avoir dans un premier temps une bataille reproduisible 
// mais nous pourrions éventuellement le germe de l'instanciation de 
// Random. 
//
// par Pierre Prud'homme et Patrice Roy, 2022
// (retouché par Patrice Roy et Philippe Simard, 2023)
//
// complété par : << votre nom >>
//---------------------------------------------------------------------------------------
using System;

namespace Labo03
{
   static class Générateur
   {
      const int GERME = 22;                            // bien entendu...

      static Random Gen { get; } = new(GERME);


      /// <summary>
      /// Permet de retourner un entier entre une valeur min et une
      /// valeur max
      /// 
      /// Le nombre généré sera entre [min, max[
      /// </summary>
      /// <param name="min">Valeur min du nombre à générer</param>
      /// <param name="max">Valeur max du nombre à générer</param>
      /// <returns></returns>
      static public int Next(int min, int max = int.MaxValue)
      {
         // à faire 
         return 0; // instruction dont le seul but est que ça compile
      }
   }
}
