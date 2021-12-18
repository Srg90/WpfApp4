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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Dollar (object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDollar.Text);
            double sum = Convert.ToDouble(sumDollar.Text);
            double resSum = rate * sum;
            resSumDollar.Text = resSum.ToString();
        }
        private void Euro(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEuro.Text);
            double sum = Convert.ToDouble(sumEuro.Text);
            double resSum = rate * sum;
            resSumEuro.Text = resSum.ToString();
        }
        private void Lira(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateLira.Text);
            double sum = Convert.ToDouble(sumLira.Text);
            double resSum = rate * sum;
            resSumLira.Text = resSum.ToString();
        }
        private void Dirham(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDirham.Text);
            double sum = Convert.ToDouble(sumDirham.Text);
            double resSum = rate * sum;
            resSumDirham.Text = resSum.ToString();
        }
        private void Inch(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(value1.Text);
            double result = value * 0.0254;
            result1.Text = result.ToString();
        }
        private void Foot(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(value2.Text);
            double result = value * 0.3048;
            result2.Text = result.ToString();
        }
        private void Mile(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(value3.Text);
            double result = value * 1609.34;
            result3.Text = result.ToString();
        }
        private void Cm(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToDouble(value4.Text);
            double result = value * 0.01;
            result4.Text = result.ToString();
        }
    }
}
