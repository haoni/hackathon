
using Hackathon.Infra.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackathon.Infra.Repositorio.Interface
{
    public interface ITesteRepository
    {
        IEnumerable<Teste> Listar(Func<Teste, bool> predicate);

        int Inserir(Teste teste);

        int Atualizar(Teste teste);

        Teste Buscar(int id);

        int Apagar(int id);
    }
}
