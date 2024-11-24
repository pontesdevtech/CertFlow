using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Mappings;
using System.Data;

namespace E_Docs.Presenter.Services;
public static class MatriculaService
{
    /// <summary>
    /// Método responsável por carregar um DataTable com as matrículas identificadas no arquivo e uma lista de "MatriculasDTO" para utilização no processo de carregamento de certificados.
    /// </summary>
    /// <param name="diretorio">Endereço da pasta onde se encontram o arquivo.</param>
    /// <returns>Retorna um DataTable com as informações das matrículas e uma lista de "MatriculasDTO".</returns>
    public static (DataTable matriculasDt, List<MatriculaDTO> matriculasDTO, List<CertificadoDTO> certificadosDTO) CarregarMatriculas(string diretorio, string senhaAdmin)
    {
        var retorno = Domain.Services.MatriculaService.CarregarMatriculas(diretorio, senhaAdmin);
        var matriculasDTO = MatriculaMap.ConverterListaMatriculasParaListaMatriculasDto(retorno.matriculas);
        DataTable dt = MatriculaMap.ConverterListaDtoParaDataTable(matriculasDTO);
        
        List<Certificado> certificados = [];

        foreach (var certificado in retorno.certificados)
        {
            certificado.Matricula = retorno.matriculas.FirstOrDefault(x => x.Nome.Equals(certificado.NomeAluno));
            if(certificado.Matricula != null) certificados.Add(certificado);
        }
        var certificadosDTO = CertificadoMap.ConverterListaCertificadosParaListaCertificadosDto(certificados);
        return (dt,matriculasDTO, certificadosDTO);
    }
}
