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
        int nbChiffres;
        int min;
        int max;

        //public int NbChiffres
        //{ get => nbChiffres; set { nbChiffres = value; } }
        //public int Min
        //{ get => min; set { min = value; } }
        //public int Max
        //{ get => max; set { max = value; } }
        /// <summary>
        /// Constructeur paramétrique
        /// </summary>
        public Combinaison(int nbChiffres, int min, int max)
        {
            this.nbChiffres = nbChiffres;
            this.min = min;
            this.max = max;
        }
        // 
        public static List<int> D(int nbChiffres, int min, int max)
        {
            List<int> list = new List<int>();
            for (int i = 0; i != nbChiffres; i++)
            {
                list.Add(Générateur.Next(min, max));
            }
            return list;


        }


        public override string ToString()
        {
            List<int> list = D(nbChiffres, min, max);
            string chaine = string.Empty;
            //foreach (int n in D(nbChiffres, min, max))
            //    if(n == D(nbChiffres, min, max).Count-1)
            //        chaine += n.ToString();
            //    else
            //        chaine += string.Format(" {0} - ", n);
            for (int i = 0; i < list.Count; i++)
                if (i == list.Count - 1)
                    chaine += list[i].ToString();
                else
                    chaine += string.Format(" {0} - ", list[i]);


            return chaine;

        }
    }
}
