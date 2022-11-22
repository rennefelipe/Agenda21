using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Lib.DAO.Produtos
{
    public class DadosProduto
    {


        public string id_produto { get; set; }
        public string id_produto_grupo { get; set; }
        public string Nome_produto { get; set; }
        public string Descricao { get; set; }
        public string Codigo_Interno { get; set; }
        public string Data_Cadastro { get; set; }
        public string Status { get; set; }

        public DadosProduto(string id_produto
                            , string id_produto_grupo
                            , string nome_produto
                            , string descricao
                            , string codigo_Interno
                            , string data_Cadastro
                            , string status)
        {
            this.id_produto = id_produto;
            this.id_produto_grupo = id_produto_grupo;
            Nome_produto = nome_produto;
            Descricao = descricao;
            Codigo_Interno = codigo_Interno;
            Data_Cadastro = data_Cadastro;
            Status = status;
        }





        //public string cep { get; set; }
        //public string logradouro { get; set; }
        //public string complemento { get; set; }
        //public string bairro { get; set; }
        //public string localidade { get; set; }
        //public string uf { get; set; }
        //public string ibge { get; set; }
        //public string gia { get; set; }
        //public string ddd { get; set; }
        //public string siafi { get; set; }
    }
}


 


