public class NumberOperations
{
    public double ModifyNumber(double number)
    {
        if (number % 2 == 0)
        {
            return number / 2;
        }
        else
        {
            return number + 3;
        }
    }
}