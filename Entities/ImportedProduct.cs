
namespace Vendas.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(double customsFee, string name, double price) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price ;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + TotalPrice().ToString("F2") + " (CustomsFee fee: $ " + CustomsFee.ToString("F2") +")";
        }

    }
}
