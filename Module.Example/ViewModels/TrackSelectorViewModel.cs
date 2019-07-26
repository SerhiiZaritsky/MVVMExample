using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Example.ViewModels
{
    class TrackSelectorViewModel
    {
        public TrackSelectorViewModel()
        {
            Tracks = new ObservableCollection<string>
            {
                "One1",
                "Two2",
                "Three3",
                "Four4",
                "Five5"
            };
        }
        public ObservableCollection<string> Tracks { get; private set; }
        public string SelectedTrack { get; set; }

    }
}
