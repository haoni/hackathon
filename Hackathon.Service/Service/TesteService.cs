using Hackathon.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.Infra.DataModels;
using Hackathon.Infra.UnitOfWork;

namespace Hackathon.Service.Service
{
    public class TesteService : ITesteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TesteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Teste Buscar(int id)
        {
            return _unitOfWork.TesteRepository.Buscar(id);
        }

        public void Inserir(Teste teste)
        {
            _unitOfWork.TesteRepository.Inserir(teste);
        }
    }
}
