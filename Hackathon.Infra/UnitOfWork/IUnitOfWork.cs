using Hackathon.Infra.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        ITesteRepository TesteRepository { get; }
    }
}