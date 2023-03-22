namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarGrupoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBuscarGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonAlterarGrupo = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAddDescricao = new System.Windows.Forms.Button();
            this.buttonExcluirDescricao = new System.Windows.Forms.Button();
            this.radioButton1NomeGrupo = new System.Windows.Forms.RadioButton();
            this.radioButton2IDGrupo = new System.Windows.Forms.RadioButton();
            this.radioButton3ListarTodosGrupo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AllowUserToResizeRows = false;
            this.grupoUsuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(11, 57);
            this.grupoUsuarioDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grupoUsuarioDataGridView.MultiSelect = false;
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(692, 279);
            this.grupoUsuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdGrupoUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdGrupoUsuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AllowUserToResizeRows = false;
            this.permissoesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(707, 57);
            this.permissoesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(274, 279);
            this.permissoesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(11, 33);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(444, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonBuscarGrupoUsuario
            // 
            this.buttonBuscarGrupoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarGrupoUsuario.Location = new System.Drawing.Point(462, 31);
            this.buttonBuscarGrupoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarGrupoUsuario.Name = "buttonBuscarGrupoUsuario";
            this.buttonBuscarGrupoUsuario.Size = new System.Drawing.Size(56, 19);
            this.buttonBuscarGrupoUsuario.TabIndex = 4;
            this.buttonBuscarGrupoUsuario.Text = "Buscar";
            this.buttonBuscarGrupoUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarGrupoUsuario.Click += new System.EventHandler(this.buttonBuscarGrupoUsuario_Click);
            // 
            // buttonAlterarGrupo
            // 
            this.buttonAlterarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarGrupo.Location = new System.Drawing.Point(523, 31);
            this.buttonAlterarGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlterarGrupo.Name = "buttonAlterarGrupo";
            this.buttonAlterarGrupo.Size = new System.Drawing.Size(56, 19);
            this.buttonAlterarGrupo.TabIndex = 5;
            this.buttonAlterarGrupo.Text = "Alterar";
            this.buttonAlterarGrupo.UseVisualStyleBackColor = true;
            this.buttonAlterarGrupo.Click += new System.EventHandler(this.buttonAlterarGrupo_Click);
            // 
            // buttonAdicionarGrupo
            // 
            this.buttonAdicionarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarGrupo.Location = new System.Drawing.Point(584, 31);
            this.buttonAdicionarGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarGrupo.Name = "buttonAdicionarGrupo";
            this.buttonAdicionarGrupo.Size = new System.Drawing.Size(56, 19);
            this.buttonAdicionarGrupo.TabIndex = 6;
            this.buttonAdicionarGrupo.Text = "Adicionar";
            this.buttonAdicionarGrupo.UseVisualStyleBackColor = true;
            this.buttonAdicionarGrupo.Click += new System.EventHandler(this.buttonAdicionarGrupo_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(644, 31);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAddDescricao
            // 
            this.buttonAddDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDescricao.Location = new System.Drawing.Point(863, 33);
            this.buttonAddDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddDescricao.Name = "buttonAddDescricao";
            this.buttonAddDescricao.Size = new System.Drawing.Size(56, 19);
            this.buttonAddDescricao.TabIndex = 6;
            this.buttonAddDescricao.Text = "Adicionar";
            this.buttonAddDescricao.UseVisualStyleBackColor = true;
            this.buttonAddDescricao.Click += new System.EventHandler(this.buttonAddDescricao_Click);
            // 
            // buttonExcluirDescricao
            // 
            this.buttonExcluirDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirDescricao.Location = new System.Drawing.Point(924, 33);
            this.buttonExcluirDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirDescricao.Name = "buttonExcluirDescricao";
            this.buttonExcluirDescricao.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluirDescricao.TabIndex = 7;
            this.buttonExcluirDescricao.Text = "Excluir";
            this.buttonExcluirDescricao.UseVisualStyleBackColor = true;
            this.buttonExcluirDescricao.Click += new System.EventHandler(this.buttonExcluirDescricao_Click);
            // 
            // radioButton1NomeGrupo
            // 
            this.radioButton1NomeGrupo.AutoSize = true;
            this.radioButton1NomeGrupo.Location = new System.Drawing.Point(11, 11);
            this.radioButton1NomeGrupo.Name = "radioButton1NomeGrupo";
            this.radioButton1NomeGrupo.Size = new System.Drawing.Size(136, 17);
            this.radioButton1NomeGrupo.TabIndex = 8;
            this.radioButton1NomeGrupo.TabStop = true;
            this.radioButton1NomeGrupo.Text = "Buscar Nome do Grupo";
            this.radioButton1NomeGrupo.UseVisualStyleBackColor = true;
            // 
            // radioButton2IDGrupo
            // 
            this.radioButton2IDGrupo.AutoSize = true;
            this.radioButton2IDGrupo.Location = new System.Drawing.Point(153, 12);
            this.radioButton2IDGrupo.Name = "radioButton2IDGrupo";
            this.radioButton2IDGrupo.Size = new System.Drawing.Size(119, 17);
            this.radioButton2IDGrupo.TabIndex = 9;
            this.radioButton2IDGrupo.TabStop = true;
            this.radioButton2IDGrupo.Text = "Buscar ID do Grupo";
            this.radioButton2IDGrupo.UseVisualStyleBackColor = true;
            // 
            // radioButton3ListarTodosGrupo
            // 
            this.radioButton3ListarTodosGrupo.AutoSize = true;
            this.radioButton3ListarTodosGrupo.Location = new System.Drawing.Point(313, 11);
            this.radioButton3ListarTodosGrupo.Name = "radioButton3ListarTodosGrupo";
            this.radioButton3ListarTodosGrupo.Size = new System.Drawing.Size(142, 17);
            this.radioButton3ListarTodosGrupo.TabIndex = 10;
            this.radioButton3ListarTodosGrupo.TabStop = true;
            this.radioButton3ListarTodosGrupo.Text = "Buscar Todos os Grupos";
            this.radioButton3ListarTodosGrupo.UseVisualStyleBackColor = true;
            // 
            // FormBuscarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 346);
            this.Controls.Add(this.radioButton3ListarTodosGrupo);
            this.Controls.Add(this.radioButton2IDGrupo);
            this.Controls.Add(this.radioButton1NomeGrupo);
            this.Controls.Add(this.buttonExcluirDescricao);
            this.Controls.Add(this.buttonAddDescricao);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAdicionarGrupo);
            this.Controls.Add(this.buttonAlterarGrupo);
            this.Controls.Add(this.buttonBuscarGrupoUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo de usuário";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBuscarGrupoUsuario;
        private System.Windows.Forms.Button buttonAlterarGrupo;
        private System.Windows.Forms.Button buttonAdicionarGrupo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAddDescricao;
        private System.Windows.Forms.Button buttonExcluirDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.RadioButton radioButton1NomeGrupo;
        private System.Windows.Forms.RadioButton radioButton2IDGrupo;
        private System.Windows.Forms.RadioButton radioButton3ListarTodosGrupo;
    }
}