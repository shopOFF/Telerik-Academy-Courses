using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Repositories.Fakes
{
    public class FakePackageRepository : PackageRepository
    {
        public FakePackageRepository(ILogger logger, ICollection<IPackage> packages = null) 
            : base(logger, packages)
        {
        }

        public ICollection<IPackage> Packages
        {
            get { return base.Packages; }
        }

        public ILogger Logger
        {
            get { return base.Logger; }
        }
    }
}
