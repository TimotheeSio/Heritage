using System;
using System.Collections.Generic;
using System.Text;

namespace Hypothese2
{
   abstract class Mammifere
    {
        protected string nom;
        protected string lieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;
        public Mammifere(string pNom,string pLieuHabitation,string pMonCrie,bool pJeSuisDomestique)
        {
            nom = pNom;
            lieuHabitation = pLieuHabitation;
            monCrie = pMonCrie;
            jeSuisDomestique = pJeSuisDomestique;

        }
        public Mammifere()
        {
            

        }
        public bool JeSuisDangereux()
        {
            if (jeSuisDomestique == false)
                return true;
            return false;
               
        }
        public abstract void Afficher();
    }
}
