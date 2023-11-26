using CreateApi;
using restful.core.Repository;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.data.Repositories
{
    public class PackageRepository: IPackageRepository
    {

        private readonly DataContext _dataContext;

        public PackageRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Package> GetAllPackages()
        {
            return _dataContext.Packages;
        }


    }
}
