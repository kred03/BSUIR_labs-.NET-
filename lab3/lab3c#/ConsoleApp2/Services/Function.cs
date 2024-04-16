public class Operations
{
    public int BranchNumber { get; private set; }

    public double ModifyNumber(double z)
    {
        double x;

        if (z < -1)
        {
            x = -(z / 3);
            BranchNumber = 1;
        }
        else if (z >= -1)
        {
            x = Math.Abs(z);
            BranchNumber = 2;
        }
        else
        {
            x = 0;
            BranchNumber = 3;
        }

        return x;
    }
}