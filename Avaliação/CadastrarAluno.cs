using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace insert_csharp
{
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        public void cadAluno(string rgAluno, string cpfAluno, string dsEndereco, string nmAluno, string foneAluno, string curso)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.nomeConexao;          
            conn.Open();


            string query = "";

            query = String.Concat("insert into aluno(rgAluno,cpfAluno , dsEndereco, nmAluno, foneAluno, curso) values ('", rgAluno, "','", cpfAluno, "','", dsEndereco, "','", nmAluno, "','", foneAluno, "','", curso, "')");

            SqlCommand comandaSQL = new SqlCommand(query, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }
        private void limparCampos()
        {
            txtRg.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            cadAluno(txtRg.Text, txtCpf.Text, txtEndereco.Text, txtNome.Text, txtTelefone.Text, cbCurso.Text);
            MessageBox.Show("Registro cadastrado", "Cadastrado");
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaAluno buscaAluno = new BuscaAluno();
            buscaAluno.Show();
            this.Hide();
        }

        private void carregaCursos() 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.nomeConexao;
            conexao.Open();

            string comandoSQL = "SELECT nmCurso FROM Curso";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbCurso.DataSource = dt;

            cbCurso.DisplayMember = "nmCurso";

            conexao.Close();
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            carregaCursos();
        }
    }
}
