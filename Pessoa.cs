using System;

class Pessoa
{
	private string nome;
	
	public Pessoa(String nome)
	{
		this.nome = nome;
	}
	
	public void DigaOla()
	{
		Console.WriteLine("Ol� {0}", this.nome);
	}
}