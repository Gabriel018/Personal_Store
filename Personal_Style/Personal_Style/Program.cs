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
                Console.WriteLine("1) Menu Diretor\t 2) Menu Vendedor\t 3) Menu Cliente\t 4) Relatorio de math");
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
                        Console.Clear();
                        menu.Menu_vendedor();
                        break;
                    case 3:
                        Console.Clear();
                        menu.Menu_cliente();
                        break;
                    case 4:
                        Console.Clear();
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

