
namespace Projeto_Final
{
    partial class FormAlteraUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlteraUser));
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.cboOpcoes = new System.Windows.Forms.ComboBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cboOpcoesAltera = new System.Windows.Forms.ComboBox();
            this.lblAltera = new System.Windows.Forms.Label();
            this.btnEscolhe = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.txtAltera = new System.Windows.Forms.MaskedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(140, 117);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(845, 283);
            this.dgvUser.TabIndex = 2;
            this.dgvUser.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellEnter);
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOpcoes.Location = new System.Drawing.Point(253, 418);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(152, 20);
            this.lblOpcoes.TabIndex = 3;
            this.lblOpcoes.Text = "O que deseja fazer?";
            // 
            // cboOpcoes
            // 
            this.cboOpcoes.AutoCompleteCustomSource.AddRange(new string[] {
            "Alterar",
            "Cancelar"});
            this.cboOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboOpcoes.FormattingEnabled = true;
            this.cboOpcoes.Items.AddRange(new object[] {
            "Alterar",
            "Ativar",
            "Desativar",
            "Excluir"});
            this.cboOpcoes.Location = new System.Drawing.Point(411, 415);
            this.cboOpcoes.Name = "cboOpcoes";
            this.cboOpcoes.Size = new System.Drawing.Size(121, 28);
            this.cboOpcoes.TabIndex = 4;
            this.cboOpcoes.SelectedIndexChanged += new System.EventHandler(this.cboOpcoes_SelectedIndexChanged);
            // 
            // txtIdUser
            // 
            this.txtIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdUser.Location = new System.Drawing.Point(411, 463);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(121, 26);
            this.txtIdUser.TabIndex = 6;
            this.txtIdUser.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblId.Location = new System.Drawing.Point(313, 466);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 20);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Quem? (ID)";
            this.lblId.Visible = false;
            // 
            // cboOpcoesAltera
            // 
            this.cboOpcoesAltera.AutoCompleteCustomSource.AddRange(new string[] {
            "nome",
            "email",
            "telefone_celular",
            "telefone",
            "endereco"});
            this.cboOpcoesAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcoesAltera.FormattingEnabled = true;
            this.cboOpcoesAltera.Items.AddRange(new object[] {
            "nome",
            "email",
            "telefone",
            "telefone_celular",
            "endereco",
            "tipouser"});
            this.cboOpcoesAltera.Location = new System.Drawing.Point(411, 509);
            this.cboOpcoesAltera.Name = "cboOpcoesAltera";
            this.cboOpcoesAltera.Size = new System.Drawing.Size(121, 28);
            this.cboOpcoesAltera.TabIndex = 9;
            this.cboOpcoesAltera.Visible = false;
            this.cboOpcoesAltera.SelectedIndexChanged += new System.EventHandler(this.cboOpcoesAltera_SelectedIndexChanged);
            // 
            // lblAltera
            // 
            this.lblAltera.AutoSize = true;
            this.lblAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAltera.Location = new System.Drawing.Point(244, 512);
            this.lblAltera.Name = "lblAltera";
            this.lblAltera.Size = new System.Drawing.Size(161, 20);
            this.lblAltera.TabIndex = 8;
            this.lblAltera.Text = "O que deseja alterar?";
            this.lblAltera.Visible = false;
            // 
            // btnEscolhe
            // 
            this.btnEscolhe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEscolhe.Location = new System.Drawing.Point(538, 461);
            this.btnEscolhe.Name = "btnEscolhe";
            this.btnEscolhe.Size = new System.Drawing.Size(101, 28);
            this.btnEscolhe.TabIndex = 7;
            this.btnEscolhe.Text = "Escolher";
            this.btnEscolhe.UseVisualStyleBackColor = true;
            this.btnEscolhe.Visible = false;
            this.btnEscolhe.Click += new System.EventHandler(this.btnEscolhe_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAltera.Location = new System.Drawing.Point(503, 579);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(101, 28);
            this.btnAltera.TabIndex = 11;
            this.btnAltera.Text = "Alterar";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Visible = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // txtAltera
            // 
            this.txtAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAltera.Location = new System.Drawing.Point(539, 511);
            this.txtAltera.Name = "txtAltera";
            this.txtAltera.Size = new System.Drawing.Size(277, 26);
            this.txtAltera.TabIndex = 10;
            this.txtAltera.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.Location = new System.Drawing.Point(363, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Controle de Usuários";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 48);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 41;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormAlteraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 622);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtAltera);
            this.Controls.Add(this.btnEscolhe);
            this.Controls.Add(this.lblAltera);
            this.Controls.Add(this.cboOpcoesAltera);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblOpcoes);
            this.Controls.Add(this.cboOpcoes);
            this.Controls.Add(this.dgvUser);
            this.Name = "FormAlteraUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblOpcoes;
        private System.Windows.Forms.ComboBox cboOpcoes;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cboOpcoesAltera;
        private System.Windows.Forms.Label lblAltera;
        private System.Windows.Forms.Button btnEscolhe;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.MaskedTextBox txtAltera;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnVoltar;
    }
}