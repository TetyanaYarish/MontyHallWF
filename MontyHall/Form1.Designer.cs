using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Drawing;

namespace MontyHall
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Door3 = new System.Windows.Forms.PictureBox();
            this.Door2 = new System.Windows.Forms.PictureBox();
            this.Door1 = new System.Windows.Forms.PictureBox();
            this.textPlayerWon = new System.Windows.Forms.TextBox();
            this.textPlayerLost = new System.Windows.Forms.TextBox();
            this.playerChoise = new System.Windows.Forms.TextBox();
            this.wellcomeMSG2 = new System.Windows.Forms.TextBox();
            this.wellcomeMSG1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Door3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door1)).BeginInit();
            this.SuspendLayout();
            // 
            // Door3
            // 
            this.Door3.Image = global::MontyHall.Properties.Resources.images;
            resources.ApplyResources(this.Door3, "Door3");
            this.Door3.Name = "Door3";
            this.Door3.TabStop = false;
            this.Door3.Click += new System.EventHandler(this.Door3_Click);
            this.Door3.DoubleClick += new System.EventHandler(this.Door3_Click);
            // 
            // Door2
            // 
            this.Door2.Image = global::MontyHall.Properties.Resources.images;
            resources.ApplyResources(this.Door2, "Door2");
            this.Door2.Name = "Door2";
            this.Door2.TabStop = false;
            this.Door2.Click += new System.EventHandler(this.Door2_Click);
            // 
            // Door1
            // 
            this.Door1.Image = global::MontyHall.Properties.Resources.images;
            resources.ApplyResources(this.Door1, "Door1");
            this.Door1.Name = "Door1";
            this.Door1.TabStop = false;
            this.Door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // textPlayerWon
            // 
            this.textPlayerWon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.textPlayerWon, "textPlayerWon");
            this.textPlayerWon.Name = "textPlayerWon";
            // 
            // textPlayerLost
            // 
            this.textPlayerLost.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.textPlayerLost, "textPlayerLost");
            this.textPlayerLost.Name = "textPlayerLost";
            // 
            // playerChoise
            // 
            this.playerChoise.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.playerChoise, "playerChoise");
            this.playerChoise.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playerChoise.Name = "playerChoise";
            // 
            // wellcomeMSG2
            // 
            this.wellcomeMSG2.BackColor = System.Drawing.Color.RosyBrown;
            this.wellcomeMSG2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.wellcomeMSG2, "wellcomeMSG2");
            this.wellcomeMSG2.Name = "wellcomeMSG2";
            // 
            // wellcomeMSG1
            // 
            this.wellcomeMSG1.BackColor = System.Drawing.Color.RosyBrown;
            this.wellcomeMSG1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.wellcomeMSG1, "wellcomeMSG1");
            this.wellcomeMSG1.Name = "wellcomeMSG1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.Door3);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.wellcomeMSG1);
            this.Controls.Add(this.wellcomeMSG2);
            this.Controls.Add(this.textPlayerWon);
            this.Controls.Add(this.textPlayerLost);
            this.Controls.Add(this.playerChoise);
            this.ForeColor = System.Drawing.Color.Olive;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            ((System.ComponentModel.ISupportInitialize)(this.Door3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Door1;
        private System.Windows.Forms.PictureBox Door2;
        private System.Windows.Forms.PictureBox Door3;
        private System.Windows.Forms.TextBox textPlayerWon;
        private System.Windows.Forms.TextBox textPlayerLost;
        private System.Windows.Forms.TextBox playerChoise;
        private System.Windows.Forms.TextBox wellcomeMSG2;
        private System.Windows.Forms.TextBox wellcomeMSG1;
    }
}

