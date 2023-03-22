using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {

            if (_grupousuario.NomeGrupo.Length <= 3 || _grupousuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_grupousuario);
        }
        public List<GrupoUsuario> BuscarPorId(int _idGrupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarPorId(_idGrupoUsuario);
        }
        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarTodosGrupos();
        }
        public List<GrupoUsuario> BuscarGrupoPorNome(string _nomeGrupo)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarGrupoPorNome(_nomeGrupo);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.NomeGrupo.Length <= 3 || _grupoUsuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Alterar(_grupoUsuario);
        }
        public void Excluir(int _idgrupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Excluir(_idgrupoUsuario);
        }
        /*public void AdicionarDescricaoGrupo(int _idgrupoUsuario, int _idDescricao)
        {
                //ValidarPermissao(10);
            if (new PermissaoDAL().ExistirRelacionamento(_idgrupoUsuario, _idDescricao))
            {
                throw new Exception("Descrição já vinculado ao grupo.");
            }
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.AdicionarDescricaoGrupo(_idgrupoUsuario, _idDescricao);
        }*/

        //private void ValidarPermissao(int _idDescricao)
        //{
        //    if (!new PermissaoDAL().ValidarPermissao(Constantes.IdPermissaoLogado, _idDescricao))
        //        throw new Exception("Você não tem permissão para executar esta operação.");
        //}

        public void RemoverDescricaoGrupo(int _idgrupoUsuario, int _idDescricao)
        {
            // new PermissaoDAL().RemoverDescricaoGrupo(_idgrupoUsuario, _idDescricao);
        }
    }
}
