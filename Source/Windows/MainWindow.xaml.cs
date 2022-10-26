using Source.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Source.Windows;

// DependencyProperty
// INotifyPropertyChanged


public partial class MainWindow : Window, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));












    //// Example SomeText_1
    // public string? SomeText { get; set; } = "Hakuna";




    //// Example SomeText_2
    //public string SomeText
    //{
    //    get { return (string)GetValue(SomeTextProperty); }
    //    set { SetValue(SomeTextProperty, value); }
    //}

    //public static readonly DependencyProperty SomeTextProperty =
    //    DependencyProperty.Register("SomeText", typeof(string), typeof(MainWindow));



    //// Example SomeText_3
    private string? _someText;

    public string? SomeText
    {
        get => _someText;
        set
        {
            _someText = value;
            NotifyPropertyChanged();
        }
    }






    public Car Car { get; set; }
    public ObservableCollection<Car> Cars { get; set; }






    public MainWindow()
    {
        InitializeComponent();
        // grid.Resources["primaryColor"] = Brushes.Bisque;
        Resources["primaryColor"] = Brushes.Bisque;

        DataContext = this;


        Car = new()
        {
            Make = "BMW",
            Model = "X6",
            Year = 2021
        };



        Cars = new()
        {
            new()
            {
                Make = "BMW",
                Model = "X6",
                Year = 2021
            },
            new()
            {
                Make = "Mercedes",
                Model = "Maybach",
                Year = 2022
            }
        };
    }


    private void BtnAddChar(object sender, RoutedEventArgs e)
    {
        // SomeText += 'a';

        // txtBlock.Text += "yes ";
        MessageBox.Show(SomeText);
    }

    private void BtnAddCar(object sender, RoutedEventArgs e)
    {
        Cars.Add(new()
        {
            Make = "Kia",
            Model = "Cerato",
            Year = 2013
        });
    }

    private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        var listBox = sender as ListBox;
        var selectedCar = listBox?.SelectedItem as Car;

        if (selectedCar is null)
            return;


        InfoCar info = new InfoCar();
        info.SelectedCar = selectedCar;

        info.ShowDialog();


        //selectedCar.Year = 2000;
        //MessageBox.Show(selectedCar.Year.ToString());
    }
}
