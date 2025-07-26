namespace DesafioHotel
{
  public class Pessoa
  {
    // Construtor vazio:

    public Pessoa()
    {
      Nome = "";
      Sobrenome = "";
    }

    // Construtor com parâmetros:
    // Ele deve USAR os parâmetros que recebe para preencher as propriedades.
    public Pessoa(string nome, string sobrenome)
    {
      Nome = nome;       // A propriedade Nome recebe o valor do parâmetro nome
      Sobrenome = sobrenome; // A propriedade Sobrenome recebe o valor do parâmetro sobrenome
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
  }
}