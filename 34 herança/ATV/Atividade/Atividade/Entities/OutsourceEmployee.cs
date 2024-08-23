

namespace Atividade.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }

        public override string ToString()
        {
            return "Nome: " + Name + "\nHoras: " + Hours + "\nValor por hora:" + ValuePerHour + "\nDespesa adicional: " + AdditionalCharge;
        }
    }
}
