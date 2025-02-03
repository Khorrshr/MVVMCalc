namespace MVVMCalc.Models
{
    public class CalculatorModel
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }

        public void PerformOperation()
        {
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 != 0)
                        Result = Number1 / Number2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                    break;
            }
        }
    }
}