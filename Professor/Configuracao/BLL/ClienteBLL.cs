﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            //ClienteDAL clienteDAL= new ClienteDAL(); chamando o método inserir de uma outra forma
            new ClienteDAL().Inserir(_cliente);

        }
        public List<Cliente> BuscarTodos()
        {
            return new ClienteDAL().BuscarTodos();
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            return new ClienteDAL().BuscarPorNome(_nome);
        }
        public Cliente BuscarPorId(int _id)
        {
            return new ClienteDAL().BuscarPorId(_id);
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            return new ClienteDAL().BuscarPorCPF(_CPF);
        }
        public void Alterar(Cliente _cliente)
        {
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }
    }
}