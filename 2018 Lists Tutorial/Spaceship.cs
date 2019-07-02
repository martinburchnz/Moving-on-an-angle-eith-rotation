using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2018_Lists_Tutorial
{
    class Spaceship
    {
        public int x, y, width, height, rotationAngle;//variables for the rectangle
        public Image spaceship;//variable for the spaceship's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in
        public Matrix matrix;
        Point centre;

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 10;
            y = 350;
            width =50;
            height = 30;
            rotationAngle = 0;
            spaceship = Image.FromFile("alien1.png");
            spaceRec = new Rectangle(x, y, width, height);
        }

        public void drawSpaceship(Graphics g)
        {
            centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            matrix = new Matrix();
            matrix.RotateAt(rotationAngle, centre);
            g.Transform = matrix;
            g.DrawImage(spaceship, spaceRec);
           // g.ResetTransform();
        }

        public void moveSpaceship(int mouseX,int mouseY)
        {
            spaceRec.X = mouseX - (spaceRec.Width / 2);
            spaceRec.Y = mouseY - (spaceRec.Height / 2);
        }
        
    }
}
