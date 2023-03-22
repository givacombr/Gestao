namespace WindowsFormsAppPrincipal
{
    partial class FormAdicionarGrupo
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
            System.Windows.Forms.Label nomeGrupoLabel;
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonSalvarGrupo = new System.Windows.Forms.Button();
            this.buttonCancelarGrupo = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeGrupoLabel.Location = new System.Drawing.Point(12, 60);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(84, 16);
            nomeGrupoLabel.TabIndex = 1;
            nomeGrupoLabel.Text = "Nome Grupo";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(12, 76);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(455, 20);
            this.nomeGrupoTextBox.TabIndex = 2;
            this.nomeGrupoTextBox.TextChanged += new System.EventHandler(this.nomeGrupoTextBox_TextChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(479, 37);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Adicionar Grupo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvarGrupo
            // 
            this.buttonSalvarGrupo.Location = new System.Drawing.Point(311, 126);
            this.buttonSalvarGrupo.Name = "buttonSalvarGrupo";
            this.buttonSalvarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarGrupo.TabIndex = 4;
            this.buttonSalvarGrupo.Text = "Salvar";
            this.buttonSalvarGrupo.UseVisualStyleBackColor = true;
            this.buttonSalvarGrupo.Click += new System.EventHandler(this.buttonSalvarGrupo_Click);
            // 
            // buttonCancelarGrupo
            // 
            this.buttonCancelarGrupo.Location = new System.Drawing.Point(392, 126);
            this.buttonCancelarGrupo.Name = "buttonCancelarGrupo";
            this.buttonCancelarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarGrupo.TabIndex = 5;
            this.buttonCancelarGrupo.Text = "Cancelar";
            this.buttonCancelarGrupo.UseVisualStyleBackColor = true;
            this.buttonCancelarGrupo.Click += new System.EventHandler(this.buttonCancelarGrupo_Click);
            // 
            // FormAdicionarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 167);
            this.Controls.Add(this.buttonCancelarGrupo);
            this.Controls.Add(this.buttonSalvarGrupo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionarGrupo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Grupo";
            this.Load += new System.EventHandler(this.FormAdicionarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonSalvarGrupo;
        private System.Windows.Forms.Button buttonCancelarGrupo;
    }
}