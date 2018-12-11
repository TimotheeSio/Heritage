using System;

namespace Hypothese2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammifere[] mammifere = {new Chat(4,"Chat","maison","Miaou",true),new Lion(4,"Lion","savane","grrrr",false),new Felin(4,"Felin","maison","rr",true)};
         
        
            for(int i = 0; i < mammifere.Length; i++)
            {

                Console.WriteLine("\n");
                mammifere[i].Afficher();
            }
            Console.ReadKey(true);
           
        }
    }
}
