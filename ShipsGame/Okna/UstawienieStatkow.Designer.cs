﻿namespace ShipsGame.Okna
{
    partial class UstawienieStatkow
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
            this.txtNazwaGracza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNazwaGracza = new System.Windows.Forms.Label();
            this.btnObrot = new System.Windows.Forms.Button();
            this.btnDalej = new System.Windows.Forms.Button();
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazwaGracza
            // 
            this.txtNazwaGracza.Location = new System.Drawing.Point(463, 172);
            this.txtNazwaGracza.Name = "txtNazwaGracza";
            this.txtNazwaGracza.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaGracza.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(493, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gracz";
            // 
            // lblNazwaGracza
            // 
            this.lblNazwaGracza.AutoSize = true;
            this.lblNazwaGracza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaGracza.ForeColor = System.Drawing.Color.Red;
            this.lblNazwaGracza.Location = new System.Drawing.Point(448, 216);
            this.lblNazwaGracza.Name = "lblNazwaGracza";
            this.lblNazwaGracza.Size = new System.Drawing.Size(130, 15);
            this.lblNazwaGracza.TabIndex = 3;
            this.lblNazwaGracza.Text = "Podaj swoją nazwę";
            // 
            // btnObrot
            // 
            this.btnObrot.Location = new System.Drawing.Point(476, 253);
            this.btnObrot.Name = "btnObrot";
            this.btnObrot.Size = new System.Drawing.Size(75, 23);
            this.btnObrot.TabIndex = 4;
            this.btnObrot.Text = "Obróć";
            this.btnObrot.UseVisualStyleBackColor = true;
            this.btnObrot.Click += new System.EventHandler(this.btnObrot_Click);
            // 
            // btnDalej
            // 
            this.btnDalej.Location = new System.Drawing.Point(476, 300);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(75, 23);
            this.btnDalej.TabIndex = 5;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = true;
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(12, 38);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 0;
            this.planszaGracza.TabStop = false;
            this.planszaGracza.MouseMove += new System.Windows.Forms.MouseEventHandler(this.planszaGracza_MouseMove);
            // 
            // UstawienieStatkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.btnObrot);
            this.Controls.Add(this.lblNazwaGracza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaGracza);
            this.Controls.Add(this.planszaGracza);
            this.Name = "UstawienieStatkow";
            this.Text = "Ustawienie Statków";
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.TextBox txtNazwaGracza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazwaGracza;
        private System.Windows.Forms.Button btnObrot;
        private System.Windows.Forms.Button btnDalej;
    }
}