using System;
using System.Threading.Tasks;
using MinhaApiCore.Business.Intefaces;
using MinhaApiCore.Business.Models;
using MinhaApiCore.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace MinhaApiCore.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}