using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando um carro
        Carro carro = new Carro("Fiat", "Uno", 2020, "ABC1234");

        // Apresentando o carro
        carro.Apresentar();

        // Ligando o carro
        carro.Ligar();

        // Acelerando o carro
        carro.Acelerar(60);

        // Parando o carro
        carro.Parar();

        // Desligando o carro
        carro.Desligar();

        Console.ReadLine();
    }
}

class Carro
{
    // Propriedades
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public int Ano { get; private set; }
    public string Placa { get; private set; }
    public bool Ligado { get; private set; }
    public int Velocidade { get; private set; }

    // Construtor
    public Carro(string marca, string modelo, int ano, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Placa = placa;
        Ligado = false;
        Velocidade = 0;
    }

    // Métodos
    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("Carro ligado.");
    }

    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("Carro desligado.");
    }

    public void Acelerar(int velocidade)
    {
        if (Ligado)
        {
            Velocidade += velocidade;
            Console.WriteLine($"Carro acelerando a {Velocidade} km/h.");
        }
        else
        {
            Console.WriteLine("Não é possível acelerar, carro desligado.");
        }
    }

    public void Parar()
    {
        Velocidade = 0;
        Console.WriteLine("Carro parado.");
    }

    public void Apresentar()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Placa: {Placa}");
    }
}
