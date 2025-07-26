namespace DesafioHotel
{
  public class Suite
  {
    // Construtor da classe Suite.
    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
      TipoSuite = tipoSuite;
      Capacidade = capacidade;
      ValorDiaria = valorDiaria;
    }

    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }
  }
}