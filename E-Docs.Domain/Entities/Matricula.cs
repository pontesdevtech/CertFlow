namespace E_Docs.Domain.Entities;
public class Matricula
{
    /// <summary>
    /// Método construtor da classe
    /// </summary>
    /// <param name="nome">"Nome do Aluno" obtido na lista de matrícula</param>
    /// <param name="ra">"Registro Acadêmico (RA)" obtido na lista de matrícula</param>
    /// <param name="cpf">"CPF" obtido na lista de matrícula</param>
    /// <param name="email">"Email" obtido na lista de matrícula</param>
    /// <param name="curso">"Curso" obtido na lista de matrícula</param>
    /// <param name="turma">"Coódigo da Turma" obtido na lista de matrícula</param>
    public Matricula(string nome, string ra, string cpf, string email, string curso, string turma)
    {
        Nome = nome;
        Ra = ra;
        Cpf = cpf;
        Curso = curso;
        Email = email;
        Turma = turma;
    }

    //Atributos da classe
    public string Nome { get; set; }
    public string Ra { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Curso { get; set; }
    public string Turma { get; set; }

    /*REMOVER
     * public Certificado Certificado { get; set; } = null!;
     */

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
