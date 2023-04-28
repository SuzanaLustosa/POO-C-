using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine($" Saldo da conta do André = R${contaDoAndre.saldo}");

contaDoAndre.Depositar(100);

Console.WriteLine($"O saldo da conta do André pós depósito = R${contaDoAndre.saldo}");

contaDoAndre.Sacar(100);

Console.WriteLine($"O saldo da conta do André pós saque = R${contaDoAndre.saldo}");

contaDoAndre.Sacar(200);
Console.WriteLine($"O saldo da conta do André pós saque = R${contaDoAndre.saldo}");
contaDoAndre.Sacar(20);
Console.WriteLine($"O saldo da conta do André pós saque = R${contaDoAndre.saldo}");

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine($"Saldo da conta da Maria = R${contaDaMaria.saldo}");

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine($"Saldo da conta do André pós transferência = R${contaDoAndre.saldo}");
Console.WriteLine($"Saldo da Conta da Maria pós transferência = R${contaDaMaria.saldo}");

ContaCorrente contaDoPedro = new ContaCorrente();
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine(contaDoPedro.numero_agencia);
Console.WriteLine(contaDoPedro.conta);