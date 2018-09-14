namespace SalaDeTestes
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.radioButtonGrif = new System.Windows.Forms.RadioButton();
            this.radioButtonCor = new System.Windows.Forms.RadioButton();
            this.radioButtonSon = new System.Windows.Forms.RadioButton();
            this.radioButtonLuf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 35);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(12, 85);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdade.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 230);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // radioButtonGrif
            // 
            this.radioButtonGrif.AutoSize = true;
            this.radioButtonGrif.Location = new System.Drawing.Point(12, 186);
            this.radioButtonGrif.Name = "radioButtonGrif";
            this.radioButtonGrif.Size = new System.Drawing.Size(66, 17);
            this.radioButtonGrif.TabIndex = 3;
            this.radioButtonGrif.TabStop = true;
            this.radioButtonGrif.Text = "Grifinoria";
            this.radioButtonGrif.UseVisualStyleBackColor = true;
            // 
            // radioButtonCor
            // 
            this.radioButtonCor.AutoSize = true;
            this.radioButtonCor.Location = new System.Drawing.Point(12, 207);
            this.radioButtonCor.Name = "radioButtonCor";
            this.radioButtonCor.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCor.TabIndex = 4;
            this.radioButtonCor.TabStop = true;
            this.radioButtonCor.Text = "Corvinal";
            this.radioButtonCor.UseVisualStyleBackColor = true;
            // 
            // radioButtonSon
            // 
            this.radioButtonSon.AutoSize = true;
            this.radioButtonSon.Location = new System.Drawing.Point(103, 186);
            this.radioButtonSon.Name = "radioButtonSon";
            this.radioButtonSon.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSon.TabIndex = 5;
            this.radioButtonSon.TabStop = true;
            this.radioButtonSon.Text = "Sonserina";
            this.radioButtonSon.UseVisualStyleBackColor = true;
            // 
            // radioButtonLuf
            // 
            this.radioButtonLuf.AutoSize = true;
            this.radioButtonLuf.Location = new System.Drawing.Point(103, 209);
            this.radioButtonLuf.Name = "radioButtonLuf";
            this.radioButtonLuf.Size = new System.Drawing.Size(70, 17);
            this.radioButtonLuf.TabIndex = 6;
            this.radioButtonLuf.TabStop = true;
            this.radioButtonLuf.Text = "Lufa-Lufa";
            this.radioButtonLuf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Idade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(12, 135);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidade.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Casa de Hogwarts";
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Location = new System.Drawing.Point(118, 9);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(397, 171);
            this.textBoxSaida.TabIndex = 12;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(93, 232);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 13;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 291);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.textBoxSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonLuf);
            this.Controls.Add(this.radioButtonSon);
            this.Controls.Add(this.radioButtonCor);
            this.Controls.Add(this.radioButtonGrif);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.RadioButton radioButtonGrif;
        private System.Windows.Forms.RadioButton radioButtonCor;
        private System.Windows.Forms.RadioButton radioButtonSon;
        private System.Windows.Forms.RadioButton radioButtonLuf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Button buttonConsultar;
    }
}

