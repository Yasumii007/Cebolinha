string frase;

Console.WriteLine("Ola, prazer sou o cebolinha, por favor me fale frase que você deseja que eu fale");

frase = Console.ReadLine()!;

Console.WriteLine($"A frase escolhida por você foi:{frase} ");

frase = frase.Replace("R", "L").Replace("r", "l");

Console.WriteLine($"Quando eu falo a frase fica assim: {frase}");