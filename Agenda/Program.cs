using System;
using System.Data;
using System.Data.SqlClient;
using Agenda_Lib.DAO.CEP;
using Agenda_Lib.DAO.Produtos;

namespace Agenda

{
    public class Program
    {
       // static object p_Produto;
       
        public static DataSet DataSetProduto { get; set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Digite 1 para lista de produtos: ");
            Console.WriteLine("Digite 2 para Cadastra produtos: ");
            Console.WriteLine("Digite 3 para alterar produtos: ");
            Console.WriteLine("Digite 4 para excluir produtos: ");
            Todos_Produto();
            
            

        }
        /// <summary>
        /// lista de produto na tela
        ///
        /// </summary>
        public static void Todos_Produto()
        {
            string ItemSelecionado = Console.ReadLine();
            PesquisaProduto OProduto = new PesquisaProduto();
            DataSet OListProduto = new DataSet();

            switch (ItemSelecionado.ToUpper())
            {
                case "1":
                    Console.WriteLine("Lista de produtos: ");

                    try
                    {

                        PesquisaProduto oPesquisaProduto = new PesquisaProduto();

                        
                        
                        OListProduto = oPesquisaProduto.List_Produto("");

                        foreach (DataRow LinhaResulta in OListProduto.Tables[0].Rows)
                        {
                            Console.WriteLine(LinhaResulta["Nome_Produto"].ToString());
                            Console.WriteLine();
                            Console.WriteLine(LinhaResulta["Descricao"].ToString());
                            //Console.WriteLine(LinhaResulta["id_Produto"].ToString());
                        }

                        Console.WriteLine("Pressione Enter para continuar");
                        Console.ReadLine();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Cadastro produtos: ");
                    }
                    return ;

                case "2":
                    Console.WriteLine("Cadastro produtos: ");


                    break;
                case "3":
                    Console.WriteLine("alterar produtos: ");
                    break;
                case "4":
                    Console.WriteLine("excluir produtos: ");
                    break;


                default:
                    Console.WriteLine("Codigo Errado!!!!: ");
                    break;
            }

        }

    }
}

