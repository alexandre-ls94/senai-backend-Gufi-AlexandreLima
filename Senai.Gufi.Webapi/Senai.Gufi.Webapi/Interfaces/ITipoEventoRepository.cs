using Senai.Gufi.Webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.Webapi.Interfaces
{
    interface ITipoEventoRepository
    {
        List<TipoEvento> Listar();

        TipoEvento BuscarPorId(int id);

        void Cadastrar(TipoEvento novoTipoEvento);

        void Atualizar(int id, TipoEvento tipoEventoAtualizado);

        void Deletar(int id);
    }
}
