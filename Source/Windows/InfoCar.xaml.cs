using Source.Models;
using System.Windows;

namespace Source.Windows;

public partial class InfoCar : Window
{
    public Car? SelectedCar { get; set; }

    public InfoCar()
    {
        InitializeComponent();
        DataContext = this;
    }
}
