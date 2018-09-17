namespace Dia_4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSolteiro = new System.Windows.Forms.RadioButton();
            this.radioButtonCasado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExibir = new System.Windows.Forms.TextBox();
            this.buttonExibir = new System.Windows.Forms.Button();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(9, 161);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(8, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(9, 69);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade";
            // 
            // radioButtonSolteiro
            // 
            this.radioButtonSolteiro.AutoSize = true;
            this.radioButtonSolteiro.Location = new System.Drawing.Point(7, 119);
            this.radioButtonSolteiro.Name = "radioButtonSolteiro";
            this.radioButtonSolteiro.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSolteiro.TabIndex = 5;
            this.radioButtonSolteiro.TabStop = true;
            this.radioButtonSolteiro.Text = "Solteiro";
            this.radioButtonSolteiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasado
            // 
            this.radioButtonCasado.AutoSize = true;
            this.radioButtonCasado.Location = new System.Drawing.Point(73, 119);
            this.radioButtonCasado.Name = "radioButtonCasado";
            this.radioButtonCasado.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCasado.TabIndex = 6;
            this.radioButtonCasado.TabStop = true;
            this.radioButtonCasado.Text = "Casado";
            this.radioButtonCasado.UseVisualStyleBackColor = true;
            this.radioButtonCasado.CheckedChanged += new System.EventHandler(this.radioButtonCasado_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado Civil";
            // 
            // textBoxExibir
            // 
            this.textBoxExibir.Location = new System.Drawing.Point(207, 87);
            this.textBoxExibir.Multiline = true;
            this.textBoxExibir.Name = "textBoxExibir";
            this.textBoxExibir.Size = new System.Drawing.Size(147, 97);
            this.textBoxExibir.TabIndex = 8;
            // 
            // buttonExibir
            // 
            this.buttonExibir.Location = new System.Drawing.Point(207, 53);
            this.buttonExibir.Name = "buttonExibir";
            this.buttonExibir.Size = new System.Drawing.Size(75, 23);
            this.buttonExibir.TabIndex = 9;
            this.buttonExibir.Text = "Exibir";
            this.buttonExibir.UseVisualStyleBackColor = true;
            this.buttonExibir.Click += new System.EventHandler(this.buttonExibir_Click);
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(207, 27);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(75, 20);
            this.textBoxConsulta.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome para Consulta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 209);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxConsulta);
            this.Controls.Add(this.buttonExibir);
            this.Controls.Add(this.textBoxExibir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonCasado);
            this.Controls.Add(this.radioButtonSolteiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSolteiro;
        private System.Windows.Forms.RadioButton radioButtonCasado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExibir;
        private System.Windows.Forms.Button buttonExibir;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label label4;
    }
}

