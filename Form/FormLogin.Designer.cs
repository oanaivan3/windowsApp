using System;

namespace Proiect_PAW_IvanOanaGeorgiana
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Copyright = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.pictureBoxShowParola = new System.Windows.Forms.PictureBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.buttonLogare = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxHideParola = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDenumireProiect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1Icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHideParola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 100);
            this.panel1.TabIndex = 0;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(12, 68);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(236, 19);
            this.Copyright.TabIndex = 0;
            this.Copyright.Text = "Aplicatie realizata de Oana Ivan";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonSignUp);
            this.groupBox1.Controls.Add(this.pictureBoxShowParola);
            this.groupBox1.Controls.Add(this.textBoxParola);
            this.groupBox1.Controls.Add(this.labelParola);
            this.groupBox1.Controls.Add(this.buttonLogare);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.pictureBoxHideParola);
            this.groupBox1.Location = new System.Drawing.Point(100, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logati-va pentru a putea continua";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignUp.BackColor = System.Drawing.Color.Sienna;
            this.buttonSignUp.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSignUp.Location = new System.Drawing.Point(320, 320);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(220, 103);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Inregistrare";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // pictureBoxShowParola
            // 
            this.pictureBoxShowParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShowParola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShowParola.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShowParola.Image")));
            this.pictureBoxShowParola.Location = new System.Drawing.Point(488, 234);
            this.pictureBoxShowParola.Name = "pictureBoxShowParola";
            this.pictureBoxShowParola.Size = new System.Drawing.Size(52, 28);
            this.pictureBoxShowParola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowParola.TabIndex = 4;
            this.pictureBoxShowParola.TabStop = false;
            this.pictureBoxShowParola.Click += new System.EventHandler(this.pictureBoxShowParola_Click);
            this.pictureBoxShowParola.MouseHover += new System.EventHandler(this.pictureBoxShowParola_MouseHover);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxParola.Location = new System.Drawing.Point(36, 234);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(453, 24);
            this.textBoxParola.TabIndex = 2;
            // 
            // labelParola
            // 
            this.labelParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(32, 202);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(57, 19);
            this.labelParola.TabIndex = 3;
            this.labelParola.Text = "Parola:";
            // 
            // buttonLogare
            // 
            this.buttonLogare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogare.BackColor = System.Drawing.Color.Sienna;
            this.buttonLogare.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogare.Location = new System.Drawing.Point(36, 320);
            this.buttonLogare.Name = "buttonLogare";
            this.buttonLogare.Size = new System.Drawing.Size(220, 103);
            this.buttonLogare.TabIndex = 3;
            this.buttonLogare.Text = "Logare";
            this.buttonLogare.UseVisualStyleBackColor = false;
            this.buttonLogare.Click += new System.EventHandler(this.buttonLogare_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Location = new System.Drawing.Point(36, 113);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(504, 24);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(32, 81);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(42, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Mail:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // pictureBoxHideParola
            // 
            this.pictureBoxHideParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHideParola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHideParola.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHideParola.Image")));
            this.pictureBoxHideParola.Location = new System.Drawing.Point(488, 234);
            this.pictureBoxHideParola.Name = "pictureBoxHideParola";
            this.pictureBoxHideParola.Size = new System.Drawing.Size(52, 28);
            this.pictureBoxHideParola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHideParola.TabIndex = 5;
            this.pictureBoxHideParola.TabStop = false;
            this.pictureBoxHideParola.Click += new System.EventHandler(this.pictureBoxHideParola_Click);
            this.pictureBoxHideParola.MouseHover += new System.EventHandler(this.pictureBoxHideParola_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(778, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 512);
            this.panel2.TabIndex = 0;
            // 
            // labelDenumireProiect
            // 
            this.labelDenumireProiect.AutoSize = true;
            this.labelDenumireProiect.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumireProiect.Location = new System.Drawing.Point(827, 544);
            this.labelDenumireProiect.Name = "labelDenumireProiect";
            this.labelDenumireProiect.Size = new System.Drawing.Size(167, 22);
            this.labelDenumireProiect.TabIndex = 4;
            this.labelDenumireProiect.Text = "Livrari la domiciliu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1174, 19);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 2;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.pictureBox1Minimize_MouseHover);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1214, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBox2Close_MouseHover);
            // 
            // pictureBox1Icon
            // 
            this.pictureBox1Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Icon.Image")));
            this.pictureBox1Icon.Location = new System.Drawing.Point(852, 145);
            this.pictureBox1Icon.Name = "pictureBox1Icon";
            this.pictureBox1Icon.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1Icon.TabIndex = 0;
            this.pictureBox1Icon.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.labelDenumireProiect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBox1Icon);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livrari_la_Domiciliu - Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHideParola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        // Restul codului ...

 

        // Restul codului ...

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1Icon;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button buttonLogare;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxHideParola;
        private System.Windows.Forms.PictureBox pictureBoxShowParola;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDenumireProiect;
        private System.Windows.Forms.Button buttonSignUp;
    }
}

