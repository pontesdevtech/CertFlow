namespace E_Docs.Domain.Entities;
public class Matricula
{
    public Matricula(string nome, string identificador, string curso, string email)
    {
        Nome = nome;
        Identificador = identificador;
        Curso = curso;
        Email = email;
    }

    public string Nome { get; set; }
    public string Identificador { get; set; }
    public string Curso { get; set; }
    public string Email { get; set; }

    public Certificado Certificado { get; set; } = null!;

    /// <summary>
    /// Sobrescrição do método "ToString()" para exibição das informações do documento após leitura.
    /// </summary>
    public override string ToString()
    {
        return $"# Identificador: {Identificador}{Environment.NewLine}" +
               $"# Nome do Aluno: {Nome}{Environment.NewLine}" +
               $"# Curso: {Curso}{Environment.NewLine}" +
               $"# Email: {Email}{Environment.NewLine}" +
               $"{Environment.NewLine}";
    }
}
