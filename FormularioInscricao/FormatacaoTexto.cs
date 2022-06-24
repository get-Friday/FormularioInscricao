namespace FormularioInscricao;
public static class FormatacaoTexto
{
    public static string Selecao(FichaInscricao aluno)
    {
        if (aluno.ValorDesconto == null)
        {
            return Formatacao(aluno.Nome, aluno.Curso, aluno.ValorCurso);
        }

        if (aluno.ValorDesconto > 0)
        {
            return Formatacao(aluno.Nome, aluno.Curso, aluno.ValorCurso, aluno.ValorDesconto);
        }

        if (aluno.Idade >= 18)
        {
            return Formatacao(aluno.Nome, aluno.Curso, aluno.ValorCurso, aluno.ValorDesconto, aluno.Idade);
        }

        return "Nenhuma regra se aplica";
    }
	public static string Formatacao(string nome, string curso, decimal? valorCurso)
    {
        return $"{nome} | {curso} | Valor R${valorCurso}";
    }
    public static string Formatacao(
        string nome, 
        string curso, 
        decimal? valorCurso, 
        decimal? valorDesconto
        )
    {
        return $"{nome} | {curso} | Valor R${valorCurso} | Desconto R${valorDesconto}";
    }
    public static string Formatacao(
        string nome, 
        string curso, 
        decimal? valorCurso, 
        decimal? valorDesconto, 
        int idade
        )
    {
        return $"{nome} | {idade} Anos | {curso} | Valor R${valorCurso} | Desconto R${valorDesconto}";
    }
}
