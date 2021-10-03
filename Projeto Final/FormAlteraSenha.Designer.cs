
namespace Projeto_Final
{
    partial class FormAlteraSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlteraSenha));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSenhaAntiga = new System.Windows.Forms.Label();
            this.lblSenhaNova = new System.Windows.Forms.Label();
            this.lblSenhaNovamente = new System.Windows.Forms.Label();
            this.txtSenhaAntiga = new System.Windows.Forms.MaskedTextBox();
            this.txtNewSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtConfirmaNewSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnAlteraSenha = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(207, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(355, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ALTERAR SENHA";
            // 
            // lblSenhaAntiga
            // 
            this.lblSenhaAntiga.AutoSize = true;
            this.lblSenhaAntiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenhaAntiga.Location = new System.Drawing.Point(198, 202);
            this.lblSenhaAntiga.Name = "lblSenhaAntiga";
            this.lblSenhaAntiga.Size = new System.Drawing.Size(110, 20);
            this.lblSenhaAntiga.TabIndex = 4;
            this.lblSenhaAntiga.Text = "Senha Antiga:";
            // 
            // lblSenhaNova
            // 
            this.lblSenhaNova.AutoSize = true;
            this.lblSenhaNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenhaNova.Location = new System.Drawing.Point(211, 237);
            this.lblSenhaNova.Name = "lblSenhaNova";
            this.lblSenhaNova.Size = new System.Drawing.Size(97, 20);
            this.lblSenhaNova.TabIndex = 6;
            this.lblSenhaNova.Text = "Nova senha:";
            // 
            // lblSenhaNovamente
            // 
            this.lblSenhaNovamente.AutoSize = true;
            this.lblSenhaNovamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenhaNovamente.Location = new System.Drawing.Point(171, 266);
            this.lblSenhaNovamente.Name = "lblSenhaNovamente";
            this.lblSenhaNovamente.Size = new System.Drawing.Size(137, 20);
            this.lblSenhaNovamente.TabIndex = 8;
            this.lblSenhaNovamente.Text = "Digite novamente:";
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenhaAntiga.Location = new System.Drawing.Point(314, 199);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.PasswordChar = '•';
            this.txtSenhaAntiga.Size = new System.Drawing.Size(234, 26);
            this.txtSenhaAntiga.TabIndex = 5;
            // 
            // txtNewSenha
            // 
            this.txtNewSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNewSenha.Location = new System.Drawing.Point(314, 231);
            this.txtNewSenha.Name = "txtNewSenha";
            this.txtNewSenha.PasswordChar = '•';
            this.txtNewSenha.Size = new System.Drawing.Size(234, 26);
            this.txtNewSenha.TabIndex = 7;
            // 
            // txtConfirmaNewSenha
            // 
            this.txtConfirmaNewSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmaNewSenha.Location = new System.Drawing.Point(314, 263);
            this.txtConfirmaNewSenha.Name = "txtConfirmaNewSenha";
            this.txtConfirmaNewSenha.PasswordChar = '•';
            this.txtConfirmaNewSenha.Size = new System.Drawing.Size(234, 26);
            this.txtConfirmaNewSenha.TabIndex = 9;
            // 
            // btnAlteraSenha
            // 
            this.btnAlteraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlteraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlteraSenha.Location = new System.Drawing.Point(346, 305);
            this.btnAlteraSenha.Name = "btnAlteraSenha";
            this.btnAlteraSenha.Size = new System.Drawing.Size(110, 30);
            this.btnAlteraSenha.TabIndex = 10;
            this.btnAlteraSenha.UseVisualStyleBackColor = true;
            this.btnAlteraSenha.Click += new System.EventHandler(this.btnAlteraSenha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 48);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(256, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(314, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // FormAlteraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlteraSenha);
            this.Controls.Add(this.txtConfirmaNewSenha);
            this.Controls.Add(this.txtNewSenha);
            this.Controls.Add(this.txtSenhaAntiga);
            this.Controls.Add(this.lblSenhaNovamente);
            this.Controls.Add(this.lblSenhaNova);
            this.Controls.Add(this.lblSenhaAntiga);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormAlteraSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSenhaAntiga;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.Label lblSenhaNovamente;
        private System.Windows.Forms.MaskedTextBox txtSenhaAntiga;
        private System.Windows.Forms.MaskedTextBox txtNewSenha;
        private System.Windows.Forms.MaskedTextBox txtConfirmaNewSenha;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Button btnAlteraSenha;
    }
}