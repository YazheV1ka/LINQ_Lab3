namespace LINQ_Lab3;

abstract class Supplier
{
    public abstract Material CreateMaterial();
    public abstract int GetPrice();
    public abstract int GetMaxDailySupply();
    public abstract int GetDailyDemand();
    public int Price { get; set; }
    public int MaxDailySupply { get; set; }
    public int DailyDemand { get; set; }
}