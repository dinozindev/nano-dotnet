﻿
using FiapSmartCity.Models;
using FiapSmartCity.Repository.Context;
using System.Collections.Generic;
using System.Linq;


namespace FiapSmartCity.Repository
{
    public class TipoProdutoRepository
    {
        // Propriedade que terá a instância do DataBaseContext
        private readonly DataBaseContext context;

        public TipoProdutoRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }


        public IList<TipoProduto> Listar()
        {
            return context.TipoProduto.ToList();
        }


        public TipoProduto Consultar(int id)
        {
            return context.TipoProduto.Find(id);
        }


        public void Inserir(TipoProduto tipoProduto)
        {
            context.TipoProduto.Add(tipoProduto);
            context.SaveChanges();
        }

        public void Alterar(TipoProduto tipoProduto)
        {
            context.TipoProduto.Update(tipoProduto);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var tipoProduto = new TipoProduto()
            {
                IdTipo = id
            };

            context.TipoProduto.Remove(tipoProduto);
            context.SaveChanges();
        }

    }
}
