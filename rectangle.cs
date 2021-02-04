using System;

namespace Cours_2
{
    public class Rectangle
    {
        private int longueur;
        private int largeur;
        private int origine_x;
        private int origine_y;
        private int numero;
        private static int cote = 4;
        private static int autoincrementation = 0;

        public Rectangle()
        {
            autoincrementation++;
            this.numero = autoincrementation;
        }
        public Rectangle(int lon, int lar)
        {
            this.longueur = lon;
            this.largeur = lar;
            this.origine_x = 0;
            this.origine_y = 0;
            autoincrementation++;
            this.numero = autoincrementation;
        }
        public int GetLongueur()
        {
            return this.longueur;
        }
        public int GetLargeur()
        {
            return this.largeur;
        }
        public int GetOrigine_x()
        {
            return this.origine_x;
        }
        public int GetOrigine_y()
        { 
            return this.origine_y;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetLongueur(int longueur)
        {
            this.longueur = longueur;
        }

        public void SetLargeur(int largeur)
        {
            this.largeur = largeur;
        }

        public void SetOrigine_x(int x)
        {
            this.origine_x = x;
        }

        public void SetOrigine_y(int y)
        {
            this.origine_y = y;
        }

        public static string afficherLesCotes()
        {
            return "le nombre de cotés est " + cote;
        }

        public void deplace(int x, int y)
        {
            this.origine_x += x;
            this.origine_y += y;
        }

        public int surface()
        {
            return this.longueur * this.largeur;
        }

        public string affichage()
        {
            string resultat = "la longueur est " + this.longueur;
            resultat += "  la largeur est " + this.largeur;
            resultat += "  l'origine est x :" + this.origine_x + "y:" + this.origine_y;
            resultat += "  l'identifiant est " + this.numero;
            resultat += "  le rectangle a " + cote + "côtés";
            return resultat;
        }

    }

}
