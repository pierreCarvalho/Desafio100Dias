namespace OrdenaçãoBSI
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
            this.buttonGerar = new System.Windows.Forms.Button();
            this.textBoxGerador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumeros = new System.Windows.Forms.TextBox();
            this.comboBoxMetodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(12, 56);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerar.TabIndex = 4;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // textBoxGerador
            // 
            this.textBoxGerador.Location = new System.Drawing.Point(13, 29);
            this.textBoxGerador.Name = "textBoxGerador";
            this.textBoxGerador.Size = new System.Drawing.Size(74, 20);
            this.textBoxGerador.TabIndex = 5;
            this.textBoxGerador.TextChanged += new System.EventHandler(this.textBoxGerador_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite quantidade de numeros:";
            // 
            // textBoxNumeros
            // 
            this.textBoxNumeros.Location = new System.Drawing.Point(237, 29);
            this.textBoxNumeros.Multiline = true;
            this.textBoxNumeros.Name = "textBoxNumeros";
            this.textBoxNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNumeros.Size = new System.Drawing.Size(104, 305);
            this.textBoxNumeros.TabIndex = 7;
            // 
            // comboBoxMetodos
            // 
            this.comboBoxMetodos.FormattingEnabled = true;
            this.comboBoxMetodos.Items.AddRange(new object[] {
            "Seleção",
            "Bolha",
            "Inserção",
            "Merge"});
            this.comboBoxMetodos.Location = new System.Drawing.Point(12, 115);
            this.comboBoxMetodos.Name = "comboBoxMetodos";
            this.comboBoxMetodos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodos.TabIndex = 8;
            this.comboBoxMetodos.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escolha o metodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numeros Ordenados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMetodos);
            this.Controls.Add(this.textBoxNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGerador);
            this.Controls.Add(this.buttonGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.TextBox textBoxGerador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeros;
        private System.Windows.Forms.ComboBox comboBoxMetodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

