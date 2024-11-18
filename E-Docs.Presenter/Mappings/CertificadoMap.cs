using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;

namespace E_Docs.Presenter.Mappings;
public static class CertificadoMap
{
    /// <summary>
    /// Método responsável por converter uma "CertificadoDTO" em "Certificado".
    /// </summary>
    /// <param name="dto">"CertificadoDTO" que será convertida em "Certificado"</param>
    /// <returns>Retorna um objeto do tipo <see cref="Certificado"/>.</returns>
    public static Certificado CertificadoDtoParaCertificado(CertificadoDTO dto)
    {
        return new Certificado
                (
                    nomeArquivo: dto.NomeArquivo,
                    unidade: dto.Unidade,
                    nomeAluno: dto.NomeAluno,
                    curso: dto.Curso,
                    cargaHoraria: dto.CargaHoraria,
                    periodo: dto.Periodo,
                    matricula: MatriculaMap.MatriculaDtoParaMatricula(dto.Matricula)
                );
    }

    /// <summary>
    /// Método responsável por converter uma "Certificado" em "CertificadoDTO".
    /// </summary>
    /// <param name="matricula">"Certificado" que será convertida em "CertificadoDTO"</param>
    /// <returns>Retorna um objeto do tipo <see cref="CertificadoDTO"/>.</returns>
    public static CertificadoDTO CertificadoParaCertificadoDto(Certificado certificado)
    {
        return new CertificadoDTO
                (
                    nomeArquivo: certificado.NomeArquivo,
                    unidade: certificado.Unidade,
                    nomeAluno: certificado.NomeAluno,
                    curso: certificado.Curso,
                    cargaHoraria: certificado.CargaHoraria,
                    periodo: certificado.Periodo,
                    matricula: MatriculaMap.MatriculaParaMatriculaDto(certificado.Matricula)
                );
    }
}
