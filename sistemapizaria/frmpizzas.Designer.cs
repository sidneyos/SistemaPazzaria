namespace sistemapizaria
{
    partial class frmpizzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpizzas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgsabores = new System.Windows.Forms.DataGridView();
            this.ID_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGREDIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.txtingredientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigotamanho = new System.Windows.Forms.TextBox();
            this.txtnometamanho = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnsalvartamanho = new System.Windows.Forms.Button();
            this.btnnovotamanho = new System.Windows.Forms.Button();
            this.btnexcluirtamanho = new System.Windows.Forms.Button();
            this.dtgtamanho = new System.Windows.Forms.DataGridView();
            this.ID_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborTableAdapter1 = new sistemapizaria.sistemapizariaDataSetTableAdapters.SABORTableAdapter();
            this.tamanhoTableAdapter1 = new sistemapizaria.sistemapizariaDataSetTableAdapters.tamanhoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsabores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgsabores);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtingredientes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnexcluir);
            this.tabPage1.Controls.Add(this.btnsalvar);
            this.tabPage1.Controls.Add(this.btnnovo);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sabores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgsabores
            // 
            this.dtgsabores.AllowUserToAddRows = false;
            this.dtgsabores.AllowUserToDeleteRows = false;
            this.dtgsabores.BackgroundColor = System.Drawing.Color.White;
            this.dtgsabores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsabores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CODIGO,
            this.ID_NOME,
            this.INGREDIENTES});
            this.dtgsabores.Location = new System.Drawing.Point(-4, 231);
            this.dtgsabores.Name = "dtgsabores";
            this.dtgsabores.ReadOnly = true;
            this.dtgsabores.RowHeadersVisible = false;
            this.dtgsabores.Size = new System.Drawing.Size(406, 125);
            this.dtgsabores.TabIndex = 10;
            this.dtgsabores.DoubleClick += new System.EventHandler(this.dtgsabores_DoubleClick);
            // 
            // ID_CODIGO
            // 
            this.ID_CODIGO.HeaderText = "Código";
            this.ID_CODIGO.Name = "ID_CODIGO";
            this.ID_CODIGO.ReadOnly = true;
            this.ID_CODIGO.Width = 50;
            // 
            // ID_NOME
            // 
            this.ID_NOME.HeaderText = "Nome";
            this.ID_NOME.Name = "ID_NOME";
            this.ID_NOME.ReadOnly = true;
            this.ID_NOME.Width = 150;
            // 
            // INGREDIENTES
            // 
            this.INGREDIENTES.HeaderText = "Ingredientes";
            this.INGREDIENTES.Name = "INGREDIENTES";
            this.INGREDIENTES.ReadOnly = true;
            this.INGREDIENTES.Width = 190;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisar);
            this.groupBox1.Controls.Add(this.txtpesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 47);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = global::sistemapizaria.Properties.Resources.xmag_search_find_export_locate_59841;
            this.btnpesquisar.Location = new System.Drawing.Point(257, 17);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 1;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(235, 21);
            this.txtpesquisa.TabIndex = 0;
            // 
            // txtingredientes
            // 
            this.txtingredientes.Location = new System.Drawing.Point(6, 89);
            this.txtingredientes.Multiline = true;
            this.txtingredientes.Name = "txtingredientes";
            this.txtingredientes.Size = new System.Drawing.Size(271, 74);
            this.txtingredientes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingredientes";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(304, 105);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(304, 63);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(304, 23);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 4;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(114, 38);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(163, 20);
            this.txtnome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(6, 38);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(84, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgtamanho);
            this.tabPage2.Controls.Add(this.btnexcluirtamanho);
            this.tabPage2.Controls.Add(this.btnnovotamanho);
            this.tabPage2.Controls.Add(this.btnsalvartamanho);
            this.tabPage2.Controls.Add(this.txtvalor);
            this.tabPage2.Controls.Add(this.txtnometamanho);
            this.tabPage2.Controls.Add(this.txtcodigotamanho);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tamanhos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor:";
            // 
            // txtcodigotamanho
            // 
            this.txtcodigotamanho.Location = new System.Drawing.Point(68, 18);
            this.txtcodigotamanho.Name = "txtcodigotamanho";
            this.txtcodigotamanho.Size = new System.Drawing.Size(76, 20);
            this.txtcodigotamanho.TabIndex = 1;
            // 
            // txtnometamanho
            // 
            this.txtnometamanho.Location = new System.Drawing.Point(68, 48);
            this.txtnometamanho.Name = "txtnometamanho";
            this.txtnometamanho.Size = new System.Drawing.Size(216, 20);
            this.txtnometamanho.TabIndex = 1;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(68, 84);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btnsalvartamanho
            // 
            this.btnsalvartamanho.Location = new System.Drawing.Point(311, 23);
            this.btnsalvartamanho.Name = "btnsalvartamanho";
            this.btnsalvartamanho.Size = new System.Drawing.Size(75, 23);
            this.btnsalvartamanho.TabIndex = 2;
            this.btnsalvartamanho.Text = "Salvar";
            this.btnsalvartamanho.UseVisualStyleBackColor = true;
            this.btnsalvartamanho.Click += new System.EventHandler(this.btnsalvartamanho_Click);
            // 
            // btnnovotamanho
            // 
            this.btnnovotamanho.Location = new System.Drawing.Point(311, 52);
            this.btnnovotamanho.Name = "btnnovotamanho";
            this.btnnovotamanho.Size = new System.Drawing.Size(75, 23);
            this.btnnovotamanho.TabIndex = 2;
            this.btnnovotamanho.Text = "Novo";
            this.btnnovotamanho.UseVisualStyleBackColor = true;
            // 
            // btnexcluirtamanho
            // 
            this.btnexcluirtamanho.Location = new System.Drawing.Point(311, 81);
            this.btnexcluirtamanho.Name = "btnexcluirtamanho";
            this.btnexcluirtamanho.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirtamanho.TabIndex = 2;
            this.btnexcluirtamanho.Text = "Excluir";
            this.btnexcluirtamanho.UseVisualStyleBackColor = true;
            this.btnexcluirtamanho.Click += new System.EventHandler(this.btnexcluirtamanho_Click);
            // 
            // dtgtamanho
            // 
            this.dtgtamanho.AllowUserToAddRows = false;
            this.dtgtamanho.AllowUserToDeleteRows = false;
            this.dtgtamanho.BackgroundColor = System.Drawing.Color.White;
            this.dtgtamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtamanho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TAMANHO,
            this.NOME_TAMANHO,
            this.VALOR});
            this.dtgtamanho.Location = new System.Drawing.Point(0, 133);
            this.dtgtamanho.Name = "dtgtamanho";
            this.dtgtamanho.ReadOnly = true;
            this.dtgtamanho.RowHeadersVisible = false;
            this.dtgtamanho.Size = new System.Drawing.Size(402, 219);
            this.dtgtamanho.TabIndex = 3;
            this.dtgtamanho.DoubleClick += new System.EventHandler(this.dtgtamanho_DoubleClick);
            // 
            // ID_TAMANHO
            // 
            this.ID_TAMANHO.HeaderText = "Código";
            this.ID_TAMANHO.Name = "ID_TAMANHO";
            this.ID_TAMANHO.ReadOnly = true;
            this.ID_TAMANHO.Width = 80;
            // 
            // NOME_TAMANHO
            // 
            this.NOME_TAMANHO.HeaderText = "Nome";
            this.NOME_TAMANHO.Name = "NOME_TAMANHO";
            this.NOME_TAMANHO.ReadOnly = true;
            this.NOME_TAMANHO.Width = 220;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // saborTableAdapter1
            // 
            this.saborTableAdapter1.ClearBeforeFill = true;
            // 
            // tamanhoTableAdapter1
            // 
            this.tamanhoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmpizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 398);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpizzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE PIZZAS";
            this.Load += new System.EventHandler(this.frmpizzas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsabores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtamanho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgsabores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGREDIENTES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.TextBox txtingredientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private sistemapizariaDataSetTableAdapters.SABORTableAdapter saborTableAdapter1;
        private System.Windows.Forms.DataGridView dtgtamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Button btnexcluirtamanho;
        private System.Windows.Forms.Button btnnovotamanho;
        private System.Windows.Forms.Button btnsalvartamanho;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtnometamanho;
        private System.Windows.Forms.TextBox txtcodigotamanho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private sistemapizariaDataSetTableAdapters.tamanhoTableAdapter tamanhoTableAdapter1;
    }
}