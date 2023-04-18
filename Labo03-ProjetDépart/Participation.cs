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
using System.Text;
using System.Threading.Tasks;

namespace Labo03
{
   abstract class Participation
   {
      public abstract float Coût { get;  }
      
      public Participation()
        {
            List<Combinaison> NbrCombinaison = new();
        }
        public abstract override string ToString()
        {
            StringBuilder chaine = new StringBuilder();
            chaine = string.Empty;
            return chaine;

        }

    }

   class ParticipationLottoMax : Participation
   {
        public ParticipationLottoMax()
        {
            LottoMax comb1 = new LottoMax(); LottoMax comb2 = new LottoMax(); LottoMax comb3 = new LottoMax();
        }

        public abstract override string ToString()
        {
            StringBuilder chaine = new();
            chaine.Append("Billet de Lotto Max\n");
            chaine.Append("\n");
            chaine.Append($"{comb1}\n{comb2}\n{comb3}\n");


        }




        public override float Coût { get { return 0; }  }

   }

   class ParticipationToutOuRien : Participation
   {
        public ParticipationToutOuRien()
        {
            LottoMax val = new LottoMax();
        }

        public override float Coût { get { return 0; }  }
   }
}
