using System.Dynamic;

class Clientes
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? Documento { get; set; }
    public DateOnly Nascimento { get; set; }

    private DateOnly DataAtual => DateOnly.FromDateTime(DateTime.Now);

    public int Idade => DataAtual.Year - Nascimento.Year - (DataAtual.DayOfYear < Nascimento.DayOfYear ? 1 : 0);

    public void ExibirCliente()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sobrenome: {Sobrenome}");
        Console.WriteLine($"Documento: {Documento}");
        Console.WriteLine($"Nascimento: {Nascimento}");
        Console.WriteLine($"Idade: {Idade}");
    }
}