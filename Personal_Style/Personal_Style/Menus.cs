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

            Console.WriteLine("=================================");
            Console.WriteLine("           Menu Diretor          ");
            Console.WriteLine("=================================");
            Console.WriteLine("1) Cadastrar\t 2) Editar\t  3) Exluir\t  4) Visualizar ");
            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            int menuOption = Convert.ToInt32(Console.ReadLine());

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
            }


        }


        public void Menu_cliente()

        {

            Cliente cliente = new Cliente();


            Console.WriteLine("=================================");
            Console.WriteLine("           Menu Cliente          ");
            Console.WriteLine("=================================");
            Console.WriteLine("1) Cadastrar\t 2) Editar\t  3) Exluir\t  4) Visualizar ");
            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            int menuOption = Convert.ToInt32(Console.ReadLine());

            switch (menuOption)
            {

                case 1:

                    cliente.Salvar_Cliente();
                    break;
                case 2:
                    

                    break;
                case 3:
                    
                    break;
                case 4:
                    cliente.visualizar_cliente();
                    break;
            }

        }



        public void Menu_vendedor()

        {

            Vendedor vendedor = new Vendedor();


            Console.WriteLine("=================================");
            Console.WriteLine("           Menu Vendedor        ");
            Console.WriteLine("=================================");
            Console.WriteLine("1) Cadastrar\t 2) Editar\t  3) Exluir\t  4) Visualizar ");
            Console.WriteLine("");
            Console.WriteLine("Digite o número da opção desejada: ");
            int menuOption = Convert.ToInt32(Console.ReadLine());

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
            }


        }
    }
}
