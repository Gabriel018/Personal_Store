using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personal_Style
{
      public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(conex);
                sqlConnection.Open();
                Console.WriteLine("Conectado com sucesso");

                Diretor dir = new Diretor();

                Menus menu = new Menus();

                Console.WriteLine("=================================");
                Console.WriteLine(" bem vindo sistema Personal_style");
                Console.WriteLine("=================================");
                Console.WriteLine("1) Cadastrar diretor\t 2) Cadastrar vendedor\t  3) Cadastrar cliente\t  4) relatorio de math  ");
                Console.WriteLine("");
                Console.WriteLine("Digite o número da opção desejada: ");
                int menuOption = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {

                    case 1:
                        Console.Clear();

                        menu.Menu_diretor();
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        Console.WriteLine("Voce nao possui a opçao Premium");
                        break;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Dados nao foram salvos", (e.Message));


            }

            Console.ReadLine();

        }
    }
}

