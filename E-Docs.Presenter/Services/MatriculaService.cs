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
    public static (DataTable matriculasDt, List<MatriculaDTO> matriculasDTO) CarregarMatriculas(string diretorio)
    {
        var matriculas = Domain.Services.MatriculaService.CarregarMatriculas(diretorio);
        var matriculasDTO = MatriculaMap.ConverterListaMatriculasParaListaMatriculasDto(matriculas);
        DataTable dt = MatriculaMap.ConverterListaDtoParaDataTable(matriculasDTO);
        return (dt,matriculasDTO);
    }
}
