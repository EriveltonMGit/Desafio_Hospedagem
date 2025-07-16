using System;
using System.Collections.Generic;
using reserva_hotel;

class Program
{
    static void Main()
    {
        // Cria hóspedes usando construtor
        var hospedes = new List<Pessoa>
        {
            new Pessoa("Erivelton", "Magalhães"),
            new Pessoa("Ana", "Silva")
        };

        // Cria a suíte usando construtor
        var suite = new Suite("Premium", 2, 150m);

        // Cria reserva passando suite no construtor
        var reserva = new Reserva(12, suite);

        // Cadastra os hóspedes
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidade()}");
        Console.WriteLine($"Valor total: R$ {reserva.CalcularValorDiaria():0.00}");
    }
}
