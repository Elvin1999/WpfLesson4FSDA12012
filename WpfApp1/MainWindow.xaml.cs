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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> GetCars()
        {
            return new List<Car>{
                new Car
                {
                    Model="E-200",
                    Vendor="Mercedes",
                    Year=2021
                },
                new Car
                {
                    Model="F-12 Berlinetta",
                    Vendor="Ferrari",
                    Year=2021
                },
                new Car
                {
                    Model="M5",
                    Vendor="BMW",
                    Year=2021
                },
                new Car
                {
                    Model="Cruze 2LT RS",
                    Vendor="Chevrolet",
                    Year=2013
                },
            };
        }
        public MainWindow()
        {
            InitializeComponent();

            //listbox.ItemsSource = GetCars();

            //prgbar.IsIndeterminate = true;

            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(0.5);
            //timer.Tick += Timer_Tick;
            //timer.Start();

        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car = listbox.SelectedItem as Car;
            //if (car != null)
            //{
            //    modelTxtblock.Text = $"Model : {car.Model}";
            //    vendorTxtblock.Text = $"Vendor : {car.Vendor}";
            //    yearTxtblock.Text = $"Year : {car.Year}";
            //}

            //modelTxtblock.Text = "Model : ";
            //vendorTxtblock.Text = "Vendor : ";
            //yearTxtblock.Text = "Year : ";
            //var carObjects = listbox.SelectedItems;
            //foreach (var item in carObjects)
            //{
            //    if(item is Car car)
            //    {
            //        modelTxtblock.Text += car.Model + " ";
            //        vendorTxtblock.Text += car.Vendor + " ";
            //        yearTxtblock.Text += car.Year.ToString() + " ";
            //    }
            //}


        }

        private void cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    prgbar.Value += 5;
        //}

        //private void downBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value > prgbar.Minimum)
        //    {
        //        --prgbar.Value;
        //    }
        //}

        //private void upBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value < prgbar.Maximum)
        //    {
        //        ++prgbar.Value;
        //    }
        //}



        //private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    txtblock1.Text = Convert.ToInt32(slider.Value).ToString();
        //    txtblock2.Text = Convert.ToInt32(slider.Value).ToString();
        //}
    }
}
