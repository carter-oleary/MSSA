public class House
{
    public int HouseNumber {  get; set; }
    public string StreetAddress { get; set; }
    public string HouseType { get; set; }

    public House(int num, string addr, string type)
    {
        HouseNumber = num;
        StreetAddress = addr;
        HouseType = type;
    }

    public string ToString()
    {
        return $"The house at {HouseNumber} {StreetAddress} is a {HouseType}.";
    }
}
