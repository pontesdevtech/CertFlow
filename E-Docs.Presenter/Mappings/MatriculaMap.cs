using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;
using System.Data;

namespace E_Docs.Presenter.Mappings;
public static class MatriculaMap
{
    /// <summary>
    /// Método responsável por converter uma "MatriculaDTO" em "Matricula".
    /// </summary>
    /// <param name="dto">"MatriculaDTO" que será convertida em "Matricula"</param>
    /// <returns>Retorna um objeto do tipo <see cref="Matricula"/>.</returns>
    public static Matricula ConverterMatriculaDtoParaMatricula(MatriculaDTO dto)
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
    public static MatriculaDTO ConverterMatriculaParaMatriculaDto(Matricula matricula)
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

    /// <summary>
    /// Método responsável por converter uma lista de "MatriculaDTO" em uma lista de "Matricula".
    /// </summary>
    /// <param name="dtos">Lista de "MatriculaDTO" que será convertida em uma lista de "Matricula"</param>
    /// <returns>Retorna um objeto do tipo lista de <see cref="List{T}"/>, sento "T" = "Matriculas".</returns>
    public static List<Matricula> ConverterListaMatriculasDtoParaListaMatriculas(List<MatriculaDTO> dtos)
    {
        List<Matricula> matriculas = [];
        foreach (var dto in dtos)
        {
            matriculas.Add(ConverterMatriculaDtoParaMatricula(dto));
        }
        return matriculas;
    }

    /// <summary>
    /// Método responsável por converter uma lista de "Matricula" em uma lista de "MatriculaDTO".
    /// </summary>
    /// <param name="matriculas">Lista de "Matricula" que será convertida em uma lista de "MatriculaDTO"</param>
    /// <returns>Retorna um objeto do tipo lista de <see cref="List{T}"/>, sento "T" = "MatriculasDTO".</returns>
    public static List<MatriculaDTO> ConverterListaMatriculasParaListaMatriculasDto(List<Matricula> matriculas)
    {
        List<MatriculaDTO> dtos = [];
        foreach (var matricula in matriculas)
        {
            dtos.Add(ConverterMatriculaParaMatriculaDto(matricula));
        }
        return dtos;
    }

    /// <summary>
    /// Método responsável por converter lista de matriculas para DataTable
    /// </summary>
    /// <param name="matriculas">Lista de matriculas recebidas por parâmetro</param>
    /// <returns>Retorna um DataTable de matriculas</returns>
    public static DataTable ConverterListaDtoParaDataTable(List<MatriculaDTO> matriculas)
    {
        var dt = new DataTable();

        // Adicionar colunas baseadas nas propriedades da classe "Matricula"
        dt.Columns.Add("Aluno", typeof(string));
        dt.Columns.Add("CPF", typeof(string));
        dt.Columns.Add("Email", typeof(string));
        dt.Columns.Add("Curso", typeof(string));
        dt.Columns.Add("Turma", typeof(string));
        dt.Columns.Add("Unidade", typeof(string));

        // Adicionar linhas com os dados da lista
        foreach (var matricula in matriculas)
        {
            DataRow row = dt.NewRow();
            row["Aluno"] = matricula.Aluno;
            row["CPF"] = matricula.Cpf;
            row["Email"] = matricula.Email;
            row["Curso"] = matricula.Curso;
            row["Turma"] = matricula.Turma;
            dt.Rows.Add(row);
        }

        return dt;
    }
}
