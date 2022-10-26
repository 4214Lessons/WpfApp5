using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Source.Models;



public class Car
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
}



//public class Car : INotifyPropertyChanged
//{
//    public event PropertyChangedEventHandler? PropertyChanged;

//    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
//        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


//    public string? Make { get; set; }
//    public string? Model { get; set; }


//    private int year;

//    public int Year
//    {
//        get { return year; }
//        set
//        {
//            year = value;
//            NotifyPropertyChanged();
//        }
//    }
//}