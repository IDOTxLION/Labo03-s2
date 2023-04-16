// Laboratoire 03, H-2023
// 
// Programme client permettant d'instancier des participations à deux
// loteries : la LottoMax et le Tout ou rien
//
// Ces loteries sont issues d'une hiérarchie de classe dérivant
// d'une classe "Participation" qui instancie des classes dérivées
// d'une classe "Combinaison" pouvant retenir une combinaison d'une
// loterie dont le type véritable sera déterminé à la construction d'une
// classe dérivée
//
// par Pierre Prud'homme et Patrice Roy, 2022
// (retouché par Patrice Roy et Philippe Simard, 2023)
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Labo03;

// programme principal

const int MIN_PARTICIPATION = 1;
const int MAX_PARTICIPATION = 10;

FabriqueGénérale fabrique = new();


float coûtAchat;
do
{
   List<Participation> liste = new List<Participation>();
   string choixMenu = ChoisirDansMenu(fabrique);
   int nbParticipations = DemanderNbParticipations();
   coûtAchat = 0;

   for (int compteur = 0; compteur < nbParticipations; ++compteur)
   {
      Participation p = fabrique.InstancierParticipation(choixMenu);
      liste.Add(p);
      coûtAchat += p.Coût;
   }
   Afficher(choixMenu, liste, coûtAchat);
}
while (VeutContinuer());


/// <summary>
/// Affiche le billet de loterie constitué du nombre de participations 
/// désiré de l'utilisateur
/// </summary>
/// <param name="loterie">nom de la loterie que contient le billet qu'on affiche</param>
/// <param name="liste">liste des participations contenues dans ce billet</param>
/// <param name="coût">coût d'achat total du billet</param>
static void Afficher(string loterie, List<Participation> liste, float coût)
{
   Console.WriteLine($"\nBillet de {loterie}\n");
   foreach (Participation p in liste)
      Console.WriteLine(p);
   Console.WriteLine($"Ce billet coûte {coût:c2}");
   Console.WriteLine();
}

/// <summary>
/// Demande et valide la réponse de l'utilisateur à savoir s'il veut
/// continuer l'exécution du programme ou pas
/// 
/// </summary>
/// <returns>true si l'utilisateur veut continuer, false sinon</returns>
static bool EstChoixValide(char c) =>
   c == 'o' || c == 'n';
static bool EstLigneValide(string ligne) =>
   ligne != null && ligne.Length != 0 &&
   EstChoixValide(char.ToLower(ligne[0]));
static bool VeutContinuer()
{
   string ligneLue;
   do
   {
      Console.Write("Désirez-vous produire un nouveau billet (o/n) ? ");
      ligneLue = Console.ReadLine();
   }
   while (!EstLigneValide(ligneLue));
   return char.ToLower(ligneLue[0]) == 'o';
}

/// <summary>
/// Demande et valide le nombre de participations sur le billet, qui 
/// varie entre MIN_PARTICIPATION et MAX_PARTICIPATION inclusivement
/// 
/// </summary>
/// <returns>Le nombre de participation validé obtenu de l'utilisateur</returns>
static int DemanderNbParticipations()
{
   int choix;
   Console.Write($"Combien voulez-vous de participations sur le " +
                 $"billet [{MIN_PARTICIPATION}, {MAX_PARTICIPATION}] : ");
   bool choixCorrect = int.TryParse(Console.ReadLine(), out choix) &&
                       choix >= MIN_PARTICIPATION &&
                       choix <= MAX_PARTICIPATION;
   while (!choixCorrect)
   {
      Console.WriteLine(" ... votre choix est invalide; recommencez svp...");
      Console.Write($"Combien voulez-vous de participations sur le " +
              $"billet [{MIN_PARTICIPATION}, {MAX_PARTICIPATION}] : ");
      choixCorrect = int.TryParse(Console.ReadLine(), out choix) &&
                     choix >= MIN_PARTICIPATION &&
                     choix <= MAX_PARTICIPATION;

   }
   return choix;
}

/// <summary>
/// Permet de choisir une loterie parmi celles qui sont prévues dans
/// la fabrique que l'on interroge au départ.
/// 
/// </summary>
/// <returns>Une string qui représente la loterie choisie</returns>
static string ChoisirDansMenu(FabriqueGénérale fab)
{
   var liste = fab.ListeDesChoix;
   int choix;
   AfficherMenu(liste);
   Console.Write("Donnez votre choix : ");
   bool choixCorrect = int.TryParse(Console.ReadLine(), out choix) &&
                       choix >= 1 && choix <= liste.Count;

   while (!choixCorrect)
   {
      Console.WriteLine(" ... votre choix est invalide; recommencez svp...");
      AfficherMenu(liste);
      Console.Write("Donnez votre choix : ");
      choixCorrect = int.TryParse(Console.ReadLine(), out choix) &&
                     choix >= 1 && choix <= liste.Count;
   }

   return liste[choix - 1];
}

/// <summary>
/// Affiche la liste des clés obtenues de la fabrique (les choix
/// possibles au menu) et les précède d'une valeur numérique 
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="liste"></param>
static void AfficherMenu(List<string> liste)
{
   string ligne = new string('*', 60);
   Console.WriteLine(ligne);
   Console.WriteLine(" L i s t e   d e s   l o t e r i e s  ");
   Console.WriteLine(ligne);
   for (int i = 0; i != liste.Count; ++i)
      Console.WriteLine($" {i + 1}. {liste[i]}");
   Console.WriteLine(ligne);
}


