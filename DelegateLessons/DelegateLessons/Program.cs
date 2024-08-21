namespace DelegateLessons {

    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double AloneNumericOperation(double n1);

    delegate void BinaryNumericOperationVoid(double n1, double n2);
    class Program {
        static void Main(string[] args) {
            double a = 10;
            double b = 12;

            double result = Services.CalculationService.Max(a, b);
            Console.WriteLine(result);
            double result2 = Services.CalculationService.Square(a);
            Console.WriteLine(result2);
            double result3 = Services.CalculationService.Sum(a, b);
            Console.WriteLine(result3);

            BinaryNumericOperation op = Services.CalculationService.Max;
            double result4 = op(a, b);
            Console.WriteLine(result4);

            op = Services.CalculationService.Sum;
            double result5 = op(a, b);
            Console.WriteLine(result5);

            AloneNumericOperation op2 = Services.CalculationService.Square;
            double result6 = op2(a);
            Console.WriteLine(result6);
            
            BinaryNumericOperationVoid bop = Services.CalculationServiceMulti.ShowSum;
            bop += Services.CalculationServiceMulti.ShowMax;

            bop.Invoke(a, b);

        }
    }
}
