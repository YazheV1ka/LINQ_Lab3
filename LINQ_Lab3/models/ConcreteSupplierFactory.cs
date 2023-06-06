namespace LINQ_Lab3.models;

class ConcreteSupplierFactory : SupplierFactory
{
    public override Supplier CreateSupplier()
    {
        return new ConcreteSupplier();
    }
}