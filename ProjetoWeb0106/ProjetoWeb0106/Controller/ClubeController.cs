using ProjetoWeb0106.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoWeb0106.Controller
{
    public class ClubeController
    {
        private static Clube2DBContainer contexto = new Clube2DBContainer();

        public static void Adicionar(Clube clube)
        {
            contexto.Clubes.Add(clube);
            contexto.SaveChanges();
        }

        public static List<Clube> Listar()
        {
            return contexto.Clubes.ToList();
        }

        public static Clube Localizar(int id)
        {
            return contexto.Clubes.Find(id);
        }

        public static Clube LocalizarPeloNome(string Nome)
        {
            return contexto.Clubes.FirstOrDefault(x => x.Nome.Equals(Nome));
        }

        public static void Editar(Clube clube)
        {
            contexto.Entry(clube).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public static void Excluir(Clube clube)
        {
            contexto.Entry(clube).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

    }
}