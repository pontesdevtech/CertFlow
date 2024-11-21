using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;
using System.Data;

namespace E_Docs.Presenter.Mappings;
public static class CertificadoMap
{
    /// <summary>
    /// Método responsável por converter uma "CertificadoDTO" em "Certificado".
    /// </summary>
    /// <param name="dto">"CertificadoDTO" que será convertida em "Certificado"</param>
    /// <returns>Retorna um objeto do tipo <see cref="Certificado"/>.</returns>
    public static Certificado ConverterCertificadoDtoParaCertificado(CertificadoDTO dto)
    {
        return new Certificado
                (
                    nomeArquivo: dto.NomeArquivo,
                    unidade: dto.Unidade,
                    nomeAluno: dto.NomeAluno,
                    curso: dto.Curso,
                    cargaHoraria: dto.CargaHoraria,
                    periodo: dto.Periodo,
                    matricula: MatriculaMap.ConverterMatriculaDtoParaMatricula(dto.Matricula)
                );
    }

    /// <summary>
    /// Método responsável por converter uma "Certificado" em "CertificadoDTO".
    /// </summary>
    /// <param name="matricula">"Certificado" que será convertida em "CertificadoDTO"</param>
    /// <returns>Retorna um objeto do tipo <see cref="CertificadoDTO"/>.</returns>
    public static CertificadoDTO ConverterCertificadoParaCertificadoDto(Certificado certificado)
    {
        return new CertificadoDTO
                (
                    nomeArquivo: certificado.NomeArquivo,
                    unidade: certificado.Unidade,
                    nomeAluno: certificado.NomeAluno,
                    curso: certificado.Curso,
                    cargaHoraria: certificado.CargaHoraria,
                    periodo: certificado.Periodo,
                    matricula: MatriculaMap.ConverterMatriculaParaMatriculaDto(certificado.Matricula)
                );
    }

    /// <summary>
    /// Método responsável por converter uma lista de "CertificadoDTO" em uma lista de "Certificado".
    /// </summary>
    /// <param name="dtos">Lista de "CertificadoDTO" que será convertida em uma lista de "Certificado"</param>
    /// <returns>Retorna um objeto do tipo lista de <see cref="List{T}"/>, sento "T" = "Certificados".</returns>
    public static List<Certificado> ConverterListaCertificadosDtoParaListaCertificados(List<CertificadoDTO> dtos)
    {
        List<Certificado> certificados = [];
        foreach (var dto in dtos)
        {
            certificados.Add(ConverterCertificadoDtoParaCertificado(dto));
        }
        return certificados;
    }

    /// <summary>
    /// Método responsável por converter uma lista de "Certificado" em uma lista de "CertificadoDTO".
    /// </summary>
    /// <param name="certificados">Lista de "Certificado" que será convertida em uma lista de "CertificadoDTO"</param>
    /// <returns>Retorna um objeto do tipo lista de <see cref="List{T}"/>, sento "T" = "CertificadosDTO".</returns>
    public static List<CertificadoDTO> ConverterListaCertificadosParaListaCertificadosDto(List<Certificado> certificados)
    {
        List<CertificadoDTO> dtos = [];
        foreach (var certificado in certificados)
        {
            dtos.Add(ConverterCertificadoParaCertificadoDto(certificado));
        }
        return dtos;
    }

    /// <summary>
    /// Método responsável por converter lista de certificados para DataTable
    /// </summary>
    /// <param name="certificados">Lista de certificados recebidas por parâmetro</param>
    /// <returns>Retorna um DataTable de certificados</returns>
    public static DataTable ConverterListaDtoParaDataTable(List<CertificadoDTO> certificados)
    {
        DataTable dt = new DataTable();

        // Adicionar colunas baseadas nas propriedades da classe "Matricula"
        dt.Columns.Add("NomeArquivo", typeof(string));
        dt.Columns.Add("Unidade", typeof(string));
        dt.Columns.Add("NomeAuno", typeof(string));
        dt.Columns.Add("Curso", typeof(string));
        dt.Columns.Add("CargaHoraria", typeof(string));
        dt.Columns.Add("Periodo", typeof(string));
        dt.Columns.Add("Cpf", typeof(string));

        // Adicionar linhas com os dados da lista
        foreach (var certificado in certificados)
        {
            DataRow row = dt.NewRow();
            row["NomeArquivo"] = certificado.NomeArquivo;
            row["Unidade"] = certificado.Unidade;
            row["NomeAuno"] = certificado.NomeAluno;
            row["Curso"] = certificado.Curso;
            row["CargaHoraria"] = certificado.CargaHoraria;
            row["Periodo"] = certificado.Periodo;
            row["Cpf"] = certificado.Matricula.Cpf;
            dt.Rows.Add(row);
        }

        return dt;
    }
}
