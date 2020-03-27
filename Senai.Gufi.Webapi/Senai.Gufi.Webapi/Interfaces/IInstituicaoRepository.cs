using Senai.Gufi.Webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.Webapi.Interfaces
{
    interface IInstituicaoRepository
    {
        List<Instituicao> Listar();

        Instituicao BuscarPorId(int id);

        void Cadastrar(Instituicao novaInstituicao);

        void Atualizar(int id, Instituicao instituicaoAtualizada);

        void Deletar(int id);
    }
}
