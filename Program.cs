using System.Text;
using SistemaHospedagemHotel_CSharp.Models;

Console.OutputEncoding = Encoding.UTF8;

try
{
    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    List<Pessoa> hospedes = new List<Pessoa>();

    Pessoa p1 = new Pessoa(nome: "Luiz", sobrenome: "de Andrade");
    Pessoa p2 = new Pessoa(nome: "Flávia", sobrenome: "Costa");

    hospedes.Add(p1);
    hospedes.Add(p2);

    // Cria a suíte
    Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

    // Cria uma nova reserva. Consequentemente, registra-se a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados: 5);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria().ToString("C")}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}