namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroFornecedor
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label siteLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            siteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(4, 57);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(7, 73);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(584, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(4, 99);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(7, 115);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(258, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(268, 99);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(31, 13);
            foneLabel.TabIndex = 5;
            foneLabel.Text = "Fone";
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(271, 115);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(125, 20);
            this.foneTextBox.TabIndex = 6;
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new System.Drawing.Point(403, 96);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new System.Drawing.Size(28, 13);
            siteLabel.TabIndex = 7;
            siteLabel.Text = "Site:";
            // 
            // siteTextBox
            // 
            this.siteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Site", true));
            this.siteTextBox.Location = new System.Drawing.Point(406, 115);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(185, 20);
            this.siteTextBox.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(352, 178);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(434, 178);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluir.TabIndex = 10;
            this.buttonIncluir.Text = "&Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(516, 178);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 11;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 224);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(siteLabel);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroFornecedor";
            this.Text = "FormCadastroFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button buttonAlterar;
    }
}