using PackageManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Commands.Fakes
{
    internal class FakeInstallCommand : InstallCommand
    {
        public FakeInstallCommand(IInstaller<IPackage> installer, IPackage package) 
            : base(installer, package)
        {
        }

        public IInstaller<IPackage> Installer
        {
            get { return base.Installer; }
        }

        protected IPackage Package
        {
            get { return base.Package; }
        }
    }
}
