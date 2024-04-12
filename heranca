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

class Veiculo
{
    // Propriedades comuns a todos os veículos
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public int Ano { get; private set; }
    public bool Ligado { get; private set; }
    public int Velocidade { get; private set; }

    // Construtor
    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Ligado = false;
        Velocidade = 0;
    }

    // Métodos comuns a todos os veículos
    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("Veículo ligado.");
    }

    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("Veículo desligado.");
    }

    public void Acelerar(int velocidade)
    {
        if (Ligado)
        {
            Velocidade += velocidade;
            Console.WriteLine($"Veículo acelerando a {Velocidade} km/h.");
        }
        else
        {
            Console.WriteLine("Não é possível acelerar, veículo desligado.");
        }
    }

    public void Parar()
    {
        Velocidade = 0;
        Console.WriteLine("Veículo parado.");
    }

    public void Apresentar()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}

class Carro : Veiculo
{
    // Propriedades específicas de carro
    public string Placa { get; private set; }

    // Construtor
    public Carro(string marca, string modelo, int ano, string placa)
        : base(marca, modelo, ano) // Chamando o construtor da classe base (Veiculo)
    {
        Placa = placa;
    }

    // Não é necessário definir novamente os métodos de Veiculo, pois já são herdados.
}
