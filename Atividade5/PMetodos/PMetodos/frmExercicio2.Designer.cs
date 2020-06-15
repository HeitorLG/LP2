namespace PMetodos
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnInserePalavra1 = new System.Windows.Forms.Button();
            this.btnInsereAsteriscos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(12, 24);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(12, 74);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(80, 71);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 2;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(80, 24);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 3;
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(24, 134);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(98, 54);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "Testa se as palavras são iguais";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnInserePalavra1
            // 
            this.btnInserePalavra1.Location = new System.Drawing.Point(128, 134);
            this.btnInserePalavra1.Name = "btnInserePalavra1";
            this.btnInserePalavra1.Size = new System.Drawing.Size(94, 54);
            this.btnInserePalavra1.TabIndex = 5;
            this.btnInserePalavra1.Text = "Insere a Palavra 1 na Palavra 2";
            this.btnInserePalavra1.UseVisualStyleBackColor = true;
            this.btnInserePalavra1.Click += new System.EventHandler(this.btnInserePalavra1_Click);
            // 
            // btnInsereAsteriscos
            // 
            this.btnInsereAsteriscos.Location = new System.Drawing.Point(236, 134);
            this.btnInsereAsteriscos.Name = "btnInsereAsteriscos";
            this.btnInsereAsteriscos.Size = new System.Drawing.Size(96, 54);
            this.btnInsereAsteriscos.TabIndex = 6;
            this.btnInsereAsteriscos.Text = "Insere ** no meio da palavra 1";
            this.btnInsereAsteriscos.UseVisualStyleBackColor = true;
            this.btnInsereAsteriscos.Click += new System.EventHandler(this.btnInsereAsteriscos_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsereAsteriscos);
            this.Controls.Add(this.btnInserePalavra1);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.Load += new System.EventHandler(this.frmExercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnInserePalavra1;
        private System.Windows.Forms.Button btnInsereAsteriscos;
    }
}