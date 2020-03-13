namespace PTestClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.btnInstaciarMensalista = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInstaciarMensalistaParametros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMatricula.Location = new System.Drawing.Point(61, 30);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 17);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNome.Location = new System.Drawing.Point(61, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSalarioMensal.Location = new System.Drawing.Point(61, 107);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(101, 17);
            this.lblSalarioMensal.TabIndex = 2;
            this.lblSalarioMensal.Text = "Salario Mensal";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDataEntrada.Location = new System.Drawing.Point(61, 144);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(172, 17);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(238, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(238, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(238, 144);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrada.TabIndex = 6;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(238, 107);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMensal.TabIndex = 7;
            // 
            // btnInstaciarMensalista
            // 
            this.btnInstaciarMensalista.Location = new System.Drawing.Point(64, 212);
            this.btnInstaciarMensalista.Name = "btnInstaciarMensalista";
            this.btnInstaciarMensalista.Size = new System.Drawing.Size(113, 47);
            this.btnInstaciarMensalista.TabIndex = 8;
            this.btnInstaciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstaciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstaciarMensalista.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInstaciarMensalistaParametros
            // 
            this.btnInstaciarMensalistaParametros.Location = new System.Drawing.Point(238, 212);
            this.btnInstaciarMensalistaParametros.Name = "btnInstaciarMensalistaParametros";
            this.btnInstaciarMensalistaParametros.Size = new System.Drawing.Size(115, 47);
            this.btnInstaciarMensalistaParametros.TabIndex = 10;
            this.btnInstaciarMensalistaParametros.Text = "Instaciar Mensalista Passando Parametros";
            this.btnInstaciarMensalistaParametros.UseVisualStyleBackColor = true;
            this.btnInstaciarMensalistaParametros.Click += new System.EventHandler(this.btnInstaciarMensalistaParametros_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.btnInstaciarMensalistaParametros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInstaciarMensalista);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.Button btnInstaciarMensalista;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInstaciarMensalistaParametros;
    }
}