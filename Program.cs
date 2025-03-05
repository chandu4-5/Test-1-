#region"Arraylist"
using System.Collections;
{
    static void Main(string[] args)
    {
        // discribe an Array list();
        ArrayList obj = new ArrayList();

        // Adding elenments 
        obj.Add("NY");
        obj.Add("TX");
        obj.Add("AZ");
        obj.Add("NM");
        obj.Add("200");

        obj.Insert(4, "PA");

        obj.Sort();
        obj.Reverse();

        for (int i = 0; i < obj.Count; i++)
        {
            Console.WriteLine("At index[" + i + "]= " + obj[i].ToString());

        }
        Console.WriteLine("--------");
        Console.WriteLine("press any key");
        Console.ReadKey();
    }
}
#endregion
