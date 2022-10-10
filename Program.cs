internal class Program
{
  private static void Main(string[] args)
  {
    double meta = 100.000;
    double vendeu = 87.574;
    double precisaParaBaterMeta = meta - vendeu;
    bool metaBatida = vendeu >= meta;
    bool metaNaoBatida = vendeu <= meta;

    Console.WriteLine($"Voce precisa vender {((decimal)meta)} mil");
    Console.WriteLine($"Você vendeu até o momento: {((decimal)vendeu)} mil");
    Console.WriteLine($"Você ainda precisa vender: {((decimal)precisaParaBaterMeta)} mil");

    switch (metaBatida)
    {
      case true:
        Console.WriteLine("Parabens meta batida com sucesso");
        break;
      case false:
        Console.WriteLine("Desculpe. Meta não foi atingida");
        break;
    }
  }
}