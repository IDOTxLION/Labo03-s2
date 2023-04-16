// Labo 03, H-2023
//
// Fabrique de participations
//
// par Pierre Prud'homme et Patrice Roy, 2022
//---------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labo03
{
   // Classe qui permet de découpler l'instanciation du programme client.
   // Si de nouvelles classes s'ajoutent à la hiérarchie pour offrir de 
   // nouveaux choix de loteries le programme client n'aura pas à être
   // modifié
   class FabriqueGénérale
   {
      // Dictionnaire qui établit un lien entre les noms des choix de
      // loterie et la procédure d'instanciation programmée à l'aide 
      // d'une lambda. Notez que c'est une propriété privée pour 
      // ne pas briser l'encapsulation
      Dictionary<string, Func<Participation>> DictionnaireParticipation { get; set; }

      /// <summary>
      /// La construction de la fabrique peuple le dictionnaire des
      /// choix disponibles de loteries (les clés du dictionnaire)
      /// et associe à chaque clé une lambda qui définit une
      /// méthode d'instanciation pour chaque loterie
      /// </summary>
      public FabriqueGénérale()
      {
         DictionnaireParticipation = new()
         {
             { "LottoMax", () => new ParticipationLottoMax() },
             { "Tout ou rien", () => new ParticipationToutOuRien() }
         };

      }

      /// <summary>
      /// Instancier reçoit en paramètre la chaine qui correspond à la 
      /// clé du dictionnaire à laquelle est associée une instanciation
      /// </summary>
      /// <param name="nom"></param>
      /// <returns></returns>
      public Participation InstancierParticipation(string nom) =>
         DictionnaireParticipation[nom]();

      public List<string> ListeDesChoix =>
         DictionnaireParticipation.Keys.ToList();
   }

}
