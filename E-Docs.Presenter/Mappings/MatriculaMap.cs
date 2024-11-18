using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;

namespace E_Docs.Presenter.Mappings;
public static class MatriculaMap
{
    /// <summary>
    /// Método responsável por converter uma "MatriculaDTO" em "Matricula".
    /// </summary>
    /// <param name="dto">"MatriculaDTO" que será convertida em "Matricula"</param>
    /// <returns>Retorna um objeto do tipo <see cref="Matricula"/>.</returns>
    public static Matricula MatriculaDtoParaMatricula(MatriculaDTO dto)
    {
        // Separa o "RA" e o "Nome do aluno"
        string[] aluno = dto.Aluno.Split(" - ");
        Matricula matricula = new Matricula
        (
            nome: aluno[1],
            ra: aluno[0],
            cpf: dto.Cpf,
            email: dto.Email,
            curso: dto.Curso,
            turma: dto.Turma
        );
        return matricula;
    }

    /// <summary>
    /// Método responsável por converter uma "Matricula" em "MatriculaDTO".
    /// </summary>
    /// <param name="matricula">"Matricula" que será convertida em "MatriculaDTO"</param>
    /// <returns>Retorna um objeto do tipo <see cref="MatriculaDTO"/>.</returns>
    public static MatriculaDTO MatriculaParaMatriculaDto(Matricula matricula)
    {
        MatriculaDTO dto = new MatriculaDTO
        (
            // Agrupa o "RA" e o "Nome do aluno" em um só campo da MatriculaDTO
            aluno: $"{matricula.Ra} - {matricula.Nome}",
            cpf: matricula.Cpf,
            email: matricula.Email,
            curso: matricula.Curso,
            turma: matricula.Turma
        );
        return dto;
    }
}
