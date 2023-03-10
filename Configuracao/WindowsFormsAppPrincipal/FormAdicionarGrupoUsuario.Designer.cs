namespace WindowsFormsAppPrincipal
{
    partial class FormAdicionarGrupoUsuario
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
            this.buttonAddGrupo = new System.Windows.Forms.Button();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // buttonAddGrupo
            // 
            this.buttonAddGrupo.Location = new System.Drawing.Point(342, 12);
            this.buttonAddGrupo.Name = "buttonAddGrupo";
            this.buttonAddGrupo.Size = new System.Drawing.Size(75, 28);
            this.buttonAddGrupo.TabIndex = 2;
            this.buttonAddGrupo.Text = "Adicionar";
            this.buttonAddGrupo.UseVisualStyleBackColor = true;
            this.buttonAddGrupo.Click += new System.EventHandler(this.buttonAddGrupo_Click);
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(3, 20);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(70, 13);
            nomeGrupoLabel.TabIndex = 2;
            nomeGrupoLabel.Text = "Nome Grupo:";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(79, 17);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(257, 20);
            this.nomeGrupoTextBox.TabIndex = 3;
            // 
            // FormAdicionarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(438, 61);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(this.buttonAddGrupo);
            this.MaximumSize = new System.Drawing.Size(454, 100);
            this.MinimumSize = new System.Drawing.Size(454, 100);
            this.Name = "FormAdicionarGrupoUsuario";
            this.Text = "Adicionar Grupo de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.Button buttonAddGrupo;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
    }
}