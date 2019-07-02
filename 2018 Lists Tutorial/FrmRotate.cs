using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_Lists_Tutorial
{
    public partial class FrmRotate : Form
    {
        //declare a list  missiles from the missile class
        List<Missile> missiles = new List<Missile>();
        List<Planet> planets = new List<Planet>();
        Graphics g; //declare a graphics object called g
        Spaceship spaceship = new Spaceship();//create object called spaceship
        string move;
        bool  turnLeft, turnRight;

        public FrmRotate()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int displacement = 10 + (i * 70);
                planets.Add(new Planet(displacement));
            }
        }
        Random i = new Random();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            g = e.Graphics;
        
            spaceship.drawSpaceship(g);
        

            foreach (Missile m in missiles)
            {
                m.draw(g);
                m.moveMissile(g);
            }
            foreach (Planet p in planets)
            {
                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet



                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.y >= ClientSize.Height)
                {
                    p.y = -20;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            spaceship.moveSpaceship(e.X,e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec,spaceship.rotationAngle));
            }
        }

        private void tmrPlanets_Tick(object sender, EventArgs e)
        {

        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Planet p in planets)
            {
               
                {
                    foreach (Missile m in missiles)
                    {
                        if (p.planetRec.IntersectsWith(m.missileRec))


                        {
                            p.y = -20;// relocate planet to the top of the form
                            missiles.Remove(m);
                            break;
                        }
                        //sort out removing missiles that exit the game area
                        //if (m.missileRec.Y > (this.ClientSize.Height) || (m.missileRec.Y < 0) || (m.missileRec.X > this.ClientSize.Width) || (m.missileRec.X < 0))
                        //{
                        //    missiles.Remove(m);
                        //}
                    }
                }
            }
            if (turnRight)
            {
                move = "right";
                spaceship.rotationAngle += 5;
              
            }
            if (turnLeft)
            {
                move = "left";
                spaceship.rotationAngle -= 5;
               
            }
            lblRotationangle.Text = spaceship.rotationAngle.ToString() ;
            if (spaceship.y > (this.ClientSize.Height - spaceship.height))
            {
                spaceship.y = this.ClientSize.Height - spaceship.height;
            }
            if (spaceship.x > (this.ClientSize.Width - spaceship.width))
            {
                spaceship.x = this.ClientSize.Width - spaceship.width;
            }
            if (spaceship.x < 0)
            {
                spaceship.x = 0;
            }
            
            this.Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
       
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        
        }
    }
}
