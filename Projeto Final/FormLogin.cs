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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database='luncheats'");
                string sql = "select * from usuario where email='" + txtLogin.Text + "' and senha='" + txtSenha.Text + "'";
                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmm.ExecuteReader();
                Usuario.nome = "";
                Usuario.email = "";
                Usuario.senha = "";
                Usuario.situacao = "";
                if (dr.Read())
                {
                    Usuario.iduser = (int)dr["iduser"];
                    Usuario.nome = (String)dr["nome"];
                    Usuario.email = (String)dr["email"];
                    Usuario.senha = (String)dr["senha"];
                    Usuario.situacao = (String)dr["situacao"];
                    Usuario.tipouser = (String)dr["tipouser"];
                }
                cmm.Dispose();
                conn.Close();
                if (Usuario.email != txtLogin.Text || Usuario.senha != txtSenha.Text)
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }
                else if (Usuario.situacao.Equals("Inativo"))
                {
                    MessageBox.Show("Usuário desativado pelo administrador!");
                }
                else
                {
                    FormMenu NewForm = new FormMenu();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormInicio NewForm = new FormInicio();
            NewForm.Show();
            this.Dispose(false);
        }

        private void lblAlteraSenha_Click(object sender, EventArgs e)
        {
            FormAlteraSenha NewForm = new FormAlteraSenha();
            NewForm.Show();
            NewForm.btnAlteraSenha.Text = "Redefinir";
            this.Dispose(false);
        }
    }
}
