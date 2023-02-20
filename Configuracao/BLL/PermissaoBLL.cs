using DAL;
using Models;
using System.Data.SqlClient;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 15 || _permissao.Descricao.Length >= 250)
                throw new Exception("A descrição informada deverá conter de 15 a 250 caracteres. ");

            PermissaoDAL permissaoDAL= new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public Permissao Buscar(Permissao permissao)
        {
            return new Permissao();
        }
        public void Alterar(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 15 || _permissao.Descricao.Length >= 250)
                throw new Exception("A descirção informada deverá conter de 15 a 250 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public void Excluir(Permissao _permissao)
        {
            
        }
    }
}
