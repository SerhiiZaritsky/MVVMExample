using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Reflection;
using Contracts;
using Application.Host.ViewModels;

namespace Application.Host
{
    class ShellImpl : IShell
    {
        private readonly ModuleLoader _loader;
        private readonly ShellViewModel _shellViewModel;

        public ShellImpl(ModuleLoader loader, ShellViewModel shellViewModel)
        {
            _loader = loader;
            _shellViewModel = shellViewModel;
        }

        public IList<ShellMenuItem> MenuItems { get { return _shellViewModel.MenuItems; } }

        public string SelectedTrack { get { return _shellViewModel.SelectedTrack; } }

        public IModule LoadModule(Assembly assembly)
        {
            return _loader.LoadModule(assembly);
        }
    }
}
