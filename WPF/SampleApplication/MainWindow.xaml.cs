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

namespace SampleApplication
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okBotton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"入力された文字は、{TextBox.TextProperty}です。");
        }

        private void cencelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("キャンセルされました");
        }
    }
}
