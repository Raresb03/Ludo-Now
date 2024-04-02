using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_Now
{
    class Reguli : Joc
    {
        public int turn;
        public TextBox Scriere;
        public Reguli(int schimba,TextBox Scriere)
        {
            this.turn = schimba;
            this.Scriere = Scriere;
        }
        public void SchimbaTura(int Arunca)
        {
            if (Arunca != 6 && turn == 0)
            {
                turn = 1;
            }
            else if (Arunca != 6 && turn == 1)
            {
                turn = 0;
            }
        }
        public void Arata6(Piesa Piece1, Piesa Piece2, Piesa Piece3, Piesa Piece4, Piesa Piece5, Piesa Piece6, Piesa Piece7, Piesa Piece8)
        {
                if (turn == 0)
                {
                    Piece1.pic1.BorderStyle = BorderStyle.Fixed3D;
                    Piece2.pic1.BorderStyle = BorderStyle.Fixed3D;
                    Piece3.pic1.BorderStyle = BorderStyle.Fixed3D;
                    Piece4.pic1.BorderStyle = BorderStyle.Fixed3D;
                }
                else
              if (turn == 1)
                {
                    Piece5.pic1.BorderStyle = BorderStyle.Fixed3D;
                    Piece6.pic1.BorderStyle = BorderStyle.Fixed3D;
                    Piece7.pic1.BorderStyle = BorderStyle.Fixed3D;
                    Piece8.pic1.BorderStyle = BorderStyle.Fixed3D;
                }
        }
        public void ArataMutari(Piesa Piece1)
        {
            if(turn==0 && !(Piece1.x < 210 && Piece1.y < 130) && !(Piece1.x >450 && Piece1.y>380) && Piece1.color.Equals("albastru"))
            {
                Piece1.pic1.BorderStyle = BorderStyle.Fixed3D;
            }
            else
                if(turn==1 && !(Piece1.x < 210 && Piece1.y < 130) && !(Piece1.x > 450 && Piece1.y > 380) && Piece1.color.Equals("verde"))
            {
                Piece1.pic1.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public void PermiteMutare(int Arunca,Piesa Piece1,Piesa Piece2,Piesa Piece3,Piesa Piece4,Piesa Piece5,Piesa Piece6,Piesa Piece7,Piesa Piece8)
        {
            if (turn==0)
            {
                if (Arunca < 6)
                {
                    Scriere.Text += "Urmeaza Randul lui Verde" + Environment.NewLine;
                    Scriere.Select(Scriere.Text.Length - 1, Scriere.Text.Length - 1);
                    Scriere.ScrollToCaret();
                }
                else
                {
                    Scriere.Text += "Urmeaza Randul lui Albastru" + Environment.NewLine;
                    Scriere.Select(Scriere.Text.Length - 1, Scriere.Text.Length - 1);
                    Scriere.ScrollToCaret();
                }
                Piece1.pic1.Enabled = true;
                Piece2.pic1.Enabled = true;
                Piece3.pic1.Enabled = true;
                Piece4.pic1.Enabled = true;
                Piece5.pic1.Enabled = false;
                Piece6.pic1.Enabled = false;
                Piece7.pic1.Enabled = false;
                Piece8.pic1.Enabled = false;
            }
            if (turn==1)
            {
                if (Arunca < 6)
                {
                    Scriere.Text += "Urmeaza Randul lui Albastru" + Environment.NewLine;
                    Scriere.Select(Scriere.Text.Length - 1, Scriere.Text.Length - 1);
                    Scriere.ScrollToCaret();
                }
                else
                {
                    Scriere.Text += "Urmeaza Randul lui Verde" + Environment.NewLine;
                    Scriere.Select(Scriere.Text.Length - 1, Scriere.Text.Length - 1);
                    Scriere.ScrollToCaret();
                }
                Piece1.pic1.Enabled = false;
                Piece2.pic1.Enabled = false;
                Piece3.pic1.Enabled = false;
                Piece4.pic1.Enabled = false;
                Piece5.pic1.Enabled = true;
                Piece6.pic1.Enabled = true;
                Piece7.pic1.Enabled = true;
                Piece8.pic1.Enabled = true;
            }
        }
        public void PermiteScoatereAlbastru(Piesa Piece1, Piesa Piece2, Piesa Piece3, Piesa Piece4, Piesa Piece5)
        {
            if (Piece1.pic1.Location.X != 119 && Piece1.pic1.Location.Y != 219)
            {
                if (Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds)) == false)
                    {
                        Piece2.x = 136;
                        Piece2.y = 62;
                        Piece2.pic1.Location = new System.Drawing.Point(Piece2.x, Piece2.y);
                    }
                if (Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds)) == false)
                    {
                        Piece3.x = 207;
                        Piece3.y = 62;
                        Piece3.pic1.Location = new System.Drawing.Point(Piece3.x, Piece3.y);
                    }
                if (Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds)) == false)
                    {
                        Piece4.x = 136;
                        Piece4.y = 128;
                        Piece4.pic1.Location = new System.Drawing.Point(Piece4.x, Piece4.y);
                    }
                if (Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds)) == false)
                    {
                        Piece5.x = 207;
                        Piece5.y = 128;
                        Piece5.pic1.Location = new System.Drawing.Point(Piece5.x, Piece5.y);
                    }
            }
        }
        public void PermiteScoatereVerde(Piesa Piece1, Piesa Piece2, Piesa Piece3, Piesa Piece4, Piesa Piece5)
        {
            if (Piece1.pic1.Location.X != 540 && Piece1.pic1.Location.Y != 291)
            {
                if (Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds)) == false)
                    {
                        Piece2.x = 452;
                        Piece2.y = 383;
                        Piece2.pic1.Location = new System.Drawing.Point(Piece2.x, Piece2.y);
                    }
                if (Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds)) == false)
                    {
                        Piece3.x = 523;
                        Piece3.y = 383;
                        Piece3.pic1.Location = new System.Drawing.Point(Piece3.x, Piece3.y);
                    }
                if (Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds)) == false)
                    {
                        Piece4.x = 452;
                        Piece4.y = 449;
                        Piece4.pic1.Location = new System.Drawing.Point(Piece4.x, Piece4.y);
                    }
                if (Piece1.pic1.Bounds.IntersectsWith(Piece5.pic1.Bounds))
                    if ((Piece1.pic1.Bounds.IntersectsWith(Piece2.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece3.pic1.Bounds) || Piece1.pic1.Bounds.IntersectsWith(Piece4.pic1.Bounds)) == false)
                    {
                        Piece5.x = 523;
                        Piece5.y = 449;
                        Piece5.pic1.Location = new System.Drawing.Point(Piece5.x, Piece5.y);
                    }
            }
        }
        public void TotalVerde(Piesa Piece1, Piesa Piece2, Piesa Piece3, Piesa Piece4, int Arunca)
        {
            if (Arunca == 6 && Piece1.x > 450 && Piece1.y > 370)
            {
                Piece1.pic1.Visible = false;
                Piece1.PermitereaIesiriDinCasa(Piece1.color);
                Piece1.pic1.Visible = true;
            }
            else
            {
                Piece1.Muta(Arunca);
                if (Piece1.x == 0 && Piece1.y == 0)
                    Piece1.pic1.Visible = false;
                else
                    Piece1.pic1.Visible = true;
            }
            Piece1.pic1.BorderStyle = BorderStyle.None;
            Piece2.pic1.BorderStyle = BorderStyle.None;
            Piece3.pic1.BorderStyle = BorderStyle.None;
            Piece4.pic1.BorderStyle = BorderStyle.None;
        }
        public void TotalAlbastru(Piesa Piece1, Piesa Piece2, Piesa Piece3, Piesa Piece4, int Arunca)
        {
            if (Arunca == 6 && Piece1.x < 290 && Piece1.y < 211)
            {
                Piece1.pic1.Visible = false;
                Piece1.PermitereaIesiriDinCasa(Piece1.color);
                Piece1.pic1.Visible = true;
            }
            else
            {
                Piece1.Muta(Arunca);
                if (Piece1.x == 0 && Piece1.y == 0)
                    Piece1.pic1.Visible = false;
                else
                    Piece1.pic1.Visible = true;
            }
            Piece1.pic1.BorderStyle = BorderStyle.None;
            Piece2.pic1.BorderStyle = BorderStyle.None;
            Piece3.pic1.BorderStyle = BorderStyle.None;
            Piece4.pic1.BorderStyle = BorderStyle.None;
        }
    }
}
