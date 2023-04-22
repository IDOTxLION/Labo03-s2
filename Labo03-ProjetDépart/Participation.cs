// Labo 03, H-2023
//
// Participation modélise les modalités de participation à
// une loterie. Ses dérivés expriment les détails de ces
// modalités en fonction des loteries supportées
//
// par Pierre Prud'homme et Patrice Roy, 2022
// (retouché par Patrice Roy et Philippe Simard, 2023)
//
// complété par : << votre nom >>
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labo03
{
    abstract class Participation
    {
        public abstract float Coût { get; }
        List<Combinaison> nbrcombinaisons;
        public List<Combinaison> Nbrcombinaisons 
        { get => nbrcombinaisons; set { nbrcombinaisons =value; } }

        public Participation()
        {
            Nbrcombinaisons=nbrcombinaisons;

        }

        public override string ToString()
        {
            StringBuilder chaine = new StringBuilder();
            
            return chaine.ToString();

        }

    }

    class ParticipationLottoMax : Participation
    {
        public ParticipationLottoMax()
            : base()
        {
            LottoMax comb = new LottoMax();
            Nbrcombinaisons = new List<Combinaison>();
            Nbrcombinaisons.Add(comb);

            Coût = 5;
        }

        public override string ToString()
        {
            StringBuilder chaine = new();

            for (int i = 0; i < 3; i++)
            {
                foreach (Combinaison n in Nbrcombinaisons)
                    chaine.Append($"{n}\n");    
            }
            return chaine.ToString();


        }
        public override float Coût { get;  }

    }

    class ParticipationToutOuRien : Participation
    {
        public ParticipationToutOuRien()
        {
            ToutOuRien comb = new ToutOuRien();
            Nbrcombinaisons = new List<Combinaison>();
            Nbrcombinaisons.Add(comb);
            Coût=2;
        }
        public override string ToString()
        {
            StringBuilder chaine = new();

            foreach (Combinaison n in Nbrcombinaisons)
                chaine.Append($"{n}\n");
            return chaine.ToString();
        }
        public override float Coût { get; }
    }
}
