using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Solicita um número ao usuário
            Console.WriteLine("Por favor, digite um número:");
            double numero;

            // Tenta converter a entrada para um número de ponto flutuante
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                // Verifica se o número é maior que 100
                if (numero > 100)
                {
                    Console.WriteLine("O número é maior que 100.");
                }
                else
                {
                    // Calcula o dobro do número
                    double dobro = numero * 2;
                    Console.WriteLine($"O número não é maior que 100. O dobro do número é: {dobro}");
            }
        }
    }
}

