using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using News.ViewModels;

namespace News.ViewModel
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigate Navigation { get; set; } = new Navigator();
    }


}
