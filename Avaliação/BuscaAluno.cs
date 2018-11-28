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
    public partial class BuscaAluno : Form
    {
        public BuscaAluno()
        {
            InitializeComponent();
        }

        public void retornarAlunos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.nomeConexao;
            conexao.Open();

            //idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
            string comandoSQL = "SELECT idAluno 'Código Aluno', nmAluno 'Nome', cpfAluno 'CPF Aluno', dsEndereco 'Endereço', rgAluno 'RG', foneAluno 'Telefone', curso 'Curso' FROM Aluno";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvAluno.DataSource = dt;

            conexao.Close();
        }

        public void buscarAluno()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.nomeConexao;
            conexao.Open();

            string query = "";

            query = String.Concat("SELECT  idAluno 'Código Aluno', nmAluno 'Nome', cpfAluno 'CPF Aluno', dsEndereco 'Endereço', rgAluno 'RG', foneAluno 'Telefone', curso 'Curso' FROM Aluno where nmAluno like '%", txtBuscarAluno.Text, "%';");

            SqlCommand sqlCommand = new SqlCommand(query, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvAluno.DataSource = dt;

            conexao.Close();
        }

        private void carregaAlunos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.nomeConexao;
            conexao.Open();

            string comandoSQL = "SELECT idAluno FROM Aluno";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbIDAluno.DataSource = dt;

            cbIDAluno.DisplayMember = "idAluno";

            conexao.Close();
        }

        private void BuscaAluno_Load(object sender, EventArgs e)
        {
            retornarAlunos();
            carregaAlunos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            buscarAluno();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.nomeConexao;
            conn.Open();


            string query = "";

            query = String.Concat("DELETE FROM Aluno WHERE idAluno = '", cbIDAluno.Text, "';");

            MessageBox.Show("Registro Excluido com sucesso", "Cadastrado");

            SqlCommand comandaSQL = new SqlCommand(query, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();

            retornarAlunos();  
        }

        private void carregaAlunoQueSeraExcluido() 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.nomeConexao;
            conexao.Open();

            string comandoSQL = "SELECT idAluno FROM Aluno";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbIDAluno.DataSource = dt;

            cbIDAluno.DisplayMember = "idAluno";

            conexao.Close();
        }

        private void cbIDAluno_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
