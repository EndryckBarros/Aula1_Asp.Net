
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
            contexto.ClubeSet.Add(clube);
            contexto.SaveChanges();
        }

        public static List<Clube> Listar()
        {
            return contexto.ClubeSet.ToList();
        }

        public static Clube Localizar(int id)
        {
            return contexto.ClubeSet.Find(id);
        }

        public static Clube LocalizarPeloJogador(string Jogador)
        {
            return contexto.ClubeSet.FirstOrDefault(x => x.Jogador.Equals(Jogador));
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