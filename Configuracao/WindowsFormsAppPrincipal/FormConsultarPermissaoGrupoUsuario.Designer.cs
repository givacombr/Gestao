namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarPermissaoGrupoUsuario
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
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPermissao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.buttonSelecionarPermissao = new System.Windows.Forms.Button();
            this.buttonCancelarPermissao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(8, 86);
            this.permissaoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersVisible = false;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.Size = new System.Drawing.Size(674, 212);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // textBoxPermissao
            // 
            this.textBoxPermissao.Location = new System.Drawing.Point(16, 56);
            this.textBoxPermissao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPermissao.Name = "textBoxPermissao";
            this.textBoxPermissao.Size = new System.Drawing.Size(558, 22);
            this.textBoxPermissao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Permissão";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(582, 50);
            this.buttonBuscarPermissao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscarPermissao.TabIndex = 4;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionarPermissao
            // 
            this.buttonSelecionarPermissao.Location = new System.Drawing.Point(474, 306);
            this.buttonSelecionarPermissao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelecionarPermissao.Name = "buttonSelecionarPermissao";
            this.buttonSelecionarPermissao.Size = new System.Drawing.Size(100, 28);
            this.buttonSelecionarPermissao.TabIndex = 5;
            this.buttonSelecionarPermissao.Text = "Selecionar";
            this.buttonSelecionarPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarPermissao
            // 
            this.buttonCancelarPermissao.Location = new System.Drawing.Point(582, 306);
            this.buttonCancelarPermissao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelarPermissao.Name = "buttonCancelarPermissao";
            this.buttonCancelarPermissao.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelarPermissao.TabIndex = 6;
            this.buttonCancelarPermissao.Text = "Cancelar";
            this.buttonCancelarPermissao.UseVisualStyleBackColor = true;
            // 
            // FormConsultarPermissaoGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 347);
            this.Controls.Add(this.buttonCancelarPermissao);
            this.Controls.Add(this.buttonSelecionarPermissao);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPermissao);
            this.Controls.Add(this.permissaoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarPermissaoGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Permissao Grupo Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox textBoxPermissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.Button buttonSelecionarPermissao;
        private System.Windows.Forms.Button buttonCancelarPermissao;
    }
}