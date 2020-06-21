using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Documents;
using Xuexi.Models;
using Xuexi.Util;

namespace Xuexi.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        internal static List<ThisModel> models = new List<ThisModel>();
        public static void CallFunction(Func<List<ThisModel>> func)
        {
            models = func.Invoke();
        }

        private List<ThisModel> _mydatas;

        public List<ThisModel> Mydatas
        {
            get { return _mydatas; }
            set { _mydatas = value;RaisePropertyChanged(); }
        }


        public MainViewModel()
        {
            Mydatas = models;
        }
    }
}