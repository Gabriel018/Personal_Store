using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

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
            Console.WriteLine("");
            if (string.IsNullOrEmpty(nome_add))
            {
                Console.WriteLine("Nome inválido. Por favor, tente novamente.");
            }
            if (int.TryParse(nome_add, out int number))
            {
                Console.WriteLine("Valor digitado invalido");
            }

            Console.WriteLine("Digite o  CPF  sem espaços ou traços ");
            string cpf_add = (Console.ReadLine());
            Console.WriteLine("");
            string cpf_formatado = "";
            cpf_formatado = cpf_add.Substring(0, 3) + "." + cpf_add.Substring(3, 3) + "." + cpf_add.Substring(6, 3) + "-" + cpf_add.Substring(9, 2);
            if (string.IsNullOrEmpty(cpf_add))
            {
                Console.WriteLine("cpf inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("digite  o  telefone sem espaços ou traços ");
            string telefone_add = (Console.ReadLine());
            string  tel_formatado = "";
            tel_formatado =  "(" + telefone_add.Substring( 0, 2) + ")" + telefone_add.Substring(2, 4) + "-" + telefone_add.Substring(2,4);

            if (string.IsNullOrEmpty(telefone_add))
             
        
            {
                Console.WriteLine("Telefone inválido. Por favor, tente novamente.");
            }
            string add_diretor = "INSERT INTO diretor(nome,cpf,telefone) " +
              "values('" + nome_add + "','" + cpf_formatado + "','" + tel_formatado + "')";
            SqlCommand salvar_dados = new SqlCommand(add_diretor, sqlConnection);
            salvar_dados.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Arquivo Salvo");
            Console.WriteLine("");
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
            int n =  int.Parse(Console.ReadLine());

            if ( n < 1 || n > 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
            }
            else

        if (n == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Console.Clear();
                menu.Menu_diretor();
            }

            if(n == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Console.Clear();
                Program.Main();
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
                Console.WriteLine("");
                Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                Console.WriteLine("NOme: " +dataReader.GetValue(1).ToString());
                Console.WriteLine("CPF: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Telefone: " + dataReader.GetValue(3).ToString());


            }
       
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao Menu inicial");
            int n = int.Parse(Console.ReadLine());


            if (n < 1 || n > 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
            }
            else

            if (n == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Console.Clear();
                menu.Menu_diretor();
            }


            if (n == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Console.Clear();
                Program.Main();
            }
        }

        public void editar()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
              
            string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();

            Console.WriteLine("");
            Console.WriteLine("");
            string selecionar = "SELECT * FROM diretor;";
            SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
            SqlDataReader dataReader = visualizar.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine("");
                Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                Console.WriteLine("NOme: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("CPF: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Telefone: " + dataReader.GetValue(3).ToString());

            }
            sqlConnection.Close();

            Console.WriteLine("Digite o id para alteraraço");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome a ser alterado");
            string nome_add = Console.ReadLine();
            if (string.IsNullOrEmpty(nome_add))
            {
                Console.WriteLine("Nome inválido. Por favor, tente novamente.");
            }

            sqlConnection.Close();
            sqlConnection.Open();


            Console.WriteLine("digite o cpf a ser alterado");
            string cpf_add = (Console.ReadLine());
            string cpf_formatado = "";
            cpf_formatado = cpf_add.Substring(0, 3) + "." + cpf_add.Substring(3, 3) + "." + cpf_add.Substring(6, 3) + "-" + cpf_add.Substring(9, 2);
            if (string.IsNullOrEmpty(cpf_add))
            {
                Console.WriteLine("Cpf inválido. Por favor, tente novamente.");
            }

            Console.WriteLine("digite o telefone a ser alterado");
            string telefone_add = (Console.ReadLine());
            string tel_formatado = "";
            tel_formatado = "(" + telefone_add.Substring(0, 2) + ")" + telefone_add.Substring(2, 4) + "-" + telefone_add.Substring(2, 4);

            string update_query = "UPDATE diretor SET nome = '" + nome_add + "', cpf = '" + cpf_add + "', telefone = '" + telefone_add + "' WHERE  id = " + id + " ";
            SqlCommand updat_command = new SqlCommand(update_query, sqlConnection);
            updat_command.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dados alterados");
            Console.WriteLine("");
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());



            if (n < 1 || n > 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
            }
            else

            if (n == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Console.Clear();
                menu.Menu_diretor();
            }

            if (n == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Console.Clear();
                Program.Main();
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

                Console.WriteLine("");
                Console.WriteLine("");
                string selecionar = "SELECT * FROM diretor;";
                SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
                SqlDataReader dataReader = visualizar.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine("");
                    Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                    Console.WriteLine("NOme: " + dataReader.GetValue(1).ToString());
                    Console.WriteLine("CPF: " + dataReader.GetValue(2).ToString());
                    Console.WriteLine("Telefone: " + dataReader.GetValue(3).ToString());
                  

                }
                sqlConnection.Close();
                sqlConnection.Open();
                Console.WriteLine("");
                Console.WriteLine("Digite o id a ser excluido");
                int id = int.Parse(Console.ReadLine());

                string deleteQuery = "DELETE FROM diretor WHERE  id= " + id + "";
                SqlCommand deletecmd = new SqlCommand(deleteQuery, sqlConnection);
                deletecmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usuario excluido com sucesso");

                Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
                int n = int.Parse(Console.ReadLine());


                if (n < 1 || n > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida!");
                }
                else

                if (n == 1)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        System.Threading.Thread.Sleep(80);
                    }
                    Console.Clear();
                    menu.Menu_diretor();
                }

                if (n == 2)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        System.Threading.Thread.Sleep(80);
                    }
                    Console.Clear();
                    Program.Main();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine ("dados nao foram deletados" + e.Message);
            }
           
        }

    }
}
