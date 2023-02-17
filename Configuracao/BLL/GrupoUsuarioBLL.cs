﻿using DAL;
using Models;
using System.Data.SqlClient;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo) VALUES (@NomeGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o nome do grupo no banco: " + ex.Message);
            }
            finally 
            { 
                cn.Close(); 
            }
        }
        public GrupoUsuario Buscar(GrupoUsuario grupoUsuario)
        {
            return new GrupoUsuario();
        }
        public void Alterar(GrupoUsuario grupoUsuario)
        {

        }
        public void Excluir(int _id)
        {

        }
    }
}
