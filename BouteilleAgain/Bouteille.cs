using BouteilleAgain.ExceptionBouteille;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouteilleAgain
{
    public class Bouteille
    {
        private bool estOuverte = false;
        private float contenuEnL;
        readonly float contenanceEnL;

        public float ContenuEnL
        {
            get => contenuEnL;
            private set 
            { 
                if (value < 0) 
                {
                    throw new ValueLessThanZero("La valeur doit être superieur à 0");
                }
                else
                {
                    contenuEnL = value;
                }
            }
        }

        public bool EstOuverte { get => estOuverte; private set => estOuverte = value; }

        public Bouteille()
        {
            EstOuverte=false;
            contenuEnL = 0;
            contenanceEnL = 50;
        }

        public Bouteille(bool estOuverte, float contenuEnL, float contenanceEnL)
        {
            if (contenuEnL <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ContenuEnL));
            }

            if (contenanceEnL < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(contenanceEnL));
            }


            if (contenuEnL > contenanceEnL)
            {
                throw new BouteilleContenantInferieurAContenue("Le contenu ne peu pas être superieur au contenant");
            }


            this.EstOuverte = estOuverte;
            this.ContenuEnL = contenuEnL;
            this.contenanceEnL = contenanceEnL;
        }

        public bool Open()
        {
            if(this.EstOuverte != true) 
            {
                EstOuverte = true;
                return true;
            }
            return false;
        }

        public bool Close()
        {
            if (this.EstOuverte != false) 
            {
                EstOuverte = false;
                return true;
            }
            return false;
        }

        public bool Remplire(float quantiteAAjouter)
        {
            if(quantiteAAjouter < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantiteAAjouter));
            }

            if (ContenuEnL + quantiteAAjouter <= contenanceEnL && EstOuverte == true && quantiteAAjouter > 0)
            {
                ContenuEnL += quantiteAAjouter;
                return true;
            }
            return false;
        }

        public bool Vider(float quantiteARetirer)
        {
            if (quantiteARetirer < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantiteARetirer));
            }
            if (ContenuEnL - quantiteARetirer >= 0 && EstOuverte == true && quantiteARetirer > 0)
            {
                ContenuEnL -= quantiteARetirer;
                return true;
            }
            return false;
        }
    }
}
