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
    public partial class FormAcompanhaPedido : Form
    {
        public FormAcompanhaPedido()
        {
            InitializeComponent();

            lblId.Hide();
            txtIdPedido.Hide();
            btnConfirma.Hide();

            DataTable dt = new DataTable();
            dt.Columns.Add("idpedido");
            dt.Columns.Add("tipo_comida");
            dt.Columns.Add("comida_selec");
            dt.Columns.Add("bebidas_selec");
            dt.Columns.Add("pagamento_selec");
            dt.Columns.Add("preco_comida");
            dt.Columns.Add("preco_bebida");
            dt.Columns.Add("preco_total");
            dt.Columns.Add("situacao_pedido");
            DataRow row;

            try
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                string sql = "";

                if (Usuario.tipouser == "Administrador"){
                    cboOpcoes.Items.Add("Excluir");
                    dt.Columns.Add("iduser");
                    lblTitle.Text = "Todos os Pedidos";
                    sql = "select * from pedidos";
                }
                else
                {
                    lblTitle.Text = "Seus pedidos feitos";
                    sql = "select * from pedidos where iduser=" + Usuario.iduser;
                }

                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmm.ExecuteReader();


                while (dr.Read())
                {
                    row = dt.NewRow();
                    row["idpedido"] = dr["idpedido"];
                    row["tipo_comida"] = dr["tipo_comida"];
                    row["comida_selec"] = dr["comida_selec"];
                    row["bebidas_selec"] = dr["bebidas_selec"];
                    row["pagamento_selec"] = dr["pagamento_selec"];
                    row["preco_comida"] = dr["preco_comida"];
                    row["preco_bebida"] = dr["preco_bebida"];
                    row["preco_total"] = dr["preco_total"];
                    row["situacao_pedido"] = dr["situacao_pedido"];
                    if (Usuario.tipouser == "Administrador")
                    {
                        row["iduser"] = dr["iduser"];
                    }
                    dt.Rows.Add(row);
                }
                cmm.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ErroMySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvPedidos.DataSource = dt;
            dgvPedidos.Columns[0].HeaderText = "ID do pedido";
            dgvPedidos.Columns[1].HeaderText = "Tipo de comida";
            dgvPedidos.Columns[2].HeaderText = "Comidas selecionadas";
            dgvPedidos.Columns[3].HeaderText = "Bebidas selecionadas";
            dgvPedidos.Columns[4].HeaderText = "Pagamento selecionado";
            dgvPedidos.Columns[5].HeaderText = "Preço total da comida";
            dgvPedidos.Columns[6].HeaderText = "Preço total da bebida";
            dgvPedidos.Columns[7].HeaderText = "Preço total";
            dgvPedidos.Columns[8].HeaderText = "Situação do pedido";
            if (Usuario.tipouser == "Administrador")
            {
                dgvPedidos.Columns[9].HeaderText = "ID do usuario";
            }

        }



        private void btnConfirma_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                string sql = "";
                if (cboOpcoes.SelectedItem.ToString() == "Cancelar") 
                {
                    sql = "update pedidos set situacao_pedido='Cancelado' where idpedido=" + txtIdPedido.Text;
                }
                else if (cboOpcoes.SelectedItem.ToString() == "Excluir")
                {
                    sql = "delete from pedidos where idpedido=" + txtIdPedido.Text;
                }

                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                cmm.ExecuteNonQuery();
                cmm.Dispose();
                conn.Close();

                MessageBox.Show("Execução feita com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAcompanhaPedido NewForm = new FormAcompanhaPedido();
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

        private void dgvPedidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                txtIdPedido.Text = (string)dgvPedidos.CurrentRow.Cells[0].Value;
            }
        }

        private void cboOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpcoes.SelectedItem.ToString() == "Alterar")
            {
                FormPedidos NewForm = new FormPedidos();
                NewForm.btnConfirmar.Text = "Alterar";
                NewForm.lblAltera.Show();
                NewForm.cboAltera.Show();
                NewForm.Show();
                this.Dispose(false);
            }
            else if (cboOpcoes.SelectedItem.ToString() == "Cancelar")
            {
                lblId.Show();
                txtIdPedido.Show();
                btnConfirma.Show();

            }
            else
            {
                lblId.Show();
                txtIdPedido.Show();
                btnConfirma.Show();
            }
        }

    }
}
