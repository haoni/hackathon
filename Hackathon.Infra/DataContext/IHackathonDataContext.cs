using Hackathon.Infra.DataModels;
using LinqToDB;
using LinqToDB.Data;
using System.Data;

namespace Hackathon.Infra.DataContext
{
    public interface IHackathonDataContext
    {
        ITable<Teste> Testes { get; }

        int InsertWithIdentity<T>(T obj);

        int Update<T>(T obj);

        int Delete<T>(T obj);

        DataConnectionTransaction BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

        IDbCommand CreateCommand();
    }
}