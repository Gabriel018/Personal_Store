using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personal_Style
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string conex = @"Data Source=DUKE\SQLEXPRESS;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(conex);
                sqlConnection.Open();
                Console.WriteLine("Conectado com sucesso");
                
               
                Console.WriteLine("Digite seu nome");
                string nome_add = Console.ReadLine();
                Console.WriteLine("Digite seu cpf");
                int cpf_add = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o telefone");
                int telefone_add = int.Parse(Console.ReadLine());


                string add_diretor = "INSERT INTO diretor(nome,cpf,telefone) " +
                    "VALUES('" + nome_add + "','" + cpf_add + "','" + telefone_add + "')";
                SqlCommand salvar_dados = new SqlCommand(add_diretor, sqlConnection);
                salvar_dados.ExecuteNonQuery();
                Console.WriteLine("Dados salvos ");
            }
            catch(Exception e)
            {
                Console.WriteLine("Dados nao foram salvos",(e.Message));


            }


            
        }
    }
}

