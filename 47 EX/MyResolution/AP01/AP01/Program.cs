
using AP01.Entities;
using AP01.Services;
using System.Globalization;

namespace AP01
{
    class Program
    {
        // Uma empresa deseja automatizar o processamento de seus contratos.
        // O processamento de um contrato consiste em gerar as parcelas a serem pagas para aquele contrato,
        // com base no numero de meses desejado.

        // A empresa utiliza um SERVICO DE PAGAMENTO online para realizar o pagamento das parcelas.
        // Os servicos de pagamento online tipicamente cobram um juro mensal, bem como uma taxa de pagamento.
        // Por enquanto, o servico contratado pela empresa eh o do paypal,
        // que aplica juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%

        // Fazer um programa para ler os dados de um contrato (numero do contrato, data do contrato, e valor total do contrato).
        // Em seguida, o programa deve ler o numero de meses para o parcelamento do contrato,
        // e dai gerar os registros de parcelas a serem pagas (data e valor),
        // sendo a primeira parcela a ser paga um mes apos a data do contrato, a segunda parcela dois meses apos o contrato e assim por diante.
        // Mostrar os dados das parcelas na tela.

        static void Main(string[] args)
        {
            ServicoDeContrato servicoContrato = new ServicoDeContrato();
            PicPayService servicoDePagamento = new PicPayService();

            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double valorTotal = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valorTotal);

            Parcela[] parcelas = servicoContrato.ProcessarContrato(meses, contrato, servicoDePagamento);

            foreach (var parcela in parcelas)
            {
                Console.WriteLine(parcela.ToString());
            }
        }
    }
}