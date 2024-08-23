

namespace Atividade.Entities
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomsFee {  get; private set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + ", total price: $" + TotalPrice();
        }
    }
}
