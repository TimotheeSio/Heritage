using System;

namespace Hypothese2
{
    class Felin:Mammifere
    {
        protected int nombrePattes;
        public Felin(int pNombrePattes,string pNom,string pLieuHabitation,string pMonCrie,bool pJeSuisDomestique):base(pNom,pLieuHabitation,pMonCrie,pJeSuisDomestique)
        {
            nombrePattes = pNombrePattes;
        }
      
        public override void Afficher()
        {
            Console.WriteLine("Je m'appel " + base.nom + "\n" +
                "J'habite a " + base.lieuHabitation + " \n" +
                "Je suis domestique :" + base.jeSuisDomestique + "\n" +
                " Nombre de patte :" + nombrePattes + " \n" +
                "je crie " + base.monCrie);
        }

    }
}
