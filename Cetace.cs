using System;
using System.Collections.Generic;
using System.Text;

namespace Hypothese2
{
    class Cetace:Mammifere
    {
        protected int dureeApnee;
        protected int profondeurPlongee;
        public Cetace(int pDureeApnee,int pProfondeurPlongee, string pNom, string pLieuHabitation, string pMonCrie, bool pJeSuisDomestique) : base(pNom, pLieuHabitation, pMonCrie, pJeSuisDomestique)
        {
            dureeApnee = pDureeApnee;
            profondeurPlongee = pProfondeurPlongee;
        }
        public override void Afficher()
        {
            Console.WriteLine("Je m'appel " + base.nom + "\n" +
                "J'habite a " + base.lieuHabitation + "\n" +
                " Je suis domestique :" + base.jeSuisDomestique + " \n" +
                "Duree Apnee :" + dureeApnee + "\n" +
                " je crie " + base.monCrie + "\n" +
                "Je plonge a " + profondeurPlongee);
        }
    }
}
