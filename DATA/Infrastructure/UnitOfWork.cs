using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
       
         private Context dataContext;

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            dataContext = dbFactory.DataContext;
        }
        


        public void Commit() //encapsuler le context
        {
            dataContext.SaveChanges();
        }
        
        public void Dispose()    //pour supp l'espace memoirepour supp l'espace memoire a la bd
        {
            dataContext.Dispose();
        }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            IRepositoryBase<T> repo = new RepositoryBase<T>(dbFactory);
            return repo;
        }
      
    }
}
