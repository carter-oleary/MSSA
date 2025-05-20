public class ParkingSystem
{
    private int big;
    private int medium;
    private int small;

    public ParkingSystem(int big, int medium, int small)
    {
        this.big = big;
        this.medium = medium;
        this.small = small;
    }

    public bool AddCar(int carType)
    {
        switch (carType)
        {
            case 1:
                if(big > 0)
                {
                    big--;
                    return true;
                }
                return false;
            case 2:
                if (medium > 0)
                {
                    big--;
                    return true;
                }
                return false;
            case 3:
                if (big > 0)
                {
                    big--;
                    return true;
                }
                return false;
            default:
                return false;
        }
    }
}