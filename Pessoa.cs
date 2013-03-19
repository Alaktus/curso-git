using System;

class Pessoa
{
	private string nome;
	private string sobrenome;
	private string sexo;
	private int idade;
	
	public Pessoa(string nome, string sobrenome, string sexo, int idade)
	{
		this.nome = nome;
		this.sobrenome = sobrenome;
		this.sexo = sexo;
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
			Console.WriteLine("Olá {0}", NomeCompleto());
		}
	}
	
	public string NomeCompleto()
	{
		return this.nome + " " + this.sobrenome;
	}
}