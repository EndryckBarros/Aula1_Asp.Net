
using ProjetoAula0106.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoAula0106.Controller
{
    public static class ClubeController
    {
        private static BaseDadosContainer contexto = new BaseDadosContainer();

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

        public static Clube LocalizarPeloJogador(string Jogador)
        {
            return contexto.Clubes.FirstOrDefault(x => x.Jogador.Equals(Jogador));
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