namespace LINQ_Lab3.models;

class BrickSupplier : Supplier
{
    public override Material CreateMaterial()
    {
        return new Brick();
    }

    public override int GetPrice()
    {
        return 0;
    }

    public override int GetMaxDailySupply()
    {
        return 0; 
    }

    public override int GetDailyDemand()
    {
        return 0; 
    }
}