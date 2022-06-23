namespace FormularioInscricao;

public class FichaInscricao
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public string Curso { get; set; }
	public string Escolaridade { get; set; }
<<<<<<< HEAD
	public DateTime DataNascimento { get; set; }
=======
	public DateOnly DataNascimento { get; set; }
>>>>>>> main
	public decimal? ValorCurso { get; set; }
	public decimal? ValorDesconto { get; set; }
	public decimal? ValorMulta { get; set; }

	public FichaInscricao(
		string nome, 
		string curso, 
		string escolaridade, 
<<<<<<< HEAD
		DateTime dataNascimento,
=======
		DateOnly dataNascimento,
>>>>>>> main
		decimal? valorCurso,
		decimal? valorDescondo,
		decimal? valorMulta
		)
	{
		Nome = nome;
<<<<<<< HEAD
		Idade = CalcularIdade(dataNascimento);
=======
>>>>>>> main
		Curso = curso;
		Escolaridade = escolaridade;
		DataNascimento = dataNascimento;
		ValorCurso = valorCurso;
		ValorDesconto = valorDescondo;
		ValorMulta = valorMulta;
	}
<<<<<<< HEAD

	private int CalcularIdade(DateTime DataNascimento)
    {
		return DataNascimento.Year - DateTime.Now.Year;
    }
=======
>>>>>>> main
}
