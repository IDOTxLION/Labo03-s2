using System.Diagnostics;

Combinaison c = new Combinaison(7,1,50);
LottoMax q = new();
Console.WriteLine(q.ToString());
//Console.WriteLine(Yes(Combinaison.D(7,1,50)));

static string Yes(List<int> list)
{
    foreach (int n in list)
        return ($"{n} ");
    return string.Empty;
}

static class Générateur
{
    
    const int GERME = 22;

    static Random Gen { get; } = new(GERME);
    static public int Next(int min, int max = int.MaxValue)
    {
        int valeur = Gen.Next(min, max);
        return valeur;
    }
}
class Combinaison
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
       for(int i = 0; i != nbChiffres; i++)
        {
            list.Add(Générateur.Next(min,max));
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
        for(int i = 0; i < list.Count;i++)
            if (i == list.Count - 1)
                chaine += list[i].ToString();
            else
                chaine += string.Format(" {0} - ", list[i]);


        return chaine;

    }
}

class LottoMax : Combinaison
{
    public LottoMax()
        :base(7,1,50)
    { }
    
    //public override string ToString()
    //{

    //    string chaine = $"{1}";

    //    return chaine;
    //}


}
