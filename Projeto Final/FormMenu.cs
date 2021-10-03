using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            lblNome.Text = "Bem-vindo(a), " + Usuario.nome;
            if (Usuario.tipouser != "Administrador") 
            {
                btnControlaUser.Hide();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormPedidos NewForm = new FormPedidos();
            NewForm.btnConfirmar.Text = "Confirmar";
            NewForm.lblAltera.Hide();
            NewForm.cboAltera.Hide();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnAcompanha_Click(object sender, EventArgs e)
        {
            FormAcompanhaPedido NewForm = new FormAcompanhaPedido();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até logo!", "Despedida");
            FormLogin NewForm = new FormLogin();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            FormPedidos NewForm = new FormPedidos();
            NewForm.btnConfirmar.Text = "Alterar";
            NewForm.lblAltera.Show();
            NewForm.cboAltera.Show();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnControlaUser_Click(object sender, EventArgs e)
        {
            FormAlteraUser NewForm = new FormAlteraUser();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnAlteraSenha_Click(object sender, EventArgs e)
        {
            FormAlteraSenha NewForm = new FormAlteraSenha();
            NewForm.Show();
            NewForm.txtEmail.Text = Usuario.email;
            NewForm.btnAlteraSenha.Text = "Alterar";
            this.Dispose(false);
        }
    }
}
