﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO3C1_27e29
{
    class DAL_música
    // Dupla: Roseane Tamires e Rafael Barros 
    {
        private MySqlConnection conexao;
        private string string_conexao =

       "Persist security info = false; " +

       "server = localhost; " +

       "database = bd_gravadora; " +

       "user = root ; pwd=;";

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas ao conectar com o banco de dados. \nErro: " + e.Message);
            }

        }

        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Banco de Dados. \nErro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable executarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel. \nErro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
    }
}
