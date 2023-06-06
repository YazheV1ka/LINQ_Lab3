namespace LINQ_Lab3.models;

class BrickSupplierFactory : SupplierFactory
{
    public override Supplier CreateSupplier()
    {
        return new BrickSupplier();
    }
}