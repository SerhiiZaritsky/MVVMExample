using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using System.Windows;

namespace Application.Host.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        public ShellViewModel()
        {
            MenuItems = new ObservableCollection<ShellMenuItem>();
        }

        private ShellMenuItem _selectedMenuItem;
        private string _selectedTrack;

        public ObservableCollection<ShellMenuItem> MenuItems
        {
            get;
            private set;
        }
        public ShellMenuItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                if (_selectedMenuItem == value)
                    return;
                _selectedMenuItem = value;
                NotifyOfPropertyChange(() => SelectedMenuItem);
                NotifyOfPropertyChange(() => CurrentView);
            }
        }

        public string SelectedTrack
        {
            get { return _selectedTrack; }
            set
            {
                if (_selectedTrack == value)
                    return;
                _selectedTrack = value;
                NotifyOfPropertyChange(() => SelectedTrack);
            }
        }

        public object CurrentView
        {
            get { return _selectedMenuItem == null ? null : _selectedMenuItem.ScreenViewModel; }
        }
        public void Execute()
        {
            //TODO
            MessageBox.Show("SelectedTrack");
            MessageBox.Show(SelectedTrack);

        }
    }
}
