using System;

class Pessoa
{
	private string nome;
	private string sobrenome;
	private int idade;
	
	public Pessoa(string nome, string sobrenome, int idade)
	{
		this.nome = nome;
		this.sobrenome = sobrenome;
		this.idade = idade;
	}
	
	public void DigaOla()
	{
		if(idade < 2)
		{
			Console.WriteLine("Bebê");
		}
		else
		{
			Console.WriteLine("Olá {0} {1}", this.nome, this.sobrenome);
		}
	}
}