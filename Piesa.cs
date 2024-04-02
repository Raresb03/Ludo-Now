using System;
using System.Windows.Forms;

namespace Ludo_Now
{
    class Piesa
    {
        public int x, y;
        public String color;
        public int Numar;
        public PictureBox pic1;
        public Piesa(String color, int startX, int startY, int Numar, PictureBox pic)
        {
            this.color = color;
            x = startX;
            y = startY;
            this.Numar = Numar;
            pic1 = pic;
        }
        public void Muta(int Arunca)
        {
            while (Arunca != 0)
            {
                if (color.Equals("albastru") == true )
                {
                    if (x > 83 && x < 253 && y == 255 && Arunca != 0)
                    {
                        x += 35;
                        pic1.Location = new System.Drawing.Point(x, y);
                        Arunca--;
                    }
                    if (x == 259 && y == 255 & Arunca != 0 && Numar != 0)
                    {
                        x = 0;
                        y = 0;
                        pic1.Location = new System.Drawing.Point(x, y);
                        Numar = 0;
                        Arunca = 0;
                    }
                }
                if (color.Equals("verde") == true)
                {
                    if (x > 405 && x < 576 && y == 255 && Arunca != 0)
                    {
                        x -= 35;
                        pic1.Location = new System.Drawing.Point(x, y);
                        Arunca--;
                    }
                    if (x == 400 && y == 255 & Arunca != 0 && Numar != 0)
                    {
                        x = 0;
                        y = 0;
                        pic1.Location = new System.Drawing.Point(x, y);
                        Numar = 0;
                        Arunca = 0;
                    }

                }
                if (x == 259 && y == 219 && Arunca != 0)
                {
                    x = 294;
                    y = 184;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 364 && y == 184 && Arunca != 0)
                {
                    x = 400;
                    y = 219;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x > 82 && x < 573 && y == 219 && Arunca != 0)
                {
                    x += 35;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x > 293 && x < 364 && y == 9 && Arunca != 0)
                {
                    x += 35;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 294 && y == 327 && Arunca != 0)
                {
                    x = 259;
                    y = 291;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 294 && y > 10 && y < 504 && Arunca != 0)
                {
                    y -= 35;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 364 && y > 8 && y < 498 && Arunca != 0)
                {
                    y += 35;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 575 && y > 218 && y < 289 && Arunca != 0)
                {
                    y += 36;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 400 && y == 291 && Arunca != 0)
                {
                    x = 364;
                    y = 327;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x > 85 && x < 576 && y == 291 && Arunca != 0)
                {
                    x -= 35;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x < 365 && x > 296 && y == 502 && Arunca != 0)
                {
                    x -= 35;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }
                if (x == 84 && y > 220 && y < 292 && Arunca != 0)
                {
                    y -= 36;
                    pic1.Location = new System.Drawing.Point(x, y);
                    Arunca--;
                }

            }
        }
        public void PermitereaIesiriDinCasa(String color)
        {
            if (color.Equals("galben") == true)
            {
                this.x = 294;
                this.y = 467;
                pic1.Location = new System.Drawing.Point(x, y);
            }
            if (color.Equals("verde") == true)
            {
                this.x = 540;
                this.y = 291;
                pic1.Location = new System.Drawing.Point(x, y);
            }
            if (color.Equals("albastru") == true)
            {
                this.x = 119;
                this.y = 219;
                pic1.Location = new System.Drawing.Point(x, y);
            }
            if (color.Equals("rosu") == true)
            {
                this.x = 364;
                this.y = 43;
                pic1.Location = new System.Drawing.Point(x, y);
            }
        }

    }
}
