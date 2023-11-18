using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jeuDeRole
{
    public class Monstre : Entite
    {
        public Monstre(string nom) : base(nom)
        {
            this.nom = nom;
            this.pointsDeVie = 60;
            this.degatsMin = 5;
            this.degatsMax = 10;
        }
    }
}
