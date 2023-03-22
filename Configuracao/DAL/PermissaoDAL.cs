﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Permissao(Descricao) VALUES (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma descrição no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Permissao BuscarPorId(int _id)
        {
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.IdDescricao, Permissao.Descricao FROM Permissao
                                    INNER JOIN PermissaoGrupoUsuario ON Permissao.IdDescricao = PermissaoGrupoUsuario.IdGrupoUsuario
                                    WHERE IdGrupoUsuario = @IDGrupoUsuario";
                //cmd.CommandText = @"SELECT TOP 100 IdDescricao, Descricao FROM Permissao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
                //cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar uma permissão no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return permissao;
        }
        public List<Permissao> BuscarPorIdGrupo(int _idGrupoUsuario)
        {
            List<Permissao> permissaos = new List<Permissao>();
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.IdDescricao, Permissao.Descricao FROM GrupoUsuario
                                    INNER JOIN PermissaoGrupoUsuario ON GrupoUsuario.IDGrupoUsuario = PermissaoGrupoUsuario.IdGrupoUsuario
									inner join Permissao on PermissaoGrupoUsuario.IDDescricao = Permissao.IDDescricao
                                    WHERE GrupoUsuario.IDGrupoUsuario = @IDGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDGrupoUsuario", _idGrupoUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao= new Permissao();
                        permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario(permissao.IdDescricao);
                        permissaos.Add(permissao);
                    }
                }
                return permissaos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Grupo de Usuarios: " + ex.Message); ;
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarTodasPermissoes()
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdDescricao, Descricao FROM Permissao order by Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario(permissao.IdDescricao);

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Permissões: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Permissao SET Descricao = @Descricao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _permissao.IdDescricao);
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cn.Open();
                cmd.ExecuteNonQuery();
                //cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar uma descrição no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM Permissao WHERE IdDescricao = @IdDescricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _permissao.IdDescricao);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma descrição no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Permissao> BuscarPermissaoPorNome(string _nomePermissao)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdDescricao, Descricao FROM Permissao order by Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
                        permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario(permissao.IdDescricao);

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Permissões: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        //public bool ExisteRelacionamento(int idgrupoUsuario, int idDescricao)
        //{
        //    SqlConnection cn = new SqlConnection();
        //    SqlCommand cmd = new SqlCommand();

        //    try
        //    {
        //        cn.ConnectionString = Conexao.StringDeConexao;
        //        cmd.Connection = cn;
        //        cmd.CommandText = @"SELECT 1 AS Retorno FROM  UsuarioGrupoUsuario 
        //                            WHERE Id_Usuario = @Id_Usuario and Id_GrupoUsuario = @Id_GrupoUsuario";
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.Parameters.AddWithValue("@IDGrupoUsuario", idgrupoUsuario);
        //        cmd.Parameters.AddWithValue("@Id_Descricao", idDescricao);

        //        cn.Open();

        //        using (SqlDataReader rd = cmd.ExecuteReader())
        //        {
        //            while (rd.Read())
        //            {
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public bool ExistirRelacionamento(int idPermissao, int id)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS Retorno FROM  PermissaoGrupoUsuario 
                                    WHERE IDDescricao = @IDDescricao and IDGrupoUsuario = @IDGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDDescricao", idPermissao);
                cmd.Parameters.AddWithValue("@IDGrupoUsuario", id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um usuário: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarPermissao(int idPermissao, int id)
        {
            throw new NotImplementedException();
        }

        public void AdicionarDescricaoGrupo(int idgrupoUsuario, int idDescricao)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO PermissaoGrupoUsuario(IDDescricao, IDDescricao) 
                                    VALUES (@IDDescricao, @IDDescricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IDDescricao", idgrupoUsuario);
                cmd.Parameters.AddWithValue("@IDDescricao", idDescricao);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma permissão no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        //public bool ValidarDescricao(int idPermissaoLogado, int idPermissao)
        //{
        //    SqlConnection cn = new SqlConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    Permissao permissao = new Permissao();
        //    try
        //    {
        //        cn.ConnectionString = Conexao.StringDeConexao;
        //        cmd.Connection = cn;
        //        cmd.CommandText = @"SELECT Permissao.IdDescricao, Permissao.Descricao FROM Permissao
        //                            INNER JOIN PermissaoGrupoUsuario ON Permissao.IdDescricao = PermissaoGrupoUsuario.IdGrupoUsuario
        //                            WHERE IdGrupoUsuario = @IDGrupoUsuario";
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        //cmd.Parameters.AddWithValue("@IDGrupoUsuario", _idGrupoUsuario);
        //        cn.Open();
        //        using (SqlDataReader rd = cmd.ExecuteReader())
        //        {
        //            if (rd.Read())
        //            {
        //                permissao = new Permissao();
        //                permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
        //                permissao.Descricao = rd["Descricao"].ToString();
        //                GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
        //                permissao.GrupoUsuarios = grupoUsuarioDAL.BuscarPorIdUsuario(permissao.IdDescricao);
        //                //permissaos.Add(permissao);
        //            }
        //        }
        //        //return permissaos;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Ocorreu um erro ao tentar buscar Grupo de Usuarios: " + ex.Message); ;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}
    }
}
