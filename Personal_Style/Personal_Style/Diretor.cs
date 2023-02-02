using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Personal_Style
{
     public  class Diretor
    {
        public void Salvar()

        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            Console.WriteLine("digite  o  nome");
            string nome_add = Console.ReadLine();
            Console.WriteLine("Digite CPF  sem espaços ou traços ");
            int cpf_add = int.Parse(Console.ReadLine());
            Console.WriteLine("digite  o  telefone sem espaços ou traços ");
            int telefone_add = int.Parse(Console.ReadLine());
            string add_diretor = "INSERT INTO diretor(nome,cpf,telefone) " +
              "values('" + nome_add + "','" + cpf_add + "','" + telefone_add + "')";
            SqlCommand salvar_dados = new SqlCommand(add_diretor, sqlConnection);
            salvar_dados.ExecuteNonQuery();
            Console.WriteLine("Arquivo Salvo");
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
            int n =  int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                menu.Menu_diretor();
            }

            else
            {

            }
        }

        public void visualizar()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            string selecionar = "SELECT * FROM diretor;";
            SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
            SqlDataReader dataReader = visualizar.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(0).ToString()+ "\tNome:" + dataReader.GetValue(1).ToString()+"\tCPF:" + dataReader.GetValue(2).ToString()+"\tTelefone:" + dataReader.GetValue(3).ToString());
         
            }
       
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                menu.Menu_diretor();
            }

            else
            {

            }
        }

        public void editar()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            Console.WriteLine("Digite o id para alteraraço");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("digte o nome a ser alterado");
            string nome = Console.ReadLine();
            Console.WriteLine("digte o cpf a ser alterado");
            int cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("digte o telefone a ser alterado");
            int telefone = int.Parse(Console.ReadLine());


            string update_query = "UPDATE diretor SET nome = '" + nome + "', cpf = " + cpf + ", telefone = " + telefone + " WHERE  id = " + id + " ";
            SqlCommand updat_command = new SqlCommand(update_query, sqlConnection);
            updat_command.ExecuteNonQuery();
            Console.WriteLine("Dados alterados");
            Console.WriteLine("");
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                menu.Menu_diretor();
            }

            else
            {

            }
        }
        public void exluir ()
        {
            try
            {
                Menus menu = new Menus();
                SqlConnection sqlConnection;
                string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
                sqlConnection = new SqlConnection(conex);
                sqlConnection.Open();
                Console.WriteLine("Digite o id a ser excluido");
                int id = int.Parse(Console.ReadLine());
                string deleteQuery = "DELETE FROM diretor WHERE  id= " + id + "";
                SqlCommand deletecmd = new SqlCommand(deleteQuery, sqlConnection);
                deletecmd.ExecuteNonQuery();
                Console.WriteLine("Usuario excluido com sucesso");

                Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    Console.Clear();
                    menu.Menu_diretor();
                }

                else
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine ("dados nao foram deletados" + e.Message);
            }
           
        }

    }
}
