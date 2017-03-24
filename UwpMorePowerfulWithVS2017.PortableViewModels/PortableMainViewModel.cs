using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UwpMorePowerfulWithVS2017.PortableViewModels
{
    public class PortableMainViewModel : ViewModelBase
    {
        private string eventName;

        public string EventName
        {
            get { return eventName; }
            set { eventName = value;
                base.RaisePropertyChanged();
            }
        }

        public PortableMainViewModel()
        {
            this.EventName = "Visual Studio 2017 to the max";
        }
    }
}