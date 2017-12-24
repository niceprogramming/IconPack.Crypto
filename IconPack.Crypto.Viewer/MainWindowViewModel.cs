using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconPack.Crypto.Viewer
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
          IconNames = new ObservableCollection<string>(Enum.GetNames(typeof(PackIconKind))); 
        }
        public ObservableCollection<string> IconNames { get; set; }
    }

    
}
