using FiapSmartCity.Models;
using FiapSmartCity.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FiapSmartCity.Repository
{
    public class ProdutoRepository
    {
        // Propriedade que terá a instância do DataBaseContext
        private readonly DataBaseContext context;

        public Produto Consultar(int id)
        {
            var prod = context.Produto.Include(t => t.Tipo)
                .FirstOrDefault(p => p.IdProduto == id);
            return prod;
        }

        public IList<Produto> ConsultarProdutosPorTipo(int idTipo)
        {
            // Consulta a lista de produtos de um determinado tipo.
            var tipoProduto =
                context.TipoProduto
                    .Include(t => t.Produtos)
                    .FirstOrDefault(t => t.IdTipo == idTipo);

            return tipoProduto.Produtos;
        }
    }
}
