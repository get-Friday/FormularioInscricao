namespace FormularioInscricao;

public class FichaInscricao
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public string Curso { get; set; }
	public string Escolaridade { get; set; }
	public DateOnly DataNascimento { get; set; }
	public decimal? ValorCurso { get; set; }
	public decimal? ValorDesconto { get; set; }
	public decimal? ValorMulta { get; set; }

	public FichaInscricao(
		string nome, 
		string curso, 
		string escolaridade, 
		DateOnly dataNascimento,
		decimal? valorCurso,
		decimal? valorDescondo,
		decimal? valorMulta
		)
	{
		Nome = nome;
		Curso = curso;
		Escolaridade = escolaridade;
		DataNascimento = dataNascimento;
		ValorCurso = valorCurso;
		ValorDesconto = valorDescondo;
		ValorMulta = valorMulta;
	}
}
