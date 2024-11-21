using E_Docs.Presenter.Common;
using E_Docs.Presenter.Common.Enums;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Services;
using E_Docs.Views.Common;

namespace E_Docs.Views.Services;
internal static class ImportarMatriculasService
{
    /// <summary>
    /// Método responsável por carregar o data grid com as informações das matrículas
    /// </summary>
    /// <param name="diretorio">Diretório do arquivo com a lista de matrículas</param>
    /// <param name="dgv">Data grid que será carregado com as informações das matrículas</param>
    /// <returns>Retorna uma lista de logs de erros. Retorna lista vazia, caso não ocorra nenhuma exceção</returns>
    internal static (List<MatriculaDTO>matriculas, List<LogDTO>logs) ImportarMatriculas(string diretorio, DataGridView dgv)
    {
        // Monitorar a execução do processo
        var dt = ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.CarregarMatriculas, () => MatriculaService.CarregarMatriculas(diretorio));
        dgv.DataSource = dt.retorno.matriculasDt;
        if (dt.logs.Count == 0) ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.FormatarTabela, () => FormatacaoCommon.FormatarDgv(dgv));
        return (dt.retorno.matriculasDTO, dt.logs);
    }
}
