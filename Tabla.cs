using System;
using System.Windows.Forms;

namespace Ludo_Now
{
    public partial class Tabla : Form
    {
        Dice Zar;
        Joc jocAlbastru, jocVerde;
        Piesa Piece1, Piece2, Piece3, Piece4, Piece5, Piece6, Piece7, Piece8, Piece9, Piece10, Piece11, Piece12, Piece13, Piece14, Piece15, Piece16;
        Reguli rules;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Arunca;
        public Tabla()
        {
            InitializeComponent();
            Zar = new Dice();
            rules = new Reguli(0, Rand);
            Piece1 = new Piesa("albastru", 136, 62, 1, Albastru1);
            Piece2 = new Piesa("albastru", 207, 62, 2, Albastru2);
            Piece3 = new Piesa("albastru", 136, 128, 3, Albastru3);
            Piece4 = new Piesa("albastru", 207, 128, 4, Albastru4);
            Piece5 = new Piesa("rosu", 452, 62, 1, Rosu1);
            Piece6 = new Piesa("rosu", 522, 62, 2, Rosu2);
            Piece7 = new Piesa("rosu", 452, 128, 3, Rosu3);
            Piece8 = new Piesa("rosu", 522, 128, 4, Rosu4);
            Piece9 = new Piesa("galben", 136, 383, 1, Galben1);
            Piece10 = new Piesa("galben", 207, 383, 2, Galben2);
            Piece11 = new Piesa("galben", 136, 450, 3, Galben3);
            Piece12 = new Piesa("galben", 207, 450, 4, Galben4);
            Piece13 = new Piesa("verde", 452, 383, 1, Verde1);
            Piece14 = new Piesa("verde", 522, 383, 2, Verde2);
            Piece15 = new Piesa("verde", 452, 450, 3, Verde3);
            Piece16 = new Piesa("verde", 522, 450, 4, Verde4);
            jocAlbastru = new Joc(Zar, Piece1, Piece2, Piece3, Piece4);
            jocVerde = new Joc(Zar, Piece13, Piece14, Piece15, Piece16);
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.FlatAppearance.BorderSize = 0;
        }
        private void Roll_Click(object sender, EventArgs e)
        {
            Obiect.Visible = false;
            Arunca = Zar.AruncaZarul();
            switch (Arunca)
            {
                case 1:
                    picDiceValue.Image = Properties.Resources._1;
                    break;
                case 2:
                    picDiceValue.Image = Properties.Resources._2;
                    break;
                case 3:
                    picDiceValue.Image = Properties.Resources._3;
                    break;
                case 4:
                    picDiceValue.Image = Properties.Resources._4;
                    break;
                case 5:
                    picDiceValue.Image = Properties.Resources._5;
                    break;
                case 6:
                    {
                        picDiceValue.Image = Properties.Resources._6;
                        rules.Arata6(Piece1, Piece2, Piece3, Piece4, Piece13, Piece14, Piece15, Piece16);
                    }
                    break;
            }
            rules.PermiteMutare(Arunca, Piece1, Piece2, Piece3, Piece4, Piece13, Piece14, Piece15, Piece16);
            rules.ArataMutari(Piece1);
            rules.ArataMutari(Piece2);
            rules.ArataMutari(Piece3);
            rules.ArataMutari(Piece4);
            rules.ArataMutari(Piece13);
            rules.ArataMutari(Piece14);
            rules.ArataMutari(Piece15);
            rules.ArataMutari(Piece16);
            rules.SchimbaTura(Arunca);

        }
        private void Albastru1_Click(object sender, EventArgs e)
        {
            rules.TotalAlbastru(Piece1, Piece2, Piece3, Piece4, Arunca);
            rules.PermiteScoatereVerde(Piece1, Piece13, Piece14, Piece15, Piece16);
            jocAlbastru.CineCastiga();
        }

        private void Albastru2_Click(object sender, EventArgs e)
        {
            rules.TotalAlbastru(Piece2, Piece1, Piece3, Piece4, Arunca);
            rules.PermiteScoatereVerde(Piece2, Piece13, Piece14, Piece15, Piece16);
            jocAlbastru.CineCastiga();
        }

        private void Albastru3_Click(object sender, EventArgs e)
        {
            rules.TotalAlbastru(Piece3, Piece1, Piece2, Piece4, Arunca);
            rules.PermiteScoatereVerde(Piece3, Piece13, Piece14, Piece15, Piece16);
            jocAlbastru.CineCastiga();
        }

        private void Albastru4_Click(object sender, EventArgs e)
        {
            rules.TotalAlbastru(Piece4, Piece1, Piece2, Piece3, Arunca);
            rules.PermiteScoatereVerde(Piece4, Piece13, Piece14, Piece15, Piece16);
            jocAlbastru.CineCastiga();
        }


        private void Verde1_Click(object sender, EventArgs e)
        {
            rules.TotalVerde(Piece13, Piece14, Piece15, Piece16, Arunca);
            rules.PermiteScoatereAlbastru(Piece13, Piece1, Piece2, Piece3, Piece4);
            jocVerde.CineCastiga();
        }
        private void Verde2_Click(object sender, EventArgs e)
        {
            rules.TotalVerde(Piece14, Piece13, Piece15, Piece16, Arunca);
            rules.PermiteScoatereAlbastru(Piece13, Piece1, Piece2, Piece3, Piece4);
            jocVerde.CineCastiga();
        }
        private void Verde3_Click(object sender, EventArgs e)
        {
            rules.TotalVerde(Piece15, Piece13, Piece14, Piece16, Arunca);
            rules.PermiteScoatereAlbastru(Piece13, Piece1, Piece2, Piece3, Piece4);
            jocVerde.CineCastiga();
        }

        private void Verde4_Click(object sender, EventArgs e)
        {
            rules.TotalVerde(Piece16, Piece13, Piece14, Piece15, Arunca);
            rules.PermiteScoatereAlbastru(Piece13, Piece1, Piece2, Piece3, Piece4);
            jocVerde.CineCastiga();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
