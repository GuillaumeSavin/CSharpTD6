using System;
using System.Collections.Generic;

namespace Exo1
{
    public class Contrôleur
    {
        private String _nom;
        private String _lieu;
        private int _nbMachines;
        private int _maxTempFound;
        private List<Machine> _managedMachines;

        public Contrôleur(String pNom, String pLieu)
        {
            this._nom = pNom;
            this._lieu = pLieu;
            this._nbMachines = 0;
            this._maxTempFound = 0;
            this._managedMachines = new List<Machine>();
        }
        
        
    }
}