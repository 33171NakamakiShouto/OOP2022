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

namespace NumberGeme
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int random = new Random().Next(1, 25);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;

            var num = Convert.ToInt32(bt);


            if (random == num)
            {
                パパイヤ.Text = "wow With flying colors!";
            }
            else if (random < num)
            {
                パパイヤ.Text = "大きいな～";
            }
            else if (random > num)
            {
                パパイヤ.Text = "小さいな～";
            }
        } 
        private void getRandom()
        {
            new Random().Next(1, 25);
        }
    }
}
