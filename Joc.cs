using System;

namespace Ludo_Now
{
    class Joc
    {
        private Dice Zar;
        private Piesa Piece1;
        private Piesa Piece2;
        private Piesa Piece3;
        private Piesa Piece4;
        public Joc()
        { }
        public Joc(Dice Zar,Piesa Piece1,Piesa Piece2,Piesa Piece3,Piesa Piece4)
        {
            this.Zar = Zar;
            this.Piece1 = Piece1;
            this.Piece2 = Piece2;
            this.Piece3 = Piece3;
            this.Piece4 = Piece4;
        }
        public void CineCastiga()
        {
            if (Piece1.Numar == 0 && Piece2.Numar == 0 && Piece3.Numar == 0 && Piece4.Numar == 0)
            {
                if (Piece1.color.Equals("galben"))
                {
                    Console.WriteLine("Galben a castigat");
                    Environment.Exit(0);
                }
                if (Piece1.color.Equals("verde"))
                {
                    Console.WriteLine("Verde a castigat");
                    Environment.Exit(0);
                }
                if (Piece1.color.Equals("albastru"))
                {
                    Console.WriteLine("Albsatru a castigat");
                    Environment.Exit(0);
                }
                if (Piece1.color.Equals("rosu"))
                {
                    Console.WriteLine("Rosu a castigat");
                    Environment.Exit(0);
                }
            }
        }
       
    }

}
