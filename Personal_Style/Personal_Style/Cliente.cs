using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personal_Style
{
    class Cliente
    {
        public void Salvar_Cliente()

        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
             string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
          // string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            Console.WriteLine("digite seu nome");
            string nome_add = Console.ReadLine();
            Console.WriteLine("");
            if (string.IsNullOrEmpty(nome_add))
            {
                Console.WriteLine("nome inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("Digite seu CPF sem espaços ou traços ");
            Console.WriteLine("");
            string cpf_add = (Console.ReadLine());
            Console.WriteLine("");
            string cpf_formatado = "";
            cpf_formatado = cpf_add.Substring(0, 3) + "." + cpf_add.Substring(3, 3) + "." + cpf_add.Substring(6, 3) + "-" + cpf_add.Substring(9, 2);
            if (string.IsNullOrEmpty(cpf_add))
            {
                Console.WriteLine("cpf inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("");
            Console.WriteLine("digite seu telefone sem espaços ou traços ");
            Console.WriteLine("");
            string telefone_add = (Console.ReadLine());
            string tel_formatado = "";
            tel_formatado = "(" + telefone_add.Substring(0, 2) + ")" + telefone_add.Substring(2, 4) + "-" + telefone_add.Substring(2, 4);
            if (string.IsNullOrEmpty(telefone_add))
            {
                Console.WriteLine("telefone inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("");
            Console.WriteLine("descreve seu estilo");
             Console.WriteLine("");
            string descricao_add = (Console.ReadLine());
            if (string.IsNullOrEmpty(descricao_add))
            {
                Console.WriteLine("descricao inválida. Por favor, tente novamente.");
            }
            Console.WriteLine("");
            Console.WriteLine("digite uma dos estilos :  casual| exentrico| esportivo| criativo| urbano ");
            string categoria_add = (Console.ReadLine());
            if (string.IsNullOrEmpty(categoria_add))
            {
                Console.WriteLine("cpf inválido. Por favor, tente novamente.");
            }

            Console.WriteLine("qual seu rendimento?");
            decimal rendimento_add = decimal.Parse(Console.ReadLine());
           


            string add_cliente = "INSERT INTO cliente(nome, cpf, telefone, descricao, categoria, rendimento) " +
              "values('" + nome_add + "','" + cpf_formatado + "','" + tel_formatado + "','" + descricao_add + "','" + categoria_add + "','" + rendimento_add + "')";
            SqlCommand salvar_dados = new SqlCommand(add_cliente, sqlConnection);
            salvar_dados.ExecuteNonQuery();
            Console.WriteLine("Arquivo Salvo");
            Console.WriteLine(" 1) voltar ao  Menu Cliente\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());


            if (n < 1 || n > 4)
            {
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
                menu.Menu_cliente();
            }

            if (n == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }
                Program.Main();
            }

        }

        public void editar_cliente()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
            //string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();

            string selecionar = "SELECT * FROM cliente;";
            SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
            SqlDataReader dataReader = visualizar.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine("");
                Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                Console.WriteLine("NOme: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("CPF: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Telefone: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Descriçao: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("Categoria: " + dataReader.GetValue(5).ToString());

            }

            sqlConnection.Close();
            sqlConnection.Open();

            Console.WriteLine("");
            Console.WriteLine("Digite o id para alteraraço");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("digte o nome a ser alterado");
            string nome = Console.ReadLine();
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("nome inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("digite o cpf a ser alterado");
            string cpf = (Console.ReadLine());
            if (string.IsNullOrEmpty(cpf))
            {
                Console.WriteLine("cpf inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("digite o telefone a ser alterado");
            string telefone = (Console.ReadLine());
            if (string.IsNullOrEmpty(telefone))
            {
                Console.WriteLine("Telefone inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("digite a descriçao a ser alterada");
            string descricao_add = (Console.ReadLine());
            if (string.IsNullOrEmpty(descricao_add))
            {
                Console.WriteLine("decriçao inválida. Por favor, tente novamente.");
            }
            Console.WriteLine("escolha sua categoria");
            string categoria_add = (Console.ReadLine());
            if (string.IsNullOrEmpty(categoria_add))
            {
                Console.WriteLine("cpf inválido. Por favor, tente novamente.");
            }
            Console.WriteLine("qual seu rendimento?");
            decimal rendimento_add = decimal.Parse(Console.ReadLine());
    
            string update_query = "UPDATE cliente SET nome = '" + nome + "', cpf = " + cpf + ", telefone = '" + telefone + "', descricao ='" + descricao_add + "', categoria ='" + categoria_add + "', rendimento =" + rendimento_add + " WHERE  id = " + id + " ";
            SqlCommand updat_command = new SqlCommand(update_query, sqlConnection);
            updat_command.ExecuteNonQuery();
            Console.WriteLine("os dados foram alterador");

            Console.WriteLine(" 1) voltar ao  Menu Vendedor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());


            if (n < 1 || n > 4)
            {
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
                menu.Menu_cliente();
            }

            if (n == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(80);
                }

                Program.Main();
            }
        }

        public void visualizar_cliente()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
              string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
            //string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            string selecionar = "SELECT * FROM cliente;";
            SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
            SqlDataReader dataReader = visualizar.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine("");
                Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                Console.WriteLine("NOme: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("CPF: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Telefone: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Descriçao: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("Categoria: " + dataReader.GetValue(5).ToString());

            }
            Console.WriteLine("");
            Console.WriteLine(" 1) voltar ao  Menu Vendedor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());


            if (n < 1 || n > 4)
            {
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
                menu.Menu_cliente();
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
        public void exluir_cliente()
        {
            try
            {
                Menus menu = new Menus();
                SqlConnection sqlConnection;
                  string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
               // string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
                sqlConnection = new SqlConnection(conex);
                sqlConnection.Open();

                string selecionar = "SELECT * FROM cliente;";
                SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
                SqlDataReader dataReader = visualizar.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine("");
                    Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                    Console.WriteLine("NOme: " + dataReader.GetValue(1).ToString());
                    Console.WriteLine("CPF: " + dataReader.GetValue(2).ToString());
                    Console.WriteLine("Telefone: " + dataReader.GetValue(3).ToString());
                    Console.WriteLine("Descriçao: " + dataReader.GetValue(4).ToString());
                    Console.WriteLine("Categoria: " + dataReader.GetValue(5).ToString());

                }

                sqlConnection.Close();
                sqlConnection.Open();


                Console.WriteLine("Digite o id a ser excluido");
                int id = int.Parse(Console.ReadLine());
                string deleteQuery = "DELETE FROM cliente WHERE  id= " + id + "";
                SqlCommand deletecmd = new SqlCommand(deleteQuery, sqlConnection);
                deletecmd.ExecuteNonQuery();
                Console.WriteLine("Usuario excluido com sucesso");

                Console.WriteLine(" 1) voltar ao  Menu Cliente\t  2) Voltar ao  Menu Inicial");
                int n = int.Parse(Console.ReadLine());


                if (n < 1 || n > 4)
                {
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
                    menu.Menu_cliente();
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
                Console.WriteLine(e.Message);
            }

        }
    }
}