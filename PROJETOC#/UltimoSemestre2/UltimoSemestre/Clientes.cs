using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace UltimoSemestre

{
    internal class Clientes : Conexao
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
            string query = "INSERT INTO clientes(nome_cliente,sobrenome_cliente,cpf_cliente) VALUES ('" + getNome() + "','" + getSobrenome() + "','" + getCpf() + "')";

            if (this.AbrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.FecharConexao();
            }
        }
        public void Excluir()
        {
            string query = "Delete from clientes where cpf_cliente= '" + getCpf() + "'";
            if (this.AbrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.FecharConexao();
            }
        }


        public void Alterar()
        {
            string query = "UPDATE clientes SET nome_cliente = '" + getNome() +
                            "', sobrenome_cliente =  '" + getSobrenome() +
                            "'where cpf_cliente = '" + getCpf() + "'";

            if (this.AbrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.FecharConexao();
            }
        }



        public DataTable Consultar()
        {
            this.AbrirConexao();

            string mSQL = "Select * from cliente ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.FecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
