using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Expr;
using MySql.Data; // Biblioteca da conexão SQL.
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http.Headers; // Bibllioteca da conexão SQL.

namespace UltimoSemestre
{
    internal class Empregado : Conexao 
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }



        public void Inserir()
        {
            string query = "INSERT INTO empregado(nome_empregado,sobrenome_empregado,cpf_empregado) VALUES ('" +
                getNome() + "','" + getSobrenome() + "','" + getCpf() + "')";
            if (this.AbrirConexao() == true )
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.FecharConexao();   
            }

        }

        public DataTable Consultar()
        {
            this.AbrirConexao();

            string mSQL = "Select * from empregado";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.FecharConexao();

            DataTable dt = new DataTable(); 
            da.Fill(dt);
            return dt;
        }
    }
}
