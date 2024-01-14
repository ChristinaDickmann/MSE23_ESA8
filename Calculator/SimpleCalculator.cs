namespace Calculator
{
    public class SimpleCalculator
    {
        public double Result { get; private set; }

        public SimpleCalculator()
        {
            Result = 0;
        }

        public SimpleCalculator add(double value)
        {
            Result += value;
            return this;
        }

        public SimpleCalculator subtract(double value)
        {
            Result -= value;
            return this;
        }

        public SimpleCalculator multiply(double value)
        {
            Result *= value;
            return this;
        }

        public SimpleCalculator divide(double value)
        {
            if (value == 0)
                throw new ArgumentException("You cannot divide by zero!", nameof(value));

            Result /= value;
            return this;
        }

    }
}
