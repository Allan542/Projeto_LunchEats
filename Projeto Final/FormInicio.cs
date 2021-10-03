using MySql.Data.MySqlClient;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin NewForm = new FormLogin();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro NewForm = new FormCadastro();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

