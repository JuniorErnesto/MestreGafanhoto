using System.Collections.Specialized;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

List<string> listaDeNomesClientes = new List<string>() { "João", "Maria", "José" };
List<string> listaDeSobrenomesClientes = new List<string>() { "Silva", "Santos", "Oliveira" };
List<string> listaDeDocumentosClientes = new List<string>() { "123.456.789-00", "987.654.321-00", "456.789.123-00" };
List<DateOnly> listaDeNascimentosClientes = new List<DateOnly>() { DateOnly.Parse("01/01/2000"), DateOnly.Parse("02/02/2001"), DateOnly.Parse("03/03/2002") };
List<int> listaDeIdadesClientes = new List<int>() { 25, 24, 23 };

void ExibirSaudacao()
{
    Console.WriteLine("**************************************************");
    Console.WriteLine("Bem-vindo ao sistema de gerenciamento de clientes!");
    Console.WriteLine("**************************************************\n");
}

void ExibirMenuPrincipal()
{
    ExibirSaudacao();
    Console.WriteLine("1 - Cadastrar Novo Cliente");
    Console.WriteLine("2 - Listar Clientes");
    Console.WriteLine("3 - Editar Dados do Cliente");
    Console.WriteLine("4 - Excluir Cliente");
    Console.Write("\nDigite o número da opção desejada: ");
    string opcaoMenuPrincipal = Console.ReadLine()!;
    switch (opcaoMenuPrincipal)
    {
        case "1":
            RegistrarClientes();
            break;
        case "2":
            ListarClientesCadastrados();
            break;
        case "3":
            EditarCliente();
            break;
        case "4":
            ExcluirCliente();
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarClientes()
{
    Console.Clear();
    Console.WriteLine("Cadastro de Cliente\n");
    Console.WriteLine("Digite o nome do cliente: ");
    string nome = Console.ReadLine()!;
    listaDeNomesClientes.Add(nome);
    Console.WriteLine("Digite o sobrenome do cliente: ");
    string sobrenome = Console.ReadLine()!;
    listaDeSobrenomesClientes.Add(sobrenome);
    Console.WriteLine("Digite o documento do cliente: ");
    string documento = Console.ReadLine()!;
    listaDeDocumentosClientes.Add(documento);
    Console.WriteLine("Digite a data de nascimento do cliente (dd/mm/aaaa): ");
    string dataNascimento = Console.ReadLine()!;
    listaDeNascimentosClientes.Add(DateOnly.Parse(dataNascimento));
    DateOnly nascimento = DateOnly.Parse(dataNascimento);

    DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
    int idade = hoje.Year - nascimento.Year;
    if (hoje.Month < nascimento.Month || (hoje.Month == nascimento.Month && hoje.Day < nascimento.Day))
    {
        idade--;
    }

    listaDeIdadesClientes.Add(idade);

    Console.WriteLine($"Cliente {nome} {sobrenome}, documento {documento}, nascido em {dataNascimento} e {idade} anos, cadastrado com sucesso!\n");
    Thread.Sleep(4000);
    ExibirMenuPrincipal();
}

void ListarClientesCadastrados()
{
    Console.Clear();
    Console.WriteLine("Lista de Clientes Cadastrados\n");
    for (int i = 0; i < listaDeNomesClientes.Count; i++)
    {
        Console.WriteLine($"Cliente {i + 1}: ");
        Console.WriteLine($"Nome: {listaDeNomesClientes[i]}");
        Console.WriteLine($"Sobrenome: {listaDeSobrenomesClientes[i]}");
        Console.WriteLine($"Documento: {listaDeDocumentosClientes[i]}");
        Console.WriteLine($"Nascimento: {listaDeNascimentosClientes[i]}");
        Console.WriteLine($"Idade: {listaDeIdadesClientes[i]}\n");
    }

    Thread.Sleep(5000);
    ExibirMenuPrincipal();
}

void EditarCliente()
{
    Console.Clear();
    Console.WriteLine("Editar Cliente\n");
    Console.WriteLine("Digite o nome do cliente que deseja editar: ");
    string nome = Console.ReadLine()!;
    int indiceCliente = listaDeNomesClientes.IndexOf(nome);
    if (indiceCliente == -1)
    {
        Console.WriteLine($"Cliente {nome} não encontrado!");
    }
    else
    {
        Console.WriteLine("Digite o novo nome do cliente: ");
        string novoNome = Console.ReadLine()!;
        listaDeNomesClientes[indiceCliente] = novoNome;
        Console.WriteLine("Digite o novo sobrenome do cliente: ");
        string novoSobrenome = Console.ReadLine()!;
        listaDeSobrenomesClientes[indiceCliente] = novoSobrenome;
        Console.WriteLine("Digite o novo documento do cliente: ");
        string novoDocumento = Console.ReadLine()!;
        listaDeDocumentosClientes[indiceCliente] = novoDocumento;
        Console.WriteLine("Digite a nova data de nascimento do cliente (dd/mm/aaaa): ");
        string novaDataNascimento = Console.ReadLine()!;
        listaDeNascimentosClientes[indiceCliente] = DateOnly.Parse(novaDataNascimento);

        DateOnly novaNascimento = DateOnly.Parse(novaDataNascimento);
        listaDeNascimentosClientes[indiceCliente] = novaNascimento;

        DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
        int novaIdade = hoje.Year - novaNascimento.Year;
        if (hoje.Month < novaNascimento.Month || (hoje.Month == novaNascimento.Month && hoje.Day < novaNascimento.Day))
        {
            novaIdade--;
        }
        listaDeIdadesClientes[indiceCliente] = novaIdade;

        Console.WriteLine($"Cliente {nome} editado com sucesso!\n");

        Thread.Sleep(4000);
        ExibirMenuPrincipal();
    }
}

void ExcluirCliente()
{
    Console.Clear();
    Console.WriteLine("Excluir Cliente\n");
    Console.WriteLine("Digite o nome do cliente que deseja excluir: ");
    string nome = Console.ReadLine()!;
    int indiceCliente = listaDeNomesClientes.IndexOf(nome);
    if (indiceCliente == -1)
    {
        Console.WriteLine($"Cliente {nome} não encontrado!");
    }
    else
    {
        listaDeNomesClientes.RemoveAt(indiceCliente);
        listaDeSobrenomesClientes.RemoveAt(indiceCliente);
        listaDeDocumentosClientes.RemoveAt(indiceCliente);
        listaDeNascimentosClientes.RemoveAt(indiceCliente);
        listaDeIdadesClientes.RemoveAt(indiceCliente);
        Console.WriteLine($"Cliente {nome} excluído com sucesso!\n");
    }
    Thread.Sleep(4000);
    ExibirMenuPrincipal();
}

ExibirMenuPrincipal();