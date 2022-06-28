namespace FormularioInscricao;

public class FichaInscricao
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public string Curso { get; set; }
	public string Escolaridade { get; set; }
	public DateTime DataNascimento { get; set; }
	public decimal? ValorCurso { get; set; }
	public decimal? ValorDesconto { get; set; }
	public decimal? ValorMulta { get; set; }

	public FichaInscricao(
		string nome, 
		string curso, 
		string escolaridade, 
		DateTime dataNascimento,
		decimal? valorCurso,
		decimal? valorDescondo,
		decimal? valorMulta
		)
	{
		Nome = nome;
		Idade = CalcularIdade(dataNascimento.Year);
		Curso = curso;
		Escolaridade = escolaridade;
		DataNascimento = dataNascimento;
		ValorCurso = valorCurso;
		ValorDesconto = valorDescondo;
		ValorMulta = valorMulta;
	}

	private int CalcularIdade(int anoNascimento)
    {
		return anoNascimento - DateTime.Now.Year;
    }
}
public class CobrarCurso
{
	private decimal? valorCurso { get; set; }
	private decimal? valorMulta { get; set; }
	private decimal? valorDesconto { get; set; }
	private decimal? Resultado { get; set; }
	private void Calculo()
    {
		if (valorMulta.HasValue && valorMulta > 0)
        {
			Resultado = valorCurso + valorMulta;
        }

		if (valorMulta.HasValue && valorMulta < 0)
        {
			Resultado = valorCurso - valorDesconto;
        }
    }
}

public class CursoSelecionado
{
	private List<string> cursos = new List<string>();
	public CursoSelecionado(string curso)
    {
        this.cursos.Add(curso);
    }
}
