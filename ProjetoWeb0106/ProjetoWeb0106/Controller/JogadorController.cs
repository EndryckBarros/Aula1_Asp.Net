using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoWeb0106.Models;
using System.Data.Entity;

namespace ProjetoWeb0106.Controller
{
    public class JogadorController
    {
        
        private static Clube2DBContainer contexto = new Clube2DBContainer();

        public static void Adicionar(Jogador jogador)
        {
            contexto.Jogadores.Add(jogador);
            contexto.SaveChanges();
        }

        public static List<Jogador> Listar()
        {
            return contexto.Jogadores.ToList();
        }

        public static Jogador Localizar(int id)
        {
            return contexto.Jogadores.Find(id);
        }

        public static Jogador LocalizarPeloJogador(string Nome)
        {
            return contexto.Jogadores.FirstOrDefault(x => x.Nome.Equals(Nome));
        }

        public static void Editar(Jogador jogador)
        {
            contexto.Entry(jogador).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public static void Excluir(Jogador jogador)
        {
            contexto.Entry(jogador).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}