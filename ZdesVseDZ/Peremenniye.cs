public static class Peremenniye
{
    public static int DivisionOfTwoNumbers(int a, int b)
    {
        int result = a / b;
        return result;
    }
    public static int SolutionsOfTheEquation(int a, int b)
    {
        int result = (5 * a + b * b) / (b - a);
        return result;
    }
    public static string SwapTheValue(string a, string b)
    {
        string temp = a;
        a = b;
        b = temp;
        return a + temp;
    }
    public static int SolutionOfTheLinearEquation(int a, int b, int c)
    {
        int result = (c - b) / a;
        return result;
    }
    public static string EquationOfStraightLine(int x1, int x2, int y1, int y2)
    {
        double a = (double)(y2 - y1) / (x2 - x1);
        double b = y1 - a * x1;
        return $"{a} * X + {b} = 0";
    }
}