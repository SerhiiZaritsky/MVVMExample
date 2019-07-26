using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Module.Example.ViewModels;

namespace Module.Example
{
    class ModuleImpl : IModule
    {
        private readonly IShell _shell;
        private readonly TrackViewModel _trackViewModel;
        private readonly TrackSelectorViewModel _trackSelectorViewModel;

        public ModuleImpl(IShell shell, TrackViewModel trackViewModel, TrackSelectorViewModel trackSelectorViewModel)
        {
            _shell = shell;
            _trackViewModel = trackViewModel;
            _trackSelectorViewModel = trackSelectorViewModel;
        }

        public void Init()
        {
            _shell.MenuItems.Add(new ShellMenuItem() { Caption = "XDCAM 1", ScreenViewModel = _trackSelectorViewModel });
            _shell.MenuItems.Add(new ShellMenuItem() { Caption = "XDCAM 2", ScreenViewModel = _trackViewModel });
            //_shell.SelectedTrack;
        }
    }
}
