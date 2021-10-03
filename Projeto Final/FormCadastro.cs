using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void cboTel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTel.Text == "Telefone") 
            {
                txtTel.Mask = "(99) 0000-0000";
            }
            else
            {
                txtTel.Mask = "(99) 00000-0000";
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicio NewForm = new FormInicio();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Text == txtSenha.Text)
            {
                try
                {
                    if(TxtNumRua.Text == "")
                    {
                        TxtNumRua.Text = "S/N";
                    }
                
                    MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                    String sql = "INSERT INTO usuario(`nome`, `email`, `telefone`, `endereco`, `senha`, `tipouser`, `situacao`) VALUES ('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTel.Text + "', '" 
                        + txtCep.Text + " - " + txtRua.Text + ", " + TxtNumRua.Text + " - " + txtBairro.Text + ", " + txtCidade.Text+ " - " + cboEstado.Text + "', '" + txtSenha.Text + "', 'Usuário', 'Ativo'); ";

                    MySqlCommand cmm = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmm.ExecuteNonQuery();
                    cmm.Dispose();
                    conn.Close();

                    MessageBox.Show("Cadastro feito com sucesso!", "LunchEats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormInicio NewForm = new FormInicio();
                    NewForm.Show();
                    this.Dispose(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        else
            {
                MessageBox.Show("Senha informada incorretamente, digite novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
