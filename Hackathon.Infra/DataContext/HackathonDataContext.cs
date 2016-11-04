using Hackathon.Infra.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Infra.DataContext
{
    public class HackathonDataContext : HackathonDB, IHackathonDataContext
    {
        public HackathonDataContext()
        {

        }

        public HackathonDataContext(string connection):base(connection)
        {

        }

        public int Delete<T>(T obj)
        {
            return this.Delete<T>(obj);
        }

        public int InsertWithIdentity<T>(T obj)
        {
            return this.InsertWithIdentity<T>(obj);
        }

        public int Update<T>(T obj)
        {
            return this.Update<T>(obj);
        }
    }
}
