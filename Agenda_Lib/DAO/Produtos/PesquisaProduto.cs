
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;

namespace Agenda_Lib.DAO.Produtos
{
    public class PesquisaProduto
    {
        /// <summary>
        ///  Chave de Conexao ao banco de dados
        /// </summary>
        string ChaveConexao = "Data Source=10.39.45.44;" +
            "Initial Catalog=TI_Noite;Persist Security Info=True;User " +
            "ID=Turma2022;Password=Turma2022@2022";

        /// <summary>
        /// Processo de consulta de Produto no banco de dados
        /// </summary>
        /// <param name="p_CEP">selecione 1 para ser Pesquisado</param>
        /// <returns> retorno sera o select da base de dados com o valor da consulta</returns>
        public DataSet List_Produto(string p_Produto)
        {
            DataSet DataSetProduto = new DataSet();
            try
            {
                SqlConnection Conexao = new SqlConnection(ChaveConexao);
                Conexao.Open();
                string wQuery = $"select * from Produto where Nome_produto like '%{p_Produto}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
                adapter.Fill(DataSetProduto);
                Conexao.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return DataSetProduto;
        }


        /// <summary>
        ///  Apagar registro de Produto na tabela Produto
        /// </summary>
        /// <param name="p_Produto">Informe o Produto que devera ser apaganda.</param>
        public void Apagar_Produto(string p_Produto)
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(ChaveConexao);
                Conexao.Open();
                String oQueryDelete = $"delete from Produto where Nome_produto = '{p_Produto}' ";
                SqlCommand Cmd = new SqlCommand(oQueryDelete, Conexao);
                Cmd.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Alterar_Produto(
               string p_Nome_produto,
               string p_Descricao,
               string p_Codigo_Interno,
               string p_Status
            )
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(ChaveConexao);
                Conexao.Open();
                String oQueryUpdate = "UPDATE cep " +
                       $"  SET Nome_produto  = '{p_Nome_produto}'    " +
                       $"     ,Descricao = '{p_Descricao}'    " +
                       $"     ,Codigo_Intern   = '{p_Codigo_Interno}'    " +
                       $"     ,Status  = '{p_Status}'    " ;

                SqlCommand Cmd = new SqlCommand(oQueryUpdate, Conexao);
                Cmd.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Adicionar_Produto(
            string p_id_produto,
            string p_id_produto_grupo,
            string p_Nome_produto,
            string p_Descricao,
            string p_Codigo_Interno,
            string p_Data_Cadastro,
            string p_Status
            
         )
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(ChaveConexao);
                Conexao.Open();
                String oQueryUpdate = "INSERT INTO Produto " +
                       $"        ([id_produto]           " +
                       $"        ,[id_produto_grupo]    " +
                       $"        ,[Nome_produto]   " +
                       $"        ,[Descricao]        " +
                       $"        ,[Codigo_Interno]    " +
                       $"        ,[Data_Cadastro]            " +
                       $"        ,[Status]          " +
                       
                       $"  VALUES " +
                       $"        ('{p_id_produto}'" +
                       $"        ,'{p_id_produto_grupo}'" +
                       $"        ,'{p_Nome_produto}'" +
                       $"        ,'{p_Descricao}'" +
                       $"        ,'{p_Codigo_Interno}'" +
                       $"        ,'{p_Data_Cadastro}'" +
                       $"        ,'{p_Status}'" ;

                SqlCommand Cmd = new SqlCommand(oQueryUpdate, Conexao);
                Cmd.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
 

