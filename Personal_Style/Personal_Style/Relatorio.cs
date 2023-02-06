using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Personal_Style
{
     public class Relatorio
    {
        public  void relatorio()
        {
            Menus menu = new Menus();
            SqlConnection sqlConnection;
              string conex = @"Data Source=DUKE\SQLEXPRESS;Initial Catalog=Personal_style;Integrated Security=True";
            //string conex = @"Data Source=DESKTOP-NG41UBG;Initial Catalog=Personal_Style;Integrated Security=True";
            sqlConnection = new SqlConnection(conex);
            sqlConnection.Open();
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("");
            Console.WriteLine("Math encontrados!!!");

            string selecionar = "SELECT * FROM vendedor INNER JOIN cliente ON cliente.categoria = vendedor.categoria";
            SqlCommand visualizar = new SqlCommand(selecionar, sqlConnection);
            SqlDataReader dataReader = visualizar.ExecuteReader();

            Console.WriteLine("Vendedores com cliente com a mesma categoria");
            Console.WriteLine("");
            while (dataReader.Read())
            {
              
          
                Console.WriteLine("Vendedor :"+dataReader.GetValue(1).ToString());
                Console.WriteLine("Cliente  : " + dataReader.GetValue(7).ToString());
                Console.WriteLine("Categoria : "  +dataReader.GetValue(5).ToString());
                Console.WriteLine("");


            }
            Console.WriteLine(" 1) Voltar ao Menu inicial");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.Clear();
                Program.Main();
            }

        }

    }
}
