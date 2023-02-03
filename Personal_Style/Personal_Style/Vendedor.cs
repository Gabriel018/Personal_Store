using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personal_Style
{
    class Vendedor
    {
        public void Salvar()

        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            Console.WriteLine("digite seu nome");
            string nome_add = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            string cpf_add = (Console.ReadLine());
            Console.WriteLine("digite seu telefone");
            string telefone_add = (Console.ReadLine());
            Console.WriteLine("descreve seu estilo ");
            string descricao_add = (Console.ReadLine());
            Console.WriteLine("digite uma dos estilos :  casual: exentrico: esportivo: criativo: urbano ");
            string categoria_add = (Console.ReadLine());



            string add_vendedor = "INSERT INTO vendedor(nome, cpf, telefone, descricao, categoria) " +
              "VALUES('" + nome_add + "','" + cpf_add + "'," + telefone_add + ",'" + descricao_add + "','" + categoria_add + "')"; ;
            SqlCommand salvar_dados = new SqlCommand(add_vendedor, sqlConnection);
            salvar_dados.ExecuteNonQuery();
            Console.WriteLine("Arquivo Salvo");
            Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                menu.Menu_vendedor();
            }

            else
            {

            }
        }


        public void editar_vendedor()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            Console.WriteLine("Digite o id para alteraraço");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("digte o nome a ser alterado");
            string nome = Console.ReadLine();
            Console.WriteLine("digte o cpf a ser alterado");
            string cpf = (Console.ReadLine());
            Console.WriteLine("digite o telefone a ser alterado");
            string telefone = (Console.ReadLine());
            Console.WriteLine("digite a descriçao a ser alterada");
            string descricao_add = (Console.ReadLine());
            Console.WriteLine("escolha sua categoria");
            string categoria_add = (Console.ReadLine());


            string update_query = "UPDATE vendedor SET nome = '" + nome + "', cpf = " + cpf + ", telefone = " + telefone + ", descricao ='" + descricao_add + "', categoria ='" + categoria_add + "' WHERE  id = " + id + " ";
            SqlCommand updat_command = new SqlCommand(update_query, sqlConnection);
            updat_command.ExecuteNonQuery();
            Console.WriteLine("os dados foram alterador");

            Console.WriteLine(" 1) voltar ao  Menu Vendedor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                menu.Menu_vendedor();
            }

            else
            {

            }
        }

        public void visualizar_vendedor()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
            string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            string selecionar = "SELECT * FROM vendedor";
            SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
            SqlDataReader dataReader = visualizar.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(0).ToString() + "\tNome:" + dataReader.GetValue(1).ToString() + "\tCPF:" + dataReader.GetValue(2).ToString() + "\tTelefone:" + dataReader.GetValue(3).ToString());
                Console.WriteLine("Descriçao:" + dataReader.GetValue(4).ToString());
                Console.WriteLine("Categoria:" + dataReader.GetValue(5).ToString());

            }

            Console.WriteLine(" 1) voltar ao  Menu Vendedor\t  2) Voltar ao  Menu Inicial");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                menu.Menu_vendedor();
            }

            else
            {

            }

        }


        public void excluir_vendedor()
        {
            try
            {
                Menus menu = new Menus();
                SqlConnection sqlConnection;
                string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
                sqlConnection = new SqlConnection(conex);
                sqlConnection.Open();
                Console.WriteLine("Digite o id a ser excluido");
                int id = int.Parse(Console.ReadLine());
                string deleteQuery = "DELETE FROM vendedor WHERE  id= " + id + "";
                SqlCommand deletecmd = new SqlCommand(deleteQuery, sqlConnection);
                deletecmd.ExecuteNonQuery();
                Console.WriteLine("Usuario excluido com sucesso");

                Console.WriteLine(" 1) voltar ao  Menu Diretor\t  2) Voltar ao  Menu Inicial");
                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    Console.Clear();
                    menu.Menu_vendedor();
                }

                else
                {

                }

            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
        }
    }
}
    
    

