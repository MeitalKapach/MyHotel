using restful.core.Repository;
using restful.core.Services;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.service
{
    public class PackageService : IPackageService
    {

        private readonly IPackageRepository _packageRepository;
        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }
        public List<Package> GetPackages()
        {
            return _packageRepository.GetAllPackages();
        }
 
    }
}
