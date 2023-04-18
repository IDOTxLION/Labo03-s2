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

  

        public int NbChiffres
        { get; set; }
        public int Min
        { get; set; }
        public int Max
        { get; set; }
        /// <summary>
        /// Constructeur paramétrique
        /// </summary>
        public Combinaison(int nbChiffres, int min, int max)
        {
            NbChiffres = nbChiffres;
            Min = min;
            Max = max;
        }
        // 
        public static List<int> D(int nbChiffres, int min, int max)
        {
            List<int> list = new();
            for (int i = 0; i != nbChiffres; i++)
            {
                list.Add(Générateur.Next(min, max));
            }
            list.Sort();
            return list;


        }


        public override string ToString()
        {
            List<int> list = D(NbChiffres, Min, Max);
            string chaine = string.Empty;
            for (int i = 0; i < list.Count; i++)
                if (i == list.Count - 1)
                    chaine += list[i].ToString();
                else
                    chaine += string.Format(" {0} - ", list[i]);


            return chaine;

        }
    }
}
