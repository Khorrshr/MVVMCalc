using MVVMCalc.ViewModels;

namespace MVVMCalc;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new CalculatorViewModel();
    }
}