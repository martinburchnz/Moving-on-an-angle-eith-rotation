namespace _2018_Lists_Tutorial
{
    partial class FrmRotate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrPlanets = new System.Windows.Forms.Timer(this.components);
            this.lblRotationangle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrShoot
            // 
            this.tmrShoot.Enabled = true;
            this.tmrShoot.Interval = 1;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrPlanets
            // 
            this.tmrPlanets.Enabled = true;
            this.tmrPlanets.Interval = 10;
            this.tmrPlanets.Tick += new System.EventHandler(this.tmrPlanets_Tick);
            // 
            // lblRotationangle
            // 
            this.lblRotationangle.AutoSize = true;
            this.lblRotationangle.Location = new System.Drawing.Point(486, 257);
            this.lblRotationangle.Name = "lblRotationangle";
            this.lblRotationangle.Size = new System.Drawing.Size(35, 13);
            this.lblRotationangle.TabIndex = 0;
            this.lblRotationangle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 469);
            this.Controls.Add(this.lblRotationangle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Timer tmrPlanets;
        private System.Windows.Forms.Label lblRotationangle;
    }
}

