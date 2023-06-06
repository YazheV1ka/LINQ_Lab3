namespace LINQ_Lab3.models;

class ReinforcedConcretePlateSupplierFactory : SupplierFactory
{
    public override Supplier CreateSupplier()
    {
        return new ReinforcedConcretePlateSupplier();
    }
}