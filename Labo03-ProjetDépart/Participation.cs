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
      public abstract float Coût { get; set; }
   }

   class ParticipationLottoMax : Participation
   {
      // à modifier
      public override float Coût { get { return 0; } set { } }

   }

   class ParticipationToutOuRien : Participation
   {
      // à modifier
      public override float Coût { get { return 0; } set { } }
   }
}
