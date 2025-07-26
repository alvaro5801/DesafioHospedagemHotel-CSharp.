using System;
using System.Collections.Generic;

namespace DesafioHotel
{
  public class Programa
  {
    public static void Main()
    {
      Console.WriteLine("--- Sistema de Reserva de Hotel ---");

      Console.WriteLine("\n--- Testando Reserva Longa (com desconto) ---");


      List<Pessoa> hospedes1 = new();
      hospedes1.Add(new Pessoa("João", "Silva"));
      hospedes1.Add(new Pessoa("Maria", "Souza"));

      Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150.00m);


      Reserva reserva1 = new Reserva(suite: suitePremium, diasReservados: 15);

      reserva1.CadastrarHospedes(hospedes1);

      Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
      Console.WriteLine($"Valor Total: {reserva1.CalcularValorDiaria():C}");

      Console.WriteLine("\n--- Testando Reserva Curta (sem desconto) ---");

      List<Pessoa> hospedes2 = new();
      hospedes2.Add(new Pessoa("Carlos", "Pereira"));

      Suite suiteStandard = new Suite(tipoSuite: "Standard", capacidade: 1, valorDiaria: 80.00m);


      Reserva reserva2 = new Reserva(suite: suiteStandard, diasReservados: 5);

      reserva2.CadastrarHospedes(hospedes2);

      Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
      Console.WriteLine($"Valor Total: {reserva2.CalcularValorDiaria():C}");
    }
  }
}