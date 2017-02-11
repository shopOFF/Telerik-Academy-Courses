using Dealership.Contracts;
using Dealership.Engine;
using Dealership.Factories;
using Dealership.Models;
using DealershipRedone.Factories;
using DealershipRedone.InputOutputProvider;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Modules;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DealershipRedone
{
    public class DealershipModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ICommand>().To<Command>();

            Kernel.Bind<IVehicle>().To<Vehicle>();

            Kernel.Bind<ICar>().To<Car>();

            Kernel.Bind<ITruck>().To<Truck>();

            Kernel.Bind<IMotorcycle>().To<Motorcycle>();

            Kernel.Bind<IComment>().To<Comment>();

            Kernel.Bind<IUser>().To<User>();

            Kernel.Bind<IInputProvider>().To<ConsoleInputProvider>();

            Kernel.Bind<IOutputProvider>().To<ConsoleOutputProvider>();

            Kernel.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();

            Kernel.Bind<ICommandFactory>().ToFactory().InSingletonScope();

            Kernel.Bind<IDealershipFactory>().ToFactory().InSingletonScope();

            //Kernel.Bind(x =>
            //{
            //    x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            //    .SelectAllClasses()
            //    .BindDefaultInterface();
            //});

            //Bind<IVehicle>().To<Vehicle>();

            //Bind<ICar>().To<Car>();

            //Bind<ITruck>().To<Truck>();

            //Bind<IMotorcycle>().To<Motorcycle>();

            //Bind<IUser>().To<User>();

            //Bind<ICommand>().To<Command>();

            //Bind<IComment>().To<Comment>();

            //Bind<IInputOutputProvider>().To<ConsoleInputOutputProvider>().InSingletonScope();

            //Bind<IEngine>().To<DealershipEngine>().InSingletonScope();

            //Bind<IDealershipFactory>().ToFactory().InSingletonScope();

            //Bind<ICommandFactory>().ToFactory().InSingletonScope();
        }
    }
}
