using Hackathon.Infra.Repositorio.Interface;

namespace Hackathon.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITesteRepository _testeRepository;

        public ITesteRepository TesteRepository
        {
            get
            {
                return _testeRepository;
            }
        }
    }
}
