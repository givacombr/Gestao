using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();//cn é um objeto de conexao

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText =   @"INSERT INTO Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo)
                                      VALUES (@Nome, @NomeUsuario, @CPF, @Email, @Senha, @Ativo)";//com o arroba ele aceita a quebra de linha

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable BuscarUsuarioPorNome(string _nomeUsuario)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarUsuarioPorNome";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.VarChar);
                pnome.Value = _nomeUsuario;

                da.SelectCommand.Parameters.Add(pnome);

                cn.Open() ;
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no Servidor SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            { 
                cn.Close();
            }
        }
        public void Alterar(Usuario usuario)
        {

        }
        public void Excluir(int _id)
        {
            
        }
    }
}