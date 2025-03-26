Clientes cliente1 = new Clientes();
cliente1.Nome = "João";
cliente1.Sobrenome = "";
cliente1.Documento = "123456789";
cliente1.Nascimento = new DateOnly(1998, 1, 1);

Console.WriteLine("Cliente 1:\n");
cliente1.ExibirCliente();