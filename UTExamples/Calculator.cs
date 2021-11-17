namespace UTExamples
{
    public class Calculator 
    {
        public double Add(double x1, double x2)
        {
            if (x1 > 99 || x2 > 99)
                throw new ArgumentException("No more than 99");

            return x1 + x2;
        }
    }
}
