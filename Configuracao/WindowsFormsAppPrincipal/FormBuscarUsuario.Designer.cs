namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarUsuario
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAlterarUsuario = new System.Windows.Forms.Button();
            this.buttonAdicionarUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirGrupo = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupo = new System.Windows.Forms.Button();
            this.radioButton1PorNome = new System.Windows.Forms.RadioButton();
            this.radioButton2PorID = new System.Windows.Forms.RadioButton();
            this.radioButton3Todos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(671, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonbuscar.Location = new System.Drawing.Point(689, 36);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonbuscar.TabIndex = 1;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 64);
            this.usuarioDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuarioDataGridView.MultiSelect = false;
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(995, 351);
            this.usuarioDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDUsuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome de usuário";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 137;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn4.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 170;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.usuarioBindingSource;
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(1012, 64);
            this.grupoUsuariosDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersWidth = 51;
            this.grupoUsuariosDataGridView.RowTemplate.Height = 24;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(300, 351);
            this.grupoUsuariosDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grupos do usuário";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // buttonAlterarUsuario
            // 
            this.buttonAlterarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarUsuario.Location = new System.Drawing.Point(771, 34);
            this.buttonAlterarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarUsuario.Name = "buttonAlterarUsuario";
            this.buttonAlterarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarUsuario.TabIndex = 5;
            this.buttonAlterarUsuario.Text = "Alterar";
            this.buttonAlterarUsuario.UseVisualStyleBackColor = true;
            this.buttonAlterarUsuario.Click += new System.EventHandler(this.buttonAlterarUsuario_Click);
            // 
            // buttonAdicionarUsuario
            // 
            this.buttonAdicionarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarUsuario.Location = new System.Drawing.Point(851, 34);
            this.buttonAdicionarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarUsuario.Name = "buttonAdicionarUsuario";
            this.buttonAdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarUsuario.TabIndex = 6;
            this.buttonAdicionarUsuario.Text = "Adicionar";
            this.buttonAdicionarUsuario.UseVisualStyleBackColor = true;
            this.buttonAdicionarUsuario.Click += new System.EventHandler(this.buttonAdicionarUsuario_Click);
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(931, 34);
            this.buttonExcluirUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirUsuario.TabIndex = 7;
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = true;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluirUsuario_Click);
            // 
            // buttonExcluirGrupo
            // 
            this.buttonExcluirGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirGrupo.Location = new System.Drawing.Point(1237, 34);
            this.buttonExcluirGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirGrupo.Name = "buttonExcluirGrupo";
            this.buttonExcluirGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirGrupo.TabIndex = 9;
            this.buttonExcluirGrupo.Text = "Excluir";
            this.buttonExcluirGrupo.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarGrupo
            // 
            this.buttonAdicionarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarGrupo.Location = new System.Drawing.Point(1156, 34);
            this.buttonAdicionarGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarGrupo.Name = "buttonAdicionarGrupo";
            this.buttonAdicionarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarGrupo.TabIndex = 8;
            this.buttonAdicionarGrupo.Text = "Adicionar";
            this.buttonAdicionarGrupo.UseVisualStyleBackColor = true;
            this.buttonAdicionarGrupo.Click += new System.EventHandler(this.buttonAdicionarGrupo_Click);
            // 
            // radioButton1PorNome
            // 
            this.radioButton1PorNome.AutoSize = true;
            this.radioButton1PorNome.Location = new System.Drawing.Point(12, 9);
            this.radioButton1PorNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1PorNome.Name = "radioButton1PorNome";
            this.radioButton1PorNome.Size = new System.Drawing.Size(133, 20);
            this.radioButton1PorNome.TabIndex = 10;
            this.radioButton1PorNome.TabStop = true;
            this.radioButton1PorNome.Text = "Buscar por Nome";
            this.radioButton1PorNome.UseVisualStyleBackColor = true;
            // 
            // radioButton2PorID
            // 
            this.radioButton2PorID.AutoSize = true;
            this.radioButton2PorID.Location = new System.Drawing.Point(284, 9);
            this.radioButton2PorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2PorID.Name = "radioButton2PorID";
            this.radioButton2PorID.Size = new System.Drawing.Size(109, 20);
            this.radioButton2PorID.TabIndex = 11;
            this.radioButton2PorID.TabStop = true;
            this.radioButton2PorID.Text = "Buscar por ID";
            this.radioButton2PorID.UseVisualStyleBackColor = true;
            // 
            // radioButton3Todos
            // 
            this.radioButton3Todos.AutoSize = true;
            this.radioButton3Todos.Location = new System.Drawing.Point(563, 9);
            this.radioButton3Todos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3Todos.Name = "radioButton3Todos";
            this.radioButton3Todos.Size = new System.Drawing.Size(113, 20);
            this.radioButton3Todos.TabIndex = 12;
            this.radioButton3Todos.TabStop = true;
            this.radioButton3Todos.Text = "Buscar Todos";
            this.radioButton3Todos.UseVisualStyleBackColor = true;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 426);
            this.Controls.Add(this.radioButton3Todos);
            this.Controls.Add(this.radioButton2PorID);
            this.Controls.Add(this.radioButton1PorNome);
            this.Controls.Add(this.buttonExcluirGrupo);
            this.Controls.Add(this.buttonAdicionarGrupo);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonAdicionarUsuario);
            this.Controls.Add(this.buttonAlterarUsuario);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button buttonAlterarUsuario;
        private System.Windows.Forms.Button buttonAdicionarUsuario;
        private System.Windows.Forms.Button buttonExcluirUsuario;
        private System.Windows.Forms.Button buttonExcluirGrupo;
        private System.Windows.Forms.Button buttonAdicionarGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.RadioButton radioButton1PorNome;
        private System.Windows.Forms.RadioButton radioButton2PorID;
        private System.Windows.Forms.RadioButton radioButton3Todos;
    }
}