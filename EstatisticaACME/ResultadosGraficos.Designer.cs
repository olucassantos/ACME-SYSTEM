namespace EstatisticaACME
{
    partial class ResultadosGraficos
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
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblteste = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPercentis = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblDesvio = new System.Windows.Forms.Label();
            this.lblCurtose = new System.Windows.Forms.Label();
            this.lblVariacao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::EstatisticaACME.Properties.Resources.AcmeSystems;
            this.imgLogo.Location = new System.Drawing.Point(247, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(390, 143);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // lblteste
            // 
            this.lblteste.AutoSize = true;
            this.lblteste.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteste.Location = new System.Drawing.Point(104, 3);
            this.lblteste.Name = "lblteste";
            this.lblteste.Size = new System.Drawing.Size(114, 26);
            this.lblteste.TabIndex = 9;
            this.lblteste.Text = "Resultados";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblValores);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblVariacao);
            this.panel1.Controls.Add(this.lblCurtose);
            this.panel1.Controls.Add(this.lblDesvio);
            this.panel1.Controls.Add(this.lblModa);
            this.panel1.Controls.Add(this.lblMediana);
            this.panel1.Controls.Add(this.lblMedia);
            this.panel1.Controls.Add(this.lblPercentis);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblteste);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 405);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Média: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mediana: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Moda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Desvio Padrão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Curtose:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Coeficiente de Variação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Percentil ->";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(89, 2);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(189, 30);
            this.txtEntrada.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEntrada);
            this.panel2.Location = new System.Drawing.Point(7, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 35);
            this.panel2.TabIndex = 19;
            // 
            // lblPercentis
            // 
            this.lblPercentis.AutoSize = true;
            this.lblPercentis.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentis.Location = new System.Drawing.Point(139, 369);
            this.lblPercentis.Name = "lblPercentis";
            this.lblPercentis.Size = new System.Drawing.Size(45, 35);
            this.lblPercentis.TabIndex = 20;
            this.lblPercentis.Text = "---";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(169, 76);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMedia.Size = new System.Drawing.Size(45, 35);
            this.lblMedia.TabIndex = 21;
            this.lblMedia.Text = "---";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.Location = new System.Drawing.Point(169, 117);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMediana.Size = new System.Drawing.Size(45, 35);
            this.lblMediana.TabIndex = 22;
            this.lblMediana.Text = "---";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.Location = new System.Drawing.Point(169, 158);
            this.lblModa.Name = "lblModa";
            this.lblModa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblModa.Size = new System.Drawing.Size(45, 35);
            this.lblModa.TabIndex = 23;
            this.lblModa.Text = "---";
            // 
            // lblDesvio
            // 
            this.lblDesvio.AutoSize = true;
            this.lblDesvio.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesvio.Location = new System.Drawing.Point(169, 199);
            this.lblDesvio.Name = "lblDesvio";
            this.lblDesvio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDesvio.Size = new System.Drawing.Size(45, 35);
            this.lblDesvio.TabIndex = 24;
            this.lblDesvio.Text = "---";
            // 
            // lblCurtose
            // 
            this.lblCurtose.AutoSize = true;
            this.lblCurtose.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurtose.Location = new System.Drawing.Point(169, 240);
            this.lblCurtose.Name = "lblCurtose";
            this.lblCurtose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurtose.Size = new System.Drawing.Size(45, 35);
            this.lblCurtose.TabIndex = 25;
            this.lblCurtose.Text = "---";
            // 
            // lblVariacao
            // 
            this.lblVariacao.AutoSize = true;
            this.lblVariacao.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariacao.Location = new System.Drawing.Point(169, 281);
            this.lblVariacao.Name = "lblVariacao";
            this.lblVariacao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVariacao.Size = new System.Drawing.Size(45, 35);
            this.lblVariacao.TabIndex = 26;
            this.lblVariacao.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Valores: ";
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValores.Location = new System.Drawing.Point(169, 35);
            this.lblValores.Name = "lblValores";
            this.lblValores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValores.Size = new System.Drawing.Size(45, 35);
            this.lblValores.TabIndex = 28;
            this.lblValores.Text = "---";
            // 
            // ResultadosGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultadosGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultadosGraficos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblteste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblVariacao;
        private System.Windows.Forms.Label lblCurtose;
        private System.Windows.Forms.Label lblDesvio;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label label8;
    }
}