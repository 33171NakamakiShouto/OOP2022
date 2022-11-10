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
        List<MyColor> colorList = new List<MyColor>();
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
            //var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //if (mycolor != null)
            //{
            //    var color = mycolor.Color;
            //    var name = mycolor.Name;

            //    ColorLabel.Background = new SolidColorBrush(color);

            //    var R = color.R;
            //    var G = color.G;
            //    var B = color.B;

            //    R_Slider.Value = R;
            //    G_Slider.Value = G;
            //    B_Slider.Value = B;
            //}
            //
            R_Slider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            G_Slider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            B_Slider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            GetColor();

        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ColorLabel_Loaded(object sender, RoutedEventArgs e)
        {
            GetColor();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyColor stColor = new MyColor();
            var r = byte.Parse(R_TextBox.Text);
            var g = byte.Parse(G_TextBox.Text);
            var b = byte.Parse(B_TextBox.Text);
            stColor.Color = Color.FromRgb(r,g,b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                            .Where(c => c.Color.R == stColor.Color.R &&
                                                        c.Color.G == stColor.Color.G &&
                                                        c.Color.B == stColor.Color.B).FirstOrDefault();

            colorInfo.Items.Insert(0,colorName?.Name?? "R:" + r + " G:" + g + " B:" + b);
            colorList.Insert(0, stColor);

            //if (colorName != null)
            //{
            //    colorInfo.Items.Add(colorName.Name);
            //}
            //else
            //{
            //    colorInfo.Items.Add("R:" + R_TextBox.Text + " G:" + G_TextBox.Text + " B:" + B_TextBox.Text);
            //}
            //colorInfo.Items.Add(stColor);  
        }

        private void colorInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorInfo.SelectedIndex == -1) return;

            R_Slider.Value = colorList[colorInfo.SelectedIndex].Color.R;
            G_Slider.Value = colorList[colorInfo.SelectedIndex].Color.G;
            B_Slider.Value = colorList[colorInfo.SelectedIndex].Color.B;
            GetColor();
            delete.IsEnabled = true;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var delIndex = colorInfo.SelectedIndex;

            if (delIndex == -1) return;

            colorInfo.Items.RemoveAt(delIndex);
            colorList.RemoveAt(delIndex);
            delete.IsEnabled = false;
        }
    }

    public class MyColor
    {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}

