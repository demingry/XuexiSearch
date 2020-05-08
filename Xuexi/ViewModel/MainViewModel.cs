using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using Xuexi.Models;

namespace Xuexi.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private List<ThisModel> mydatas;

        public List<ThisModel> Mydatas
        {
            get { return mydatas; }
            set { mydatas = value; RaisePropertyChanged(); }
        }



        public MainViewModel()
        {
            TestData testData = new TestData();
            Mydatas = testData.Datas;
        }
    }
}