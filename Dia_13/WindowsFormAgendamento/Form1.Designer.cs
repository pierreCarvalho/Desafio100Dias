namespace WindowsFormAgendamento
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
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConvenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxConvenio = new System.Windows.Forms.CheckBox();
            this.textBoxMedico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 36);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(118, 36);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Médico(a)";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(12, 93);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 20);
            this.textBoxData.TabIndex = 9;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(118, 93);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(100, 20);
            this.textBoxHora.TabIndex = 10;
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnEmail,
            this.ColumnTelefone,
            this.ColumnData,
            this.ColumnHora,
            this.ColumnMedico,
            this.ColumnConvenio});
            this.dataGridViewAgenda.Location = new System.Drawing.Point(317, 12);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.Size = new System.Drawing.Size(649, 272);
            this.dataGridViewAgenda.TabIndex = 12;
            this.dataGridViewAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 90;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 90;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.Width = 90;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.Width = 90;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.Width = 90;
            // 
            // ColumnMedico
            // 
            this.ColumnMedico.HeaderText = "Médico";
            this.ColumnMedico.Name = "ColumnMedico";
            this.ColumnMedico.Width = 90;
            // 
            // ColumnConvenio
            // 
            this.ColumnConvenio.HeaderText = "Convênio";
            this.ColumnConvenio.Name = "ColumnConvenio";
            this.ColumnConvenio.Width = 90;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(12, 260);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 13;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(224, 36);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(87, 20);
            this.textBoxEmail.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-mail";
            // 
            // checkBoxConvenio
            // 
            this.checkBoxConvenio.AutoSize = true;
            this.checkBoxConvenio.Location = new System.Drawing.Point(140, 152);
            this.checkBoxConvenio.Name = "checkBoxConvenio";
            this.checkBoxConvenio.Size = new System.Drawing.Size(71, 17);
            this.checkBoxConvenio.TabIndex = 19;
            this.checkBoxConvenio.Text = "Convênio";
            this.checkBoxConvenio.UseVisualStyleBackColor = true;
            // 
            // textBoxMedico
            // 
            this.textBoxMedico.Location = new System.Drawing.Point(12, 151);
            this.textBoxMedico.Name = "textBoxMedico";
            this.textBoxMedico.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedico.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 296);
            this.Controls.Add(this.textBoxMedico);
            this.Controls.Add(this.checkBoxConvenio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConvenio;
        private System.Windows.Forms.CheckBox checkBoxConvenio;
        private System.Windows.Forms.TextBox textBoxMedico;
    }
}

