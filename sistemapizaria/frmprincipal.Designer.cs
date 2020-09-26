namespace sistemapizaria
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnclientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnpedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnpizza = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomecliente = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.cbespera = new System.Windows.Forms.CheckBox();
            this.cbentregue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgpesquisas = new System.Windows.Forms.DataGridView();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SABOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_SABOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoTableAdapter1 = new sistemapizaria.sistemapizariaDataSetTableAdapters.PEDIDOTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpesquisas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnclientes,
            this.toolStripSeparator1,
            this.btnpedidos,
            this.toolStripSeparator2,
            this.btnpizza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnclientes
            // 
            this.btnclientes.Image = global::sistemapizaria.Properties.Resources.User_Group_80_icon_icons_com_57247;
            this.btnclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnclientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(53, 51);
            this.btnclientes.Text = "Clientes";
            this.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnpedidos
            // 
            this.btnpedidos.Image = global::sistemapizaria.Properties.Resources.Actions_document_edit_icon__1_;
            this.btnpedidos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnpedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpedidos.Name = "btnpedidos";
            this.btnpedidos.Size = new System.Drawing.Size(53, 51);
            this.btnpedidos.Text = "Pedidos";
            this.btnpedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpedidos.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnpizza
            // 
            this.btnpizza.Image = global::sistemapizaria.Properties.Resources.Pizza_icon_icons_com_68706;
            this.btnpizza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnpizza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpizza.Name = "btnpizza";
            this.btnpizza.Size = new System.Drawing.Size(42, 51);
            this.btnpizza.Text = "Pizzas";
            this.btnpizza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpizza.Click += new System.EventHandler(this.btnpizza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnomecliente);
            this.groupBox1.Controls.Add(this.btnpesquisar);
            this.groupBox1.Controls.Add(this.cbespera);
            this.groupBox1.Controls.Add(this.cbentregue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busque o pedido pelo nome do cliente:";
            // 
            // txtnomecliente
            // 
            this.txtnomecliente.Location = new System.Drawing.Point(385, 58);
            this.txtnomecliente.Name = "txtnomecliente";
            this.txtnomecliente.Size = new System.Drawing.Size(321, 26);
            this.txtnomecliente.TabIndex = 3;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(262, 42);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(102, 30);
            this.btnpesquisar.TabIndex = 2;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // cbespera
            // 
            this.cbespera.AutoSize = true;
            this.cbespera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbespera.Location = new System.Drawing.Point(170, 63);
            this.cbespera.Name = "cbespera";
            this.cbespera.Size = new System.Drawing.Size(74, 19);
            this.cbespera.TabIndex = 1;
            this.cbespera.Text = "A espera";
            this.cbespera.UseVisualStyleBackColor = true;
            this.cbespera.CheckedChanged += new System.EventHandler(this.cbespera_CheckedChanged);
            // 
            // cbentregue
            // 
            this.cbentregue.AutoSize = true;
            this.cbentregue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbentregue.Location = new System.Drawing.Point(170, 33);
            this.cbentregue.Name = "cbentregue";
            this.cbentregue.Size = new System.Drawing.Size(76, 19);
            this.cbentregue.TabIndex = 1;
            this.cbentregue.Text = "Entregue";
            this.cbentregue.UseVisualStyleBackColor = true;
            this.cbentregue.CheckedChanged += new System.EventHandler(this.cbentregue_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Situação do pedido:";
            // 
            // dtgpesquisas
            // 
            this.dtgpesquisas.AllowUserToAddRows = false;
            this.dtgpesquisas.AllowUserToDeleteRows = false;
            this.dtgpesquisas.AllowUserToResizeColumns = false;
            this.dtgpesquisas.AllowUserToResizeRows = false;
            this.dtgpesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpesquisas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PEDIDO,
            this.SITUACAO,
            this.ID_CLIENTE,
            this.ID_TAMANHO,
            this.ID_SABOR,
            this.ENTREGUE,
            this.NOME_CLIENTE,
            this.NOME_SABOR,
            this.NOME_TAMANHO,
            this.TOTAL});
            this.dtgpesquisas.Location = new System.Drawing.Point(22, 180);
            this.dtgpesquisas.Name = "dtgpesquisas";
            this.dtgpesquisas.ReadOnly = true;
            this.dtgpesquisas.RowHeadersVisible = false;
            this.dtgpesquisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgpesquisas.Size = new System.Drawing.Size(724, 270);
            this.dtgpesquisas.TabIndex = 2;
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.DataPropertyName = "ID_PEDIDO";
            this.ID_PEDIDO.HeaderText = "Código";
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 60;
            // 
            // SITUACAO
            // 
            this.SITUACAO.HeaderText = "Situação";
            this.SITUACAO.Name = "SITUACAO";
            this.SITUACAO.ReadOnly = true;
            this.SITUACAO.Width = 90;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            // 
            // ID_TAMANHO
            // 
            this.ID_TAMANHO.DataPropertyName = "ID_TAMANHO";
            this.ID_TAMANHO.HeaderText = "ID_TAMANHO";
            this.ID_TAMANHO.Name = "ID_TAMANHO";
            this.ID_TAMANHO.ReadOnly = true;
            this.ID_TAMANHO.Visible = false;
            // 
            // ID_SABOR
            // 
            this.ID_SABOR.DataPropertyName = "ID_SABOR";
            this.ID_SABOR.HeaderText = "ID_SABOR";
            this.ID_SABOR.Name = "ID_SABOR";
            this.ID_SABOR.ReadOnly = true;
            this.ID_SABOR.Visible = false;
            // 
            // ENTREGUE
            // 
            this.ENTREGUE.DataPropertyName = "ENTREGUE";
            this.ENTREGUE.HeaderText = "ENTREGUE";
            this.ENTREGUE.Name = "ENTREGUE";
            this.ENTREGUE.ReadOnly = true;
            this.ENTREGUE.Visible = false;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "Cliente";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 240;
            // 
            // NOME_SABOR
            // 
            this.NOME_SABOR.DataPropertyName = "NOME_SABOR";
            this.NOME_SABOR.HeaderText = "Sabor";
            this.NOME_SABOR.Name = "NOME_SABOR";
            this.NOME_SABOR.ReadOnly = true;
            this.NOME_SABOR.Width = 150;
            // 
            // NOME_TAMANHO
            // 
            this.NOME_TAMANHO.DataPropertyName = "NOME_TAMANHO";
            this.NOME_TAMANHO.HeaderText = "Tamanho";
            this.NOME_TAMANHO.Name = "NOME_TAMANHO";
            this.NOME_TAMANHO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 90;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.dtgpesquisas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE CONTROLE DE PIZARIA";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpesquisas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnclientes;
        private System.Windows.Forms.ToolStripButton btnpedidos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnpizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomecliente;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.CheckBox cbespera;
        private System.Windows.Forms.CheckBox cbentregue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgpesquisas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SABOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_SABOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private sistemapizariaDataSetTableAdapters.PEDIDOTableAdapter pedidoTableAdapter1;
    }
}

