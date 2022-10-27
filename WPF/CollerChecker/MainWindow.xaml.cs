using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollerChecker
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = GetColorList();

        }

        private void R_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GetColor();
        }

        private void G_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GetColor();
        }

        private void B_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GetColor();
        }
        public void GetColor()
        {
            var r = R_Slider.Value;
            var g = G_Slider.Value;
            var b = B_Slider.Value;

            ColorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
        }

        private MyColor[] GetColorList()
        {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            ColorLabel.Background = new SolidColorBrush(color);

            var R = color.R;
            var G = color.G;
            var B = color.B;

            R_Slider.Value = R;
            G_Slider.Value = G;
            B_Slider.Value = B;
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

    public class MyColor
    {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}

