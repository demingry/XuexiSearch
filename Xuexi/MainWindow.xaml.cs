using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xuexi.Models;
using Xuexi.Util;
using Xuexi.ViewModel;

namespace Xuexi
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(SearchTextBox.Text== "输入连续的几个字试试")
            {
                SearchTextBox.Text = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Func<List<ThisModel>> action = new Func<List<ThisModel>>(()=>
            {
                if (this.SearchTextBox.Text == null) return null;
                BaseRequest baseRequest = new BaseRequest();
                baseRequest.RequestUrl = "http://im.1353217661.xyz/index/index/get_result";
                baseRequest.IsGetRequest = false;
                baseRequest.Content = $"title={this.SearchTextBox.Text}";
                GetAnswer answer = new GetAnswer(baseRequest);
                return answer.Mydatas;
            });
            MainViewModel.CallFunction(action);
            this.DataContext = new MainViewModel();
        }
    }
}
