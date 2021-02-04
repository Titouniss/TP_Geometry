using System;

namespace Cours_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(14, 20);
            R1.GetNumero();

            Rectangle R2 = new Rectangle(15, 2);
            R2.SetOrigine_x(2);
            R2.SetOrigine_y(2);
            R2.GetNumero();

            Rectangle R3 = new Rectangle(14, 20);
            R3.SetOrigine_x(1);
            R3.SetOrigine_y(1);
            R3.GetNumero();

            Rectangle R4 = new Rectangle(7, 10);
            R4.GetNumero();

            Geometrie G1 = new Geometrie("espace 1");
            G1.ajouterLRectangle(R1);
            G1.ajouterLRectangle(R2);
            G1.ajouterLRectangle(R3);
            G1.ajouterLRectangle(R4);

            G1.ajouterDRectangle(R1);
            G1.ajouterDRectangle(R2);
            G1.ajouterDRectangle(R3);
            G1.ajouterDRectangle(R4);

            G1.suppLRectangle(R1);
            G1.suppDRectangle(R1);
            

            





        }
    }
}
