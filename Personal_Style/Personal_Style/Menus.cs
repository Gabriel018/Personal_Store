using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Style
{
    public class Menus
    {    


        public void Menu_diretor()

        {

            Diretor dir = new Diretor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|===========================================================================================|");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                 MENU DIRETOR                                              |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|===========================================================================================|");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1)Cadastrar\t 2)Editar\t3) Excluir\t4) Visualizar\t5) Menu principal ");


            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            int menuOption = Convert.ToInt32(Console.ReadLine());



            if (menuOption < 1 || menuOption > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
            }
            else

                switch (menuOption)
            {

                case 1:

                    dir.Salvar();
                    break;
                case 2:
                    dir.editar();

                    break;
                case 3:
                    dir.exluir();
                    break;
                case 4:
                    dir.visualizar();
                    break;
                
                case 5:
                        Console.Clear();
                     Program.Main();
                     break;
                }


        }


        public void Menu_cliente()

        {

            Cliente cliente = new Cliente();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("============================================================================================");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                    MENU CLIENTE                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("                                                                                           |");
            Console.WriteLine("============================================================================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1)Cadastrar\t 2)Editar\t3) Excluir\t4) Visualizar\t5) Menu principal ");
            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            int menuOption = Convert.ToInt32(Console.ReadLine());




            if (menuOption < 1 || menuOption > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
            }
            else

                switch (menuOption)
            {

                case 1:
                    
                    cliente.Salvar_Cliente();
                    break;
                case 2:
                    cliente.editar_cliente();

                    break;
                case 3:
                    cliente.exluir_cliente();
                    break;
                case 4:
                    cliente.visualizar_cliente();
                    break;
                case 5: 
                    Console.Clear();
                    Program.Main();
                            break;


            }

        }

        public void Menu_vendedor()

        {

            Vendedor vendedor = new Vendedor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|===========================================================================================|");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                 MENU VENDEDOR                                             |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|===========================================================================================|");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1)Cadastrar\t 2)Editar\t3) Excluir\t4) Visualizar\t5) Menu principal ");

            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            int menuOption = Convert.ToInt32(Console.ReadLine());




            if (menuOption < 1 || menuOption > 6 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
            }
            else
            {

                switch (menuOption)
                {
                    case 1:

                        vendedor.Salvar();
                        break;
                    case 2:
                        vendedor.editar_vendedor();
                        break;
                    case 3:
                        vendedor.excluir_vendedor();
                        break;
                    case 4:
                        vendedor.visualizar_vendedor();
                        break;
                        case 5:
                        Console.Clear();
                        Program.Main();
                        break;
                }



            }

        
        }



        public void Menu_relatorio()

        {    
            Relatorio rel = new Relatorio();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|===========================================================================================|");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                 RELATORIOS                                                |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|                                                                                           |");
            Console.WriteLine("|===========================================================================================|");
            Console.ForegroundColor = ConsoleColor.Green;
            rel.relatorio();



           


        }
    }


    
}
