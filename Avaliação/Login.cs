using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace insert_csharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.Equals("admin", txtUser.Text) && string.Equals("admin", txtSenha.Text))
            {
                this.Hide();
                CadastrarAluno v = new CadastrarAluno();
                v.Closed += (s, args) => this.Close();
                v.Show();

            }
            else
            {
                MessageBox.Show("Credenciais incorretas! (user: admin \\ senha: admin)");
            }
        }

        private void lblSobreNos_Click(object sender, EventArgs e)
        {
            Sobrese sobreSe = new Sobrese();
            sobreSe.Show();
            this.Hide();
        }
    }
}
