using System;
using System.Collections.Generic;
using System.Text;

namespace Hypothese2
{
    class Lion:Felin
    {
        public Lion(int pNombrePattes, string pNom, string pLieuHabitation, string pMonCrie, bool pJeSuisDomestique):base(pNombrePattes, pNom, pLieuHabitation, pMonCrie, pJeSuisDomestique)
        {

        }
        public override void Afficher()
        {
            Console.WriteLine("Je m'appel "+base.nom+"\n" +
                "J'habite a "+ base.lieuHabitation+"\n" +
                " Je suis domestique :" +base.jeSuisDomestique +"\n" +
                " Nombre de patte :" +base.nombrePattes+" \n" +
                "je crie "+ base.monCrie);
        }
    }
}
