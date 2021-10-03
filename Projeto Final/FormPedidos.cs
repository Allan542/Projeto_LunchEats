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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            lstOpcoes.CheckOnClick = true;
            lstBebida.CheckOnClick = true;
            lstPagamento.SetSelected(1, true);

            try
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");
                string sql = "select idpedido from pedidos where iduser=" + Usuario.iduser;
                MySqlCommand comm = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cboAltera.Items.Add((int)dr["idpedido"]);
                }
                comm.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Definindo comandos para os radiobuttons
        private void rdoMarmitex_CheckedChanged(object sender, EventArgs e)
        {
            btnMostraValor.Hide();
            lstOpcoes.Show();
            lstOpcoes.Items.Clear();
            lblInfo.Text = "Coloque o que você quiser, com as opções abaixo. \nIndependente do que for escolhido, sairá por R$30.00 total.";
            string[] alimento = { "Arroz", "Feijão", "Macarrão", "Batata Frita", "Salada (Alface e Tomate)", "Frango", "Bife", "Ovo", "Linguiça" };
            lstOpcoes.Items.AddRange(alimento);
        }

        private void rdoPF_CheckedChanged(object sender, EventArgs e)
        {
            btnMostraValor.Show();
            lstOpcoes.Show();
            lstOpcoes.Items.Clear();
            lblInfo.Text = "Apenas carnes podem ser escolhidas nas opções abaixo.\nO preço é R$25.00 + Valor unitário de cada carne \ninformado no botão abaixo da lista. ";
            string[] alimento = { "Bife", "Ovo cozido", "Ovo frito", "Linguiça", "Carne cozida", "Salsicha"};
            lstOpcoes.Items.AddRange(alimento);
        }

        private void rdoLanches_CheckedChanged(object sender, EventArgs e)
        {
            btnMostraValor.Show();
            lstOpcoes.Show();
            lstOpcoes.Items.Clear();
            lblInfo.Text = "Escolha um tipo de lanche. \nO preço está informado no botão abaixo da lista";
            string[] alimento = { "X-Burguer", "X-Salada", "X-Egg", "X-Bacon", "X-Cheddar Duplo", "X-Tudo" };
            lstOpcoes.Items.AddRange(alimento);
        }

        private void rdoPizzas_CheckedChanged(object sender, EventArgs e)
        {
            btnMostraValor.Hide();
            lstOpcoes.Show();
            lstOpcoes.Items.Clear();
            lblInfo.Text = "Escolha um sabor de pizza. Meio-a-Meio só temos Calabresa com Mussarela \nTodos os sabores são R$32.00 exceto meio-a-meio e 4 Queijos,\nque são R$36.00";
            string[] alimento = { "Calabresa", "Mussarela", "Portuguesa", "Catupiry", "Chocolate", "Meio-a-meio", "4 Queijos" };
            lstOpcoes.Items.AddRange(alimento);
        }

        private void rdoSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            btnMostraValor.Hide();
            lstOpcoes.Show();
            lstOpcoes.Items.Clear();
            lblInfo.Text = "Escolha um tipo de sobremesa. (Temos apenas chocolate). \nTodas custam R$10.00";
            string[] alimento = { "Bolo", "Pudim", "Mousse", "Sorvete", "Pavê" };
            lstOpcoes.Items.AddRange(alimento);
        }

        //Pegando valores de todas as opções marcadas e fazendo os devidos cálculos.
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Variáveis que serão usadas no banco MySQL
            
            string selecionado_comida, pagamento = "";
            double preco_comida = 0, preco_bebida = 0, preco = 0;
            string str_comida_selec = "", str_bebida = "";

            // Pegando o preço de informado de cada um e calculando.
            // Também pegando o radio button da comida selecionada.
            if (rdoMarmitex.Checked== true) //Marmitex
            {
                selecionado_comida = rdoMarmitex.Text;
                preco_comida = 30.00;
                
            } 
            else if (rdoPF.Checked == true) //Prato feito
            {
                selecionado_comida = rdoPF.Text;
                double[] vetor_preco = { 8.00, 2.00, 1.00, 4.00, 6.00, 3.00};
                preco_comida = 25.00;
                for (int i = 0; i < lstOpcoes.Items.Count; i++)
                {
                    if (lstOpcoes.GetItemChecked(i) == true)
                    {
                        preco_comida += vetor_preco[i];
                    }
                }
            } 
            else if (rdoLanches.Checked == true) //Lanches
            {
                selecionado_comida = rdoLanches.Text;
                double[] vetor_preco = { 4.00, 6.00, 7.00, 10.00, 8.00, 12.00 };
                for (int i = 0; i < lstOpcoes.Items.Count; i++)
                {
                    if (lstOpcoes.GetItemChecked(i) == true)
                    {
                        preco_comida += vetor_preco[i];
                    }
                }
            }
            else if (rdoPizzas.Checked == true) //Pizzas
            {
                selecionado_comida = rdoPizzas.Text;
                for (int i = 0; i < lstOpcoes.Items.Count; i++)
                {
                    if (lstOpcoes.GetItemChecked(i) == true)
                    {
                        if (lstOpcoes.Items[i].ToString() == "4 Queijos" || lstOpcoes.Items[i].ToString() == "Meio-a-meio")
                        {
                            preco_comida += 36.00;
                        }
                        else
                        {
                            preco_comida += 32.00;
                        }
                    }
                }
            }
            else //Sobremesa
            {
                selecionado_comida = rdoSobremesa.Text;
                for (int i = 0; i < lstOpcoes.Items.Count; i++)
                {
                    if (lstOpcoes.GetItemChecked(i) == true)
                    {
                        preco_comida += 10.00;
                    }
                }
            }

            // Contando quantos itens foram selecionados na CheckedListBox de opções
            for (int i = 0; i < lstOpcoes.Items.Count; i++)
            {
                if (lstOpcoes.GetItemChecked(i) == true)
                {
                    str_comida_selec = str_comida_selec + lstOpcoes.Items[i].ToString() + "... ";
                }
            }

            // Contando quantos itens foram selecionados na CheckedListBox de bebidas e calcula o preço
            double[] vetor_preco_bebida = { 6.00, 3.50, 2.50, 1.50, 1.50, 3.00, 1.00 };
            for (int i = 0; i < lstBebida.Items.Count; i++)
            {
                if (lstBebida.GetItemChecked(i) == true)
                {
                    str_bebida = str_bebida + lstBebida.Items[i].ToString() + "... ";
                    preco_bebida += vetor_preco_bebida[i];
                }
            }

            // Pegando o tipo de pagamento escolhido e calculando o preço total.
            pagamento = lstPagamento.SelectedItem.ToString();


            preco = preco_comida + preco_bebida;

            //Parte do banco de dados que irá inserir os dados para a tabela Pedidos

            try
            {
                string sql = "";
                MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = 'luncheats'");

                // Se form foi acessado através da opção do menu faça seu pedido
                if (btnConfirmar.Text == "Confirmar")
                {
                    sql = "INSERT INTO pedidos (`tipo_comida`, `comida_selec`, `bebidas_selec`, `pagamento_selec`,`preco_comida`, `preco_bebida`, `preco_total`, `situacao_pedido`, `iduser`) VALUES ('" + selecionado_comida +
                        "', '" + str_comida_selec + "', '" + str_bebida + "', '" + pagamento + "', '" + preco_comida.ToString("0.00") + "', '" + preco_bebida.ToString("0.00") + "', '" + preco.ToString("0.00") + "', 'Feito'," + Usuario.iduser + "); ";
                    MessageBox.Show("Pedido feito com sucesso!", "LunchEats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Se form foi acessado através da opção dentro do botao acompanhar pedidos
                {
                    sql = "UPDATE pedidos SET tipo_comida='" + selecionado_comida + "',comida_selec='" + str_comida_selec + "',bebidas_selec='" + str_bebida + "',pagamento_selec='" + pagamento + 
                        "',preco_comida='" + preco_comida.ToString("0.00") + "',preco_bebida='" + preco_bebida.ToString("0.00") + "',preco_total='" + preco.ToString("0.00") + "',situacao_pedido='Alterado',iduser=" + Usuario.iduser + " where idpedido=" + cboAltera.SelectedItem.ToString();
                    MessageBox.Show("Pedido alterado com sucesso!", "LunchEats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAcompanhaPedido NewForm = new FormAcompanhaPedido();
                    NewForm.Show();
                    this.Dispose(false);
                }

                MySqlCommand cmm = new MySqlCommand(sql, conn);
                conn.Open();
                cmm.ExecuteNonQuery();
                cmm.Dispose();
                conn.Close();

                FormMenu NewForm2 = new FormMenu();
                NewForm2.Show();
                this.Dispose(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Botão para mostrar valores
        private void btnMostraValor_Click(object sender, EventArgs e)
        {
            if (rdoPF.Checked == true)
            {
                string[] vetor_preco = { "R$8.00", "R2.00", "R$1.00", "R$4.00","R$6.00", "R$3.00" };
                MessageBox.Show("Bife: " + vetor_preco[0]
                     + "\nOvo Cozido: " + vetor_preco[1]
                     + "\nOvo Frito: " + vetor_preco[2]
                     + "\nLinguiça: " + vetor_preco[3]
                     + "\nCarne Cozida: " + vetor_preco[4]
                     + "\nSalsicha: " + vetor_preco[5], "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdoLanches.Checked == true)
            {
                string[] vetor_preco = { "R$4.00", "R6.00", "R$7.00", "R$10.00", "R$8.00", "R$12.00" };
                MessageBox.Show("X-Burguer: " + vetor_preco[0]
                     + "\nX-Salada: " + vetor_preco[1]
                     + "\nX-Egg: " + vetor_preco[2]
                     + "\nX-Bacon: " + vetor_preco[3]
                     + "\nX-Cheddar Duplo: " + vetor_preco[4]
                     + "\nX-Tudo: " + vetor_preco[5], "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu NewForm = new FormMenu();
            NewForm.Show();
            this.Dispose(false);
        }

        //Botão para mostrar valores de bebidas
        private void btnMostraValor2_Click(object sender, EventArgs e)
        {
            string[] vetor_preco = { "R$6.00", "R3.50", "R$2.50", "R$1.50", "R$1.50", "R$3.00", "R$1.00" };
            MessageBox.Show("Coca-Cola: " + vetor_preco[0]
                 + "\nPepsi Limão: " + vetor_preco[1]
                 + "\nDolly Citrus: " + vetor_preco[2]
                 + "\nSuco de Laranja: " + vetor_preco[3]
                 + "\nSuco de Uva: " + vetor_preco[4]
                 + "\nÁgua com gás: " + vetor_preco[5]
                 + "\nÁgua sem gás: " + vetor_preco[6], "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
