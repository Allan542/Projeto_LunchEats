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
    public partial class FormAlteraUser : Form
    {
        public FormAlteraUser()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("iduser");
            dt.Columns.Add("nome");
            dt.Columns.Add("email");
            dt.Columns.Add("telefone");
            dt.Columns.Add("endereco");
            dt.Columns.Add("senha");
            dt.Columns.Add("tipouser");
            dt.Columns.Add("situacao");

            DataRow row;

            try
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                string sql = "select * from usuario";

                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmm.ExecuteReader();


                while (dr.Read())
                {
                    row = dt.NewRow();
                    row["iduser"] = dr["iduser"];
                    row["nome"] = dr["nome"];
                    row["email"] = dr["email"];
                    row["telefone"] = dr["telefone"];
                    row["endereco"] = dr["endereco"];
                    row["senha"] = dr["senha"];
                    row["tipouser"] = dr["tipouser"];
                    row["situacao"] = dr["situacao"];
                    dt.Rows.Add(row);
                }
                cmm.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErroMySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvUser.DataSource = dt;
            dgvUser.Columns[0].HeaderText = "ID do usuario";
            dgvUser.Columns[6].HeaderText = "Tipo de Usuário";
        }

        private void cboOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpcoes.SelectedItem.ToString() == "Alterar")
            {
                lblId.Show();
                txtIdUser.Show();
                btnEscolhe.Text = "Escolher";
                btnEscolhe.Show();
            }
            else
            {
                lblId.Show();
                txtIdUser.Show();
                btnEscolhe.Text = "Confirmar";
                btnEscolhe.Show();

                btnAltera.Hide();
                lblAltera.Hide();
                cboOpcoesAltera.Hide();
                txtAltera.Hide();
            }
        }

        private void btnEscolhe_Click(object sender, EventArgs e)
        {
            if (btnEscolhe.Text == "Escolher")
            {
                lblAltera.Show();
                cboOpcoesAltera.Show();
                txtAltera.Show();
                btnAltera.Show();
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                    string sql = "";
                    if (cboOpcoes.SelectedItem.ToString() == "Desativar")
                    {
                        sql = "update usuario set situacao='Inativo' where iduser=" + txtIdUser.Text;
                    }
                    else if (cboOpcoes.SelectedItem.ToString() == "Ativar")
                    {
                        sql = "update usuario set situacao='Ativo' where iduser=" + txtIdUser.Text;
                    }
                    else if (cboOpcoes.SelectedItem.ToString() == "Excluir")
                    {
                        sql = "delete from usuario where iduser=" + txtIdUser.Text;
                    }

                    MySqlCommand cmm = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmm.ExecuteNonQuery();
                    cmm.Dispose();
                    conn.Close();

                    MessageBox.Show("Execução feita com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAlteraUser NewForm = new FormAlteraUser();
                    NewForm.Show();
                    this.Dispose(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ErroMySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboOpcoesAltera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpcoesAltera.SelectedItem.ToString() == "telefone")
            {
                txtAltera.Mask = "(00) 0000-0000";
            }

            else if (cboOpcoesAltera.SelectedItem.ToString() == "telefone_celular")
            {
                txtAltera.Mask = "(00) 00000-0000";
            }
            else
            {
                txtAltera.Mask = "";
            }
        }

        private void dgvUser_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.CurrentRow != null) 
            {
                txtIdUser.Text = (string)dgvUser.CurrentRow.Cells[0].Value;
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                string sql = "";
                if (cboOpcoesAltera.SelectedItem.ToString() == "telefone" || cboOpcoesAltera.SelectedItem.ToString() == "telefone_celular")
                {
                    sql = "update usuario set telefone='" + txtAltera.Text + "' where iduser=" + txtIdUser.Text;
                }
                else
                {
                    sql = "update usuario set " + cboOpcoesAltera.SelectedItem.ToString() + "='" + txtAltera.Text + "' where iduser=" + txtIdUser.Text;
                }

                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                cmm.ExecuteNonQuery();
                cmm.Dispose();
                conn.Close();

                MessageBox.Show("Execução feita com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAlteraUser NewForm = new FormAlteraUser();
                NewForm.Show();
                this.Dispose(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErroMySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu NewForm = new FormMenu();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

