﻿using DAL;
using Models;
using System.Data.SqlClient;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 3 || _permissao.Descricao.Length >= 250)
                throw new Exception("A descrição informada deverá conter de 3 a 250 caracteres. ");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public Permissao BuscarPorId(int _id)
        {
            //if (_permissao.Descricao.Length <= 3 || _permissao.Descricao.Length >= 250)
            //  throw new Exception("A Busca informada deverá conter de 3 a 250 caracteres. ");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPorId(_id);

        }
        public void Alterar(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 3 || _permissao.Descricao.Length >= 250)
                throw new Exception("A alteração informada deverá conter de 3 a 250 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);
        }
        public void Excluir(Permissao _permissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_permissao);
        }
    }
}
