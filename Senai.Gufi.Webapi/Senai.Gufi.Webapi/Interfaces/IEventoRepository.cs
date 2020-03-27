using Senai.Gufi.Webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.Webapi.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> Listar();

        Evento BuscarPorId(int id);

        void Cadastrar(Evento novoEvento);

        void Atualizar(int id, Evento eventoAtualizado);

        void Deletar(int id);

        //List<Evento> ListarPorUsuario(int id);
    }
}
