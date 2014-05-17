namespace EstatisticaACME
{
    partial class InsercaoDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsercaoDados));
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.rdoContinua = new System.Windows.Forms.RadioButton();
            this.rdoDiscreta = new System.Windows.Forms.RadioButton();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblteste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(167, 316);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(550, 30);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::EstatisticaACME.Properties.Resources.AcmeSystems;
            this.imgLogo.Location = new System.Drawing.Point(247, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(390, 143);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // rdoContinua
            // 
            this.rdoContinua.AutoSize = true;
            this.rdoContinua.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoContinua.Location = new System.Drawing.Point(465, 283);
            this.rdoContinua.Name = "rdoContinua";
            this.rdoContinua.Size = new System.Drawing.Size(176, 28);
            this.rdoContinua.TabIndex = 2;
            this.rdoContinua.Text = "Variavel Continua";
            this.rdoContinua.UseVisualStyleBackColor = true;
            // 
            // rdoDiscreta
            // 
            this.rdoDiscreta.AutoSize = true;
            this.rdoDiscreta.Checked = true;
            this.rdoDiscreta.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDiscreta.Location = new System.Drawing.Point(243, 283);
            this.rdoDiscreta.Name = "rdoDiscreta";
            this.rdoDiscreta.Size = new System.Drawing.Size(171, 28);
            this.rdoDiscreta.TabIndex = 3;
            this.rdoDiscreta.TabStop = true;
            this.rdoDiscreta.Text = "Variavel Discreta";
            this.rdoDiscreta.UseVisualStyleBackColor = true;
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(167, 365);
            this.txtRol.Multiline = true;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(550, 235);
            this.txtRol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inserção dos Dados";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirma.Location = new System.Drawing.Point(723, 556);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(117, 44);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(723, 316);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(81, 30);
            this.txtBox.TabIndex = 7;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // lblteste
            // 
            this.lblteste.AutoSize = true;
            this.lblteste.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteste.Location = new System.Drawing.Point(720, 293);
            this.lblteste.Name = "lblteste";
            this.lblteste.Size = new System.Drawing.Size(89, 18);
            this.lblteste.TabIndex = 8;
            this.lblteste.Text = "Teste - Valor";
            // 
            // InsercaoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.lblteste);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.rdoDiscreta);
            this.Controls.Add(this.rdoContinua);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.txtEntrada);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsercaoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserção de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.RadioButton rdoContinua;
        private System.Windows.Forms.RadioButton rdoDiscreta;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblteste;
    }
}

