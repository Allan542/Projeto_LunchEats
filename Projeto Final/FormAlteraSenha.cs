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
    public partial class FormAlteraSenha : Form
    {
        public FormAlteraSenha()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (btnAlteraSenha.Text == "Redefinir")
            {
                FormLogin NewForm = new FormLogin();
                NewForm.Show();
                this.Dispose(false);
            }
            else
            {
                FormMenu NewForm = new FormMenu();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void btnAlteraSenha_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                String sql = "SELECT * from usuario where email='" + txtEmail.Text + "' and senha='" + txtSenhaAntiga.Text + "'; ";

                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmm.ExecuteReader();

                if (dr.Read())
                {

                    Usuario.nome = (String)dr["nome"];
                    Usuario.email = (String)dr["email"];
                    Usuario.senha = (String)dr["senha"];
                    Usuario.situacao = (String)dr["situacao"];
                }
                cmm.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErroMySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtNewSenha.Text == txtConfirmaNewSenha.Text && txtEmail.Text == Usuario.email && Usuario.senha == txtSenhaAntiga.Text)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                    string sql = "update usuario set senha='" + txtNewSenha.Text + "' where email='" + txtEmail.Text + "' and senha='" + txtSenhaAntiga.Text + "' ";

                    MySqlCommand cmm = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmm.ExecuteNonQuery();
                    cmm.Dispose();
                    conn.Close();
                    
                    MessageBox.Show("Alteração feita com sucesso! Faça login novamente com a nova senha.", "LunchEats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin NewForm = new FormLogin();
                    NewForm.Show();
                    this.Dispose(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ErroMySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email ou Senha(s) incorreta(s)!", "LunchEats", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtSenhaAntiga.Text = "";
                txtNewSenha.Text = "";
                txtConfirmaNewSenha.Text = "";
            }

            }
        }
    }
