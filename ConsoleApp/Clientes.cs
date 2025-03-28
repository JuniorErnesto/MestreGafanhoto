public class Clientes
{
    public required string Nome { get; set; }
    public required string Sobrenome { get; set; }
    public required string Documento { get; set; }
    public DateOnly Nascimento { get; set; }
    public int Idade { get; set; }

    public void ExibirDadosDoCliente()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sobrenome: {Sobrenome}");
        Console.WriteLine($"Documento: {Documento}");
        Console.WriteLine($"Nascimento: {Nascimento}");
        Console.WriteLine($"Idade: {Idade}\n");
    }
}