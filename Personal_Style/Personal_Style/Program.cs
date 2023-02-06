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
          public static void Main()
        {
            SqlConnection sqlConnection;

             
             string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            try
            {
              

                sqlConnection = new SqlConnection(conex);
                sqlConnection.Open();
                
                Diretor dir = new Diretor();
               
                Menus menu = new Menus();

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("|===========================================================================================|");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                 BEM VINDO AO PERSONAL STYLE SYSTEM                        |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|                                                                                           |");
                Console.WriteLine("|===========================================================================================|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1) Menu Diretor \t 2)Menu Vendedor\t3) Menu Cliente \t4) Relatorio de Math");
                Console.WriteLine("Digite o número da opção desejada: ");
                int menuOption = Convert.ToInt32(Console.ReadLine());


                if (menuOption < 1 || menuOption > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida!");
                   
                }
                else

                    switch (menuOption)
                {

                    case 1:
                        
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(".");
                                System.Threading.Thread.Sleep(100);
                            }
                            Console.Clear();
                            menu.Menu_diretor();
                        break;
                    case 2:
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(".");
                                System.Threading.Thread.Sleep(100);
                            }
                            Console.Clear();
                        menu.Menu_vendedor();
                        break;
                    case 3:
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(".");
                                System.Threading.Thread.Sleep(100);
                            }
                            Console.Clear();
                        menu.Menu_cliente();
                        break;
                    case 4:
                            for (int i = 0; i < 10; i++)
                            {   
                                Console.Write(".");
                                System.Threading.Thread.Sleep(100);
                            }
                            Console.Clear();
                        menu.Menu_relatorio();
                        break;
                }
            }

            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro verifique se digitou os dados corretos..", (e.Message));


            }

            
            Console.ReadLine();

        }
    }
}

