using CentiSoft.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentiSoft.DAL {
    public static class RepositoryFactory<TEnitity> {
        public static IRepository<TEnitity> Create() {
            return new DeveloperRepos() as IRepository<TEnitity>;
        }
    }
}
