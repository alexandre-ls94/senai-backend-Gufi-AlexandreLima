﻿using Senai.Gufi.Webapi.Domains;
using Senai.Gufi.Webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.Webapi.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Evento eventoAtualizado)
        {
            Evento eventoBuscado = ctx.Evento.FirstOrDefault(e => e.IdEvento == id);

            eventoBuscado.NomeEvento = eventoAtualizado.NomeEvento;
            eventoBuscado.DataEvento = eventoAtualizado.DataEvento;
            eventoBuscado.Descricao = eventoAtualizado.Descricao;
            eventoBuscado.AcessoLivre = eventoAtualizado.AcessoLivre;
            eventoBuscado.IdInstituicao = eventoAtualizado.IdInstituicao;
            eventoBuscado.IdTipoEvento = eventoAtualizado.IdTipoEvento;

            ctx.Evento.Update(eventoBuscado);

            ctx.SaveChanges();
        }

        public Evento BuscarPorId(int id)
        {
            return ctx.Evento.FirstOrDefault(e => e.IdEvento == id);
        }

        public void Cadastrar(Evento novoEvento)
        {
            ctx.Evento.Add(novoEvento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Evento.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Evento> Listar()
        {
            return ctx.Evento.ToList();
        }

        //public List<Evento> ListarPorUsuario(int id)
        //{
        //    return ctx.Evento.
        //}
    }
}
