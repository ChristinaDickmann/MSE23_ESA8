namespace Calculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello SimpleCalculator!");
            Console.WriteLine();

            Console.WriteLine("First calculation: ((0 + 5 - 2) / 4) * 2");
            SimpleCalculator calculator = new SimpleCalculator()
                .add(5)
                .subtract(2)
                .divide(4)
                .multiply(2);
            Console.WriteLine("Result: " + calculator.Result);
            Console.WriteLine();

            Console.WriteLine("Calculation with division by zero:");
            SimpleCalculator calculator2 = new SimpleCalculator()
                .add(5)
                .subtract(2)
                .divide(0)
                .multiply(2);
            Console.WriteLine("should throw Exception because of division by zero: " + calculator2.Result);
        }
    }
}