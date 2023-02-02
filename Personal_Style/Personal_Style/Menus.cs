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

    }
}

