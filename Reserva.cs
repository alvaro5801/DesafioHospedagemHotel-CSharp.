using System;
using System.Collections.Generic;

namespace DesafioHotel
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(Suite suite, int diasReservados)
    {
      Suite = suite;
      DiasReservados = diasReservados;
      Hospedes = new List<Pessoa>();
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      // Validação para garantir que a suíte foi cadastrada antes dos hóspedes
      if (this.Suite == null)
      {
        throw new Exception("É necessário cadastrar uma suíte antes de cadastrar os hóspedes.");
      }

      // Validação da capacidade
      if (Suite.Capacidade >= hospedes.Count)
      {
        Hospedes = hospedes;
      }
      else
      {
        throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
      }
    }

    public int ObterQuantidadeHospedes()
    {
      return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
      decimal valorTotal = DiasReservados * Suite.ValorDiaria;

      // Condição para o desconto
      if (DiasReservados > 10)
      {
        // Aplica desconto de 10%
        valorTotal = valorTotal * 0.90m;
      }

      return valorTotal;
    }
  }
}