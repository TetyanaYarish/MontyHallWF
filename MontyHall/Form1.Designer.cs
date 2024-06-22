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
            this.Door3 = new System.Windows.Forms.PictureBox();
            this.Door2 = new System.Windows.Forms.PictureBox();
            this.Door1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Door3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // Door3
            // 
            this.Door3.Image = global::MontyHall.Properties.Resources.images;
            this.Door3.Location = new System.Drawing.Point(561, 104);
            this.Door3.Name = "Door3";
            this.Door3.Size = new System.Drawing.Size(130, 284);
            this.Door3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door3.TabIndex = 3;
            this.Door3.TabStop = false;
            this.Door3.Click += new System.EventHandler(this.pictureBox4_Click);
            this.Door3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Door2_MouseClick);
            // 
            // Door2
            // 
            this.Door2.Image = global::MontyHall.Properties.Resources.Door2;
            this.Door2.Location = new System.Drawing.Point(318, 104);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(115, 284);
            this.Door2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door2.TabIndex = 2;
            this.Door2.TabStop = false;
            this.Door2.Click += new System.EventHandler(this.Door2_Click);
            this.Door2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Door2_MouseClick);
            // 
            // Door1
            // 
            this.Door1.Image = global::MontyHall.Properties.Resources.Door1;
            this.Door1.Location = new System.Drawing.Point(69, 104);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(123, 284);
            this.Door1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door1.TabIndex = 1;
            this.Door1.TabStop = false;
            this.Door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Door 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(213, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 51);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // BackGround
            // 
            this.BackGround.BackColor = System.Drawing.Color.Cyan;
            this.BackGround.Location = new System.Drawing.Point(12, -7);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(764, 461);
            this.BackGround.TabIndex = 0;
            this.BackGround.TabStop = false;
            this.BackGround.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Door3);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.BackGround);
            this.ForeColor = System.Drawing.Color.Olive;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Door3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Door1;
        private System.Windows.Forms.PictureBox Door2;
        private System.Windows.Forms.PictureBox Door3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox BackGround;
    }
}

