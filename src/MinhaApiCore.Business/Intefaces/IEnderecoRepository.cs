using System;
using System.Threading.Tasks;
using MinhaApiCore.Business.Models;

namespace MinhaApiCore.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}