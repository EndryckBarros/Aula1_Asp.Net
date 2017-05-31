using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula2505.Controller
{
    public static class CategoriaController
    {
        private static BaseDadosContainer contexto = new BaseDadosContainer();

        public static void Adicionar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public static List<Categoria> Listar()
        {
            return contexto.Categorias.ToList();
        }

        public static Categoria Localizar(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public static Categoria LocalizarPeloNome(string nome)
        {
            return contexto.Categorias.FirstOrDefault(x => x.Nome.Equals(nome));
        }

        public static void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State = EntityState.Modified;
            contexto.SaveChanges();
        }

       public static void Excluir(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

    }
}