using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using MVVMCalc.Models;

namespace MVVMCalc.ViewModels
{
    public partial class CalculatorViewModel : ObservableObject
    {
        [ObservableProperty]
        private double number1;

        [ObservableProperty]
        private double number2;

        [ObservableProperty]
        private double result;

        [ObservableProperty]
        private string operation;

        [RelayCommand]
        public void Calculate()
        {
            var model = new CalculatorModel
            {
                Number1 = Number1,
                Number2 = Number2,
                Operation = Operation
            };

            try
            {
                model.PerformOperation();
                Result = model.Result;
            }
            catch (Exception ex)
            {
                // Handle exception
                Result = 0;
            }
        }

        [RelayCommand]
        public void Clear()
        {
            Number1 = 0;
            Number2 = 0;
            Result = 0;
            Operation = "";
        }
    }
}