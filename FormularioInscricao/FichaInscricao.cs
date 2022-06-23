using System;

public class FichaInscricao
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public string Curso { get; set; }
	public string Escolaridade { get; set; }
	public string DataNascimento { get; set; }
	public decimal? ValorCurso { get; set; }
	public decimal? ValorDesconto { get; set; }
	public decimal? ValorMulta { get; set; }

	public FichaInscricao()
	{
	}
}
