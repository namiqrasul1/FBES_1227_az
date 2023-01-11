namespace Lesson7
{
    public static class Calc
    {
        public static double Sum(params double[] args)
        {
            return args.Sum();
        }
        public static double Sub(params double[] args)
        {
            double result = args[0];
            for(int i = 1; i < args.Length; i++)
                result -= args[i];
            return result;
        }
        public static double Mult(params double[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
                result *= args[i];
            return result;
        }
        public static double Divide(params double[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
                result /= args[i];
            return result;
        }
    }
}
