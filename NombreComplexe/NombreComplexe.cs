using System;

namespace NombreComplexe
{
    public class NombreComplexe: IEquatable<NombreComplexe>
    {
        #region Champs et propriétés
        private double reel;
        public double Reel
        {
            get { return reel; }
            set { reel = value; }
        }

        private double imaginaire;
        public double Imaginaire
        {
            get { return imaginaire; }
            set { imaginaire = value; }
        }

        #endregion Champs et propriétés

        #region Constructeur

        public NombreComplexe(double reel = 0, double imaginaire = 0)
        {
            this.reel = reel;
            this.imaginaire = imaginaire;
        }

        #endregion Constructeur

        #region méthode ToString()

        public override string ToString()
        {
            if (imaginaire > 1)
            {
                if (reel == 0)
                    return $"{imaginaire}i";
                else
                {
                    return $"{reel} + {imaginaire}i";
                }
            }
            else if (imaginaire == 1)
            {
                if (reel == 0)
                    return $"i";
                else
                {
                    return $"{reel} + i";
                }
            }
            else if (imaginaire == 0)
            {
                return $"{reel}";
            }
            else if (imaginaire < 0)
            {
                if (imaginaire != -1)
                {
                    if (reel == 0)
                        return $"{imaginaire}i";
                    else
                    {
                        return $"{reel} - {imaginaire * -1}i";
                    }
                }
                else
                {
                    if (reel == 0)
                        return $"-i";
                    else
                    {
                        return $"{reel} - i";
                    }
                }
            }

            return $"{reel} + {imaginaire}i";
        }

        #endregion méthode ToString()

        #region Opérateurs unaires

        public static NombreComplexe operator -(NombreComplexe nb)
        {
            NombreComplexe nbre = new NombreComplexe(nb.reel, nb.imaginaire);
            nbre.reel *= -1;
            nbre.imaginaire *= -1;
            return nbre;
        }

        public static NombreComplexe operator +(NombreComplexe nb)
        {
            return nb;
        }

        public static NombreComplexe operator ++(NombreComplexe nb)
        {
            return nb + 1;
        }

        public static NombreComplexe operator --(NombreComplexe nb)
        {
            return nb - 1;
        }

        #endregion Opérateurs unaires

        #region Opérateurs arithmétiques

        public static NombreComplexe operator +(NombreComplexe nb1, NombreComplexe nb2)
        {
            NombreComplexe somme = new NombreComplexe();
            somme.reel = nb1.reel + nb2.reel;
            somme.imaginaire = nb1.imaginaire + nb2.imaginaire;
            return somme;
        }

        public static NombreComplexe operator +(double nb, NombreComplexe complex)
        {
            NombreComplexe somme = new NombreComplexe();
            somme.reel = nb + complex.reel;
            somme.imaginaire = complex.imaginaire;
            return somme;
        }

        public static NombreComplexe operator +(NombreComplexe complex, double nb)
        {
            return nb + complex;
        }

        public static NombreComplexe operator -(NombreComplexe nb1, NombreComplexe nb2)
        {
            NombreComplexe difference = new NombreComplexe();
            difference.reel = nb1.reel - nb2.reel;
            difference.imaginaire = nb1.imaginaire - nb2.imaginaire;
            return difference;
        }

        public static NombreComplexe operator -(NombreComplexe complex, double nb)
        {
            NombreComplexe différence = new NombreComplexe();
            différence.reel = complex.reel - nb;
            différence.imaginaire = complex.imaginaire;
            return différence;
        }

        public static NombreComplexe operator -(double nb, NombreComplexe complex)
        {
            return -(complex - nb);
        }

        public static NombreComplexe operator *(NombreComplexe nb1, NombreComplexe nb2)
        {
            NombreComplexe produit = new NombreComplexe();
            produit.reel = nb1.reel * nb2.reel - nb1.imaginaire * nb2.imaginaire;
            produit.imaginaire = nb1.reel * nb2.imaginaire + nb1.imaginaire * nb2.reel;
            return produit;
        }

        public static NombreComplexe operator *(double nb, NombreComplexe complex)
        {
            NombreComplexe multiple = new NombreComplexe();
            multiple.reel = nb * complex.reel;
            multiple.imaginaire = nb * complex.imaginaire;
            return multiple;
        }

        public static NombreComplexe operator *(NombreComplexe complex, double nb)
        {
            return nb * complex;
        }

        public static NombreComplexe operator /(NombreComplexe complex, double nb)
        {
            return (1 / nb) * complex;
        }

        public static NombreComplexe operator /(double nb, NombreComplexe complex)
        {
            NombreComplexe quotient = new NombreComplexe();
            double dénominateur = Math.Pow(complex.reel, 2) + Math.Pow(complex.imaginaire, 2);
            quotient = nb * complex.Conjuguer();
            quotient = quotient / dénominateur;
            return quotient;
        }

        public static NombreComplexe operator /(NombreComplexe nb1, NombreComplexe nb2)
        {
            NombreComplexe quotient = new NombreComplexe();
            double dénominateur = Math.Pow(nb2.reel, 2) + Math.Pow(nb2.imaginaire, 2);
            quotient = nb1 * nb2.Conjuguer();
            quotient = quotient / dénominateur;
            return quotient;
        }


        #endregion Opérateurs arithmétiques
     
        #region  Opérateurs de comparaison

         public static bool operator==(NombreComplexe nb1, NombreComplexe nb2)
        {
            if(nb1.reel == nb2.reel && nb1.imaginaire == nb2.imaginaire)
            {
                return true;
            }
            return false;
        }

        public static bool operator!=(NombreComplexe nb1, NombreComplexe nb2)
        {
            if(nb1 == nb2)
            {
                return false;
            }
            return true;
        }

        public static bool operator<(NombreComplexe nb1, NombreComplexe nb2)
        {
            if (VerifierComparable(nb1, nb2))
            {
                return nb1.reel < nb2.reel;
            }
            return false;
        }

        public static bool operator>(NombreComplexe nb1, NombreComplexe nb2)
        {
            if (VerifierComparable(nb1, nb2))
            {
                if (nb1 < nb2 || nb1 == nb2)
                    return false;
            }
            return true;
        }

        public static bool operator<=(NombreComplexe nb1, NombreComplexe nb2)
        {
            if (VerifierComparable(nb1, nb2))
            {
                if (nb1 > nb2)
                    return false;
            }
            return true;
        }

        public static bool operator>=(NombreComplexe nb1, NombreComplexe nb2)
        {
            if(VerifierComparable(nb1, nb2))
            {
                if (nb1 < nb2)
                    return false;
            }
            return true;
        }

        private static bool VerifierComparable(NombreComplexe nb1, NombreComplexe nb2)
        {
            bool comparable = true;
            if (nb1.imaginaire != 0 || nb2.imaginaire != 0)
            {
                comparable = false;
                throw (new OrdreImaginaireException("Le corp des complexes C n'est ordonné que sur sa partie" +
                " réélle, donc les éléments qui ont une partie imaginaire ne sont pas comparables"));
            }
            return comparable;
            
        }

        #endregion Opérateurs de comparaison

        #region Autres opérations

        public NombreComplexe Conjuguer()
        {
            NombreComplexe conjugué = new NombreComplexe();
            conjugué.reel = this.reel;
            conjugué.imaginaire = this.imaginaire * -1;
            return conjugué;
        }

        public string NotationTrigonométrique()
        {
            double module = Math.Sqrt(Math.Pow(reel, 2) + Math.Pow(imaginaire, 2)); 
            double argument = 0;
            if(reel > 0 && imaginaire > 0)
            {
                argument = Math.Atan(imaginaire/reel);
                argument = argument * 180 / Math.PI;
            }
            else if (reel < 0 && imaginaire > 0)
            {
                argument = Math.PI - Math.Atan(imaginaire / reel * -1);
                argument = argument * 180 / Math.PI;
            }
            else if (reel < 0 && imaginaire < 0)
            {
                argument = (3 * Math.PI / 2) - Math.Atan(imaginaire / reel);
                argument = argument * 180 / Math.PI;
            }
            else if (reel > 0 && imaginaire < 0)
            {
                argument = (2 * Math.PI) - Math.Atan(imaginaire * -1 / reel);
                argument = argument * 180 / Math.PI;
            }
            else if(reel == 0 && imaginaire == 0)
            {
                return "0";
            }
            else if (reel == 0)
            {
                if(imaginaire > 0)
                {
                    argument = 90;
                }
                else
                {
                    argument = 270;
                }
            }
            else if (imaginaire == 0)
            {
                if(reel > 0)
                {
                    argument = 0;
                }
                else
                {
                    argument = 180;
                }
            }

            return $"{module}[Cos({argument}°) +iSin({argument})°]";
        }

        public bool Equals(NombreComplexe? other)
        {
            if(other is null){
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            return (this.reel == other.Reel) && (this.imaginaire == other.Imaginaire);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion Autres opérations
    }
}

