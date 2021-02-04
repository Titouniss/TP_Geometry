using System;
using System.Collections.Generic;
using System.Text;

namespace Cours_2
{
    public class Geometrie
    {
        private int autoincrementation = 0;
        private int numero;
        private string nom;
        private List<Rectangle> LRectangle;
        private Dictionary<int, Rectangle> DRectangle;

        public Geometrie()
        {
            LRectangle = new List<Rectangle>();
            DRectangle = new Dictionary<int, Rectangle>();
            autoincrementation++;
            this.numero = autoincrementation;
        }

        public Geometrie(string leNom)
        {
            LRectangle = new List<Rectangle>();
            DRectangle = new Dictionary<int, Rectangle >();
            this.nom = leNom;
            autoincrementation++;
            this.numero = autoincrementation;
        }

        public string getNom()
        {
            return this.nom;
        }

        public int getNumero()
        {
            return this.numero;
        }
        public List<Rectangle> getLRectangle()
        {
            return this.LRectangle;
        }

        public Dictionary<int, Rectangle> getDRectangle()
        {
            return this.DRectangle;
        }

        public void setNom(string leNom)
        {
            this.nom = leNom;
        }

        public void ajouterLRectangle(Rectangle leRect)
        {
            LRectangle.Add(leRect);
        }

        public void suppLRectangle(Rectangle leRect)
        {
            LRectangle.Remove(leRect);
        }
        public void ajouterDRectangle(Rectangle leRect)
        {
            this.DRectangle.Add(leRect.GetNumero(), leRect);
        }
        public void suppDRectangle(Rectangle leRect)
        {
            this.DRectangle.Remove(leRect.GetNumero());
        }

        public Rectangle obtLRectangle(int num)
        {
            return this.LRectangle[num];
        }

        public List<Rectangle> obtDRectangle(int[] tab)
        {
            List<Rectangle> Resultat = new List<Rectangle>();
            //Parcourir tab
            foreach (int element in tab )
            {
                 foreach (KeyValuePair<int, Rectangle> k in DRectangle)
                {
                    if (element == k.Key) Resultat.Add(k.Value);
                }


            }
            return Resultat;
        }
    }
}
