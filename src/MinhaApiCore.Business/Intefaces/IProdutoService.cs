﻿using System;
using System.Threading.Tasks;
using MinhaApiCore.Business.Models;

namespace MinhaApiCore.Business.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}