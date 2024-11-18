namespace E_Docs.Presenter.DTOs;
public class MatriculaDTO
{
    /// <summary>
    /// Método construtor da classe
    /// </summary>
    /// <param name="aluno">"RA" + "Nome do Aluno" obtido na lista de matrícula</param>
    /// <param name="cpf">"CPF" obtido na lista de matrícula</param>
    /// <param name="email">"Email" obtido na lista de matrícula</param>
    /// <param name="curso">"Curso" obtido na lista de matrícula</param>
    /// <param name="turma">"Coódigo da Turma" obtido na lista de matrícula</param>
    public MatriculaDTO(string aluno, string cpf, string email, string curso, string turma)
    {
        Aluno = aluno;
        Cpf = cpf;
        Email = email;
        Curso = curso;
        Turma = turma;
    }

    // Atributos da classe
    public string Aluno { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Curso { get; set; }
    public string Turma { get; set; }
}
