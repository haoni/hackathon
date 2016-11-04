using Hackathon.Infra.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Service.Service.Interface
{
    public interface ITesteService
    {
        Teste Buscar(int id);

        void Inserir(Teste teste);
    }
}
