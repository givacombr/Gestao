using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FornecedorBLL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Inserir(_fornecedor);
        }
        public List<Fornecedor> BuscarTodos()
        {
            return new FornecedorDAL().BuscarTodos();
        }
        public List<Fornecedor> BuscarPorNome(String _nome)
        {
            return new FornecedorDAL().BuscarPorNome(_nome);
        }
        public Fornecedor BuscarPorId(int _id)
        {
            return new FornecedorDAL().BuscarPorId(_id);
        }
        public Fornecedor BuscarSite(String _site)
        {
            if (String.IsNullOrEmpty(_site))
                throw new Exception("Informe o site") { Data = { { "Id", 40 } } };

            return new FornecedorDAL().BuscarSite(_site);
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Alerar(_fornecedor);
        }
        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        }
    }
}
