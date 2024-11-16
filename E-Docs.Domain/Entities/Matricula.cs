namespace E_Docs.Domain.Entities;
public class Matricula
{
    public Matricula(string nome, string ra, string cpf, string email, string curso, string turma)
    {
        Nome = nome;
        Ra = ra;
        Cpf = cpf;
        Curso = curso;
        Email = email;
        Turma = turma;
    }

    public string Nome { get; set; }
    public string Ra { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Curso { get; set; }
    public string Turma { get; set; }

    public Certificado Certificado { get; set; } = null!;

    /// <summary>
    /// Sobrescrição do método "ToString()" para exibição das informações do documento após leitura.
    /// </summary>
    public override string ToString()
    {
        return $"# Ra: {Ra}{Environment.NewLine}" +
               $"# Nome do Aluno: {Nome}{Environment.NewLine}" +
               $"# Email: {Email}{Environment.NewLine}" +
               $"# Curso: {Curso}{Environment.NewLine}" +
               $"# Turma: {Turma}{Environment.NewLine}" +
               $"{Environment.NewLine}";
    }
}
