
namespace Projeto_Final
{
    partial class FormMenu
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
            this.btnAcompanha = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnControlaUser = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAlteraSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcompanha
            // 
            this.btnAcompanha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcompanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAcompanha.Location = new System.Drawing.Point(112, 210);
            this.btnAcompanha.Name = "btnAcompanha";
            this.btnAcompanha.Size = new System.Drawing.Size(219, 30);
            this.btnAcompanha.TabIndex = 4;
            this.btnAcompanha.Text = "Acompanhe seus pedidos";
            this.btnAcompanha.UseVisualStyleBackColor = true;
            this.btnAcompanha.Click += new System.EventHandler(this.btnAcompanha_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPedido.Location = new System.Drawing.Point(112, 160);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(219, 30);
            this.btnPedido.TabIndex = 2;
            this.btnPedido.Text = "Faça seu pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(12, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 20);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Bem Vindo, ";
            // 
            // btnControlaUser
            // 
            this.btnControlaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnControlaUser.Location = new System.Drawing.Point(112, 310);
            this.btnControlaUser.Name = "btnControlaUser";
            this.btnControlaUser.Size = new System.Drawing.Size(219, 30);
            this.btnControlaUser.TabIndex = 5;
            this.btnControlaUser.Text = "Controle de Usuários";
            this.btnControlaUser.UseVisualStyleBackColor = true;
            this.btnControlaUser.Click += new System.EventHandler(this.btnControlaUser_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(352, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 32);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Maroon;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(117, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "LunchEats";
            // 
            // btnAlteraSenha
            // 
            this.btnAlteraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlteraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlteraSenha.Location = new System.Drawing.Point(112, 260);
            this.btnAlteraSenha.Name = "btnAlteraSenha";
            this.btnAlteraSenha.Size = new System.Drawing.Size(219, 30);
            this.btnAlteraSenha.TabIndex = 8;
            this.btnAlteraSenha.Text = "Alterar senha";
            this.btnAlteraSenha.UseVisualStyleBackColor = true;
            this.btnAlteraSenha.Click += new System.EventHandler(this.btnAlteraSenha_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 411);
            this.Controls.Add(this.btnAlteraSenha);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnControlaUser);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnAcompanha);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcompanha;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnControlaUser;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAlteraSenha;
    }
}