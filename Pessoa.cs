using System;

class Pessoa
{
	private string nome;
	private string sobrenome;
	
	public Pessoa(string nome, string sobrenome)
	{
		this.nome = nome;
		this.sobrenome = sobrenome;
	}
	
	public void DigaOla()
	{
		Console.WriteLine("Olá {0} {1}", this.nome, this.sobrenome);
	}
}