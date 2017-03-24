using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpMorePowerfulWithVS2017.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private string version;
        public string Version
        {
            get { return version; }
            set { version = value;
                base.RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            this.Version = "v.1.0 (build 20170325)";
        }

        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString();
        }

        public string GetTestValue()
        {
            return "test value";
        }

        public string Double(string x)
        {
            if (string.IsNullOrEmpty(x)) return string.Empty;

            try
            {
                int n = Int32.Parse(x);
                return (n * 2).ToString();
            }
            catch (Exception)
            {
                return "#ERR#";
            }
        }
    }
}