using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace DoToo.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(params string[] propertyNames)
        {
            foreach (var propertyName in propertyNames)
            {
                PropertyChanged?.Invoke(this, new
                PropertyChangedEventArgs(propertyName));
            }
        }

        public INavigation Navigation { get; set; }

        public class MyTestViewModel : ViewModel
        {
            public string Name { get; set; }
        }
    }
}
