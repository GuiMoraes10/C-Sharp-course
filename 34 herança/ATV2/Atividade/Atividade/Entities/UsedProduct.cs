

namespace Atividade.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate {  get; private set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + ", " + ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
