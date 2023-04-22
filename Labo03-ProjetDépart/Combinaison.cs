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
using System.Text;

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
        List<int> liste;
        public List<int> Liste
        {
            get => liste;
            set { liste= D(NbChiffres, Min, Max); }

        }
        /// <summary>
        /// Constructeur paramétrique
        /// </summary>
        public Combinaison(int nbChiffres, int min, int max)
        {
            NbChiffres = nbChiffres;
            Min = min;
            Max = max;
            Liste = liste;
        }
        // 

        public static List<int> D(int nbChiffres, int min, int max)
        {
            List<int> NbrDeValeur = new List<int>(max);
            List<int> Liste = new();
            for (int i = 1; i != max; i++)
            {
                NbrDeValeur.Add(i);
            }

            for (int i = 0; i != nbChiffres; i++)
            {
                int val = NbrDeValeur[Générateur.Next(min, NbrDeValeur.Count)];
                Liste.Add(val);
                NbrDeValeur.Remove(val);


            }
            Liste.Sort();
            return Liste;

        }
        

        public override string ToString()
        {

            StringBuilder chaine = new();
            for(int i = 0; i< Liste.Count; i++)
                if(i==Liste.Count-1)
                    chaine.Append(Liste[i]);
            else
                    chaine.Append(string.Format("{0,2} - ", Liste[i])); 
                    

            Liste = new();


            return chaine.ToString();

        }
    }
}
