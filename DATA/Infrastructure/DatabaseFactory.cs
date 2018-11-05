
using DATA.Infrastructure;//on aouter cela
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Infrastructure  //on a changer le namespace
    //fournisseur de context
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Context dataContext;
        public Context DataContext
                    {/*il est strictement interdit de modifier le context*/ get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new Context();
        }
        protected override void DisposeCore() //code generique //pour fermer la connexion a la bd
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
