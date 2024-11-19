using E_Docs.Presenter.Mappings;
using System.Data;

namespace E_Docs.Presenter.Services;
public static class MatriculaService
{
    /// <summary>
    /// Método responsável por carregar um DataTable com as matrículas identificadas no arquivo
    /// </summary>
    /// <param name="diretorio">Endereço da pasta onde se encontram o arquivo.</param>
    /// <returns>Retorna um DataTable com as informações das matrículas</returns>
    public static DataTable CarregarMatriculas(string diretorio)
    {
        var matriculas = Domain.Services.MatriculaService.CarregarMatriculas(diretorio);
        DataTable dt = MatriculaMap.ConverterListaParaDataTable(MatriculaMap.ConverterListaMatriculasParaListaMatriculasDto(matriculas));
        return dt;
    }
}
