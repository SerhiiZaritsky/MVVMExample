﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module.Example.ViewModels;
using Contracts;

namespace Module.Example
{
    public class ModuleInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                .Register(Component.For<TrackViewModel>())
                .Register(Component.For<TrackSelectorViewModel>())
                .Register(Component.For<IModule>().ImplementedBy<ModuleImpl>());
        }
    }
}
