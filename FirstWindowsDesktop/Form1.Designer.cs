namespace FirstWindowsDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.textClienteNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.MaskedTextBox();
            this.textClienteDataDascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textClienteIdade = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboClienteCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textClienteSalario = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textClienteCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboClienteEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textClienteCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textClienteLogradouro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textClienteNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvarCliente.Location = new System.Drawing.Point(227, 423);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(89, 30);
            this.btnSalvarCliente.TabIndex = 10;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(12, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Items.AddRange(new object[] {
            "Luz do quarto"});
            this.comboCliente.Location = new System.Drawing.Point(38, 40);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(225, 21);
            this.comboCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCliente.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnNovoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.Image")));
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovoCliente.Location = new System.Drawing.Point(12, 39);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(24, 23);
            this.btnNovoCliente.TabIndex = 1;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCliente.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCliente.Image")));
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(267, 39);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(24, 23);
            this.btnEditarCliente.TabIndex = 3;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCliente.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCliente.Image")));
            this.btnExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluirCliente.Location = new System.Drawing.Point(292, 39);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(24, 23);
            this.btnExcluirCliente.TabIndex = 4;
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.button5_Click);
            // 
            // textClienteNome
            // 
            this.textClienteNome.Location = new System.Drawing.Point(12, 94);
            this.textClienteNome.Name = "textClienteNome";
            this.textClienteNome.Size = new System.Drawing.Size(304, 20);
            this.textClienteNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPF:";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(12, 142);
            this.textCliente.Mask = "999.999-999-99";
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(114, 20);
            this.textCliente.TabIndex = 6;
            // 
            // textClienteDataDascimento
            // 
            this.textClienteDataDascimento.Location = new System.Drawing.Point(144, 142);
            this.textClienteDataDascimento.Mask = "99/99/9999";
            this.textClienteDataDascimento.Name = "textClienteDataDascimento";
            this.textClienteDataDascimento.Size = new System.Drawing.Size(104, 20);
            this.textClienteDataDascimento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(141, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de Nascimento:";
            // 
            // textClienteIdade
            // 
            this.textClienteIdade.Location = new System.Drawing.Point(267, 142);
            this.textClienteIdade.Name = "textClienteIdade";
            this.textClienteIdade.Size = new System.Drawing.Size(48, 20);
            this.textClienteIdade.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(265, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cargo:";
            // 
            // comboClienteCargo
            // 
            this.comboClienteCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClienteCargo.FormattingEnabled = true;
            this.comboClienteCargo.Items.AddRange(new object[] {
            "Luz do quarto"});
            this.comboClienteCargo.Location = new System.Drawing.Point(12, 217);
            this.comboClienteCargo.Name = "comboClienteCargo";
            this.comboClienteCargo.Size = new System.Drawing.Size(229, 21);
            this.comboClienteCargo.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(244, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salário:";
            // 
            // textClienteSalario
            // 
            this.textClienteSalario.Location = new System.Drawing.Point(247, 217);
            this.textClienteSalario.Mask = "9.9999,99";
            this.textClienteSalario.Name = "textClienteSalario";
            this.textClienteSalario.Size = new System.Drawing.Size(68, 20);
            this.textClienteSalario.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CEP:";
            // 
            // textClienteCEP
            // 
            this.textClienteCEP.Location = new System.Drawing.Point(12, 306);
            this.textClienteCEP.Mask = "99999-999";
            this.textClienteCEP.Name = "textClienteCEP";
            this.textClienteCEP.Size = new System.Drawing.Size(76, 20);
            this.textClienteCEP.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(109, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado:";
            // 
            // comboClienteEstado
            // 
            this.comboClienteEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClienteEstado.FormattingEnabled = true;
            this.comboClienteEstado.Items.AddRange(new object[] {
            "Luz do quarto"});
            this.comboClienteEstado.Location = new System.Drawing.Point(112, 306);
            this.comboClienteEstado.Name = "comboClienteEstado";
            this.comboClienteEstado.Size = new System.Drawing.Size(60, 21);
            this.comboClienteEstado.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(175, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cidade:";
            // 
            // textClienteCidade
            // 
            this.textClienteCidade.Location = new System.Drawing.Point(178, 307);
            this.textClienteCidade.Name = "textClienteCidade";
            this.textClienteCidade.Size = new System.Drawing.Size(137, 20);
            this.textClienteCidade.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(9, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Logradouro:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textClienteLogradouro
            // 
            this.textClienteLogradouro.Location = new System.Drawing.Point(12, 356);
            this.textClienteLogradouro.Name = "textClienteLogradouro";
            this.textClienteLogradouro.Size = new System.Drawing.Size(229, 20);
            this.textClienteLogradouro.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(248, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Número:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textClienteNumero
            // 
            this.textClienteNumero.Location = new System.Drawing.Point(251, 356);
            this.textClienteNumero.Name = "textClienteNumero";
            this.textClienteNumero.Size = new System.Drawing.Size(64, 20);
            this.textClienteNumero.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 465);
            this.Controls.Add(this.textClienteNumero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textClienteLogradouro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textClienteCidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboClienteEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textClienteCEP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textClienteSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboClienteCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textClienteIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textClienteDataDascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textClienteNome);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarCliente);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Form1";
            this.Text = "First C# Application for Windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.TextBox textClienteNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox textCliente;
        private System.Windows.Forms.MaskedTextBox textClienteDataDascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textClienteIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboClienteCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textClienteSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox textClienteCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboClienteEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textClienteCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textClienteLogradouro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textClienteNumero;
    }
}

