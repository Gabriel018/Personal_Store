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

                // Add ao banco
                //Console.WriteLine("Digite seu nome");
                //string nome_add = Console.ReadLine();
                //Console.WriteLine("Digite seu cpf");
                //int cpf_add = int.Parse(Console.ReadLine());
                //Console.WriteLine("Digite o telefone");
                //int telefone_add = int.Parse(Console.ReadLine());
                //string add_diretor = "INSERT INTO diretor(nome,cpf,telefone) " +
                //    "VALUES('" + nome_add + "','" + cpf_add + "','" + telefone_add + "')";
                //SqlCommand salvar_dados = new SqlCommand(add_diretor, sqlConnection);
                //salvar_dados.ExecuteNonQuery();
                //Console.WriteLine("Dados salvos ");



                //visualizar
                //string selecionar = "SELECT * FROM diretor;";
                //SqlCommand visualizar  = new SqlCommand(selecionar, sqlConnection);
                //SqlDataReader dataReader= visualizar.ExecuteReader();

                //while(dataReader.Read())
                //{
                //    Console.WriteLine("nome:," + dataReader.GetValue(1).ToString());
                //    Console.WriteLine("cpf:," + dataReader.GetValue(2).ToString());
                //    Console.WriteLine("Telefone:," + dataReader.GetValue(3).ToString());
                //    Console.ReadLine();
                //}
                //dataReader.Close();



                //UPDATE
                //Console.WriteLine("Digite o id para alteraraço");
                //int id = int.Parse(Console.ReadLine());
                //Console.WriteLine("digte o nome a ser alterado");
                //string nome = Console.ReadLine();
                //Console.WriteLine("digte o cpf a ser alterado");
                //int cpf = int.Parse(Console.ReadLine());
                //Console.WriteLine("digte o telefone a ser alterado");
                //int telefone = int.Parse(Console.ReadLine());


                //string update_query = "UPDATE diretor SET nome = '" + nome + "', cpf = " + cpf + ", telefone = " + telefone + " WHERE  id = " + id + " ";
                //SqlCommand updat_command = new SqlCommand(update_query, sqlConnection);
                //updat_command.ExecuteNonQuery();

                Console.WriteLine("Digite o id a ser excluido");
               int  id = int.Parse(Console.ReadLine());

                string deleteQuery = "DELETE FROM diretor WHERE  id= "+id+"";
               SqlCommand  deletecmd = new SqlCommand(deleteQuery,sqlConnection);
                deletecmd.ExecuteNonQuery();

            }



            catch (Exception e)
            {
                Console.WriteLine("Dados nao foram salvos", (e.Message));


            }


            
        }
    }
}

