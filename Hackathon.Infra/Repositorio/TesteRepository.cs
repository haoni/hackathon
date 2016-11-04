using Hackathon.Infra.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Hackathon.Infra.DataModels;
using Hackathon.Infra.DataContext;

namespace Hackathon.Infra.Repositorio
{
    public class TesteRepository : ITesteRepository
    {
        public IHackathonDataContext _context { get; set; }

        public TesteRepository(IHackathonDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Teste> Listar(Func<Teste,bool> predicate)
        {
            return _context.Testes.Where(predicate);
        }

        public int Inserir(Teste teste)
        {
            return Convert.ToInt32(_context.InsertWithIdentity(teste));
        }

        public int Atualizar(Teste teste)
        {
            return Convert.ToInt32(_context.Update(teste));
        }

        public Teste Buscar(int id)
        {
            return _context.Testes.Single(p => p.Id == id);
        }

        public int Apagar(int id)
        {
            var teste= _context.Testes.Single(p => p.Id == id);
            return Convert.ToInt32(_context.Delete(teste));
        }
    }
}