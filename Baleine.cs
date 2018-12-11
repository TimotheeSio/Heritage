using System;
using System.Collections.Generic;
using System.Text;

namespace Hypothese2
{
    class Baleine:Cetace
    {
        public Baleine(int pDureeApnee, int pProfondeurPlongee,string pNom, string pLieuHabitation, string pMonCrie, bool pJeSuisDomestique) : base(pDureeApnee,pProfondeurPlongee, pNom, pLieuHabitation, pMonCrie, pJeSuisDomestique)
        {

        }
        public override void Afficher()
        {
            Console.WriteLine("Je m'appel " + base.nom + "J'habite a " + base.lieuHabitation + " Je suis domestique :" + base.jeSuisDomestique + " Duree Apnee :" + base.dureeApnee + " je crie " + base.monCrie+ "Je plonge a "+base.profondeurPlongee);
        }
    }
}
