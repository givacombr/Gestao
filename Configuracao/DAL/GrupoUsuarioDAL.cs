using Models;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
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
        public GrupoUsuario Buscar(GrupoUsuario _grupousuario)
        {
            GrupoUsuario grupo = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT TOP 100 IdGrupoUsuario, NomeGrupo FROM GrupoUsuario WHERE IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _grupousuario.IdGrupoUsuario);
               
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupo = new GrupoUsuario();
                        grupo.IdGrupoUsuario = Convert.ToInt32(rd["IdGrupoUsuario"]);
                        grupo.NomeGrupo = rd["NomeGrupo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar listar grupo." + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return grupo;
        }
        public void Alterar(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario SET NomeGrupo = @NomeGrupo WHERE IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("IdGrupoUsuario", _grupousuario.IdGrupoUsuario);
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cn.Open();
                cmd.BeginExecuteNonQuery();
                //cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar o nome do grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM GrupoUsuario WHERE IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _grupoUsuario.IdGrupoUsuario);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar excluir o grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
