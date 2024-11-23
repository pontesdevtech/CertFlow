using E_Docs.Presenter.Common;
using E_Docs.Presenter.Common.Enums;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Services;
using System.Collections.Generic;

namespace E_Docs.Views.Services;
internal static class ImportarCertificadosService
{
    /// <summary>
    /// Método responsável por carregar o data grid com as informações dos Certificados.
    /// </summary>
    /// <param name="diretorio">Diretório do arquivo com a lista de matrículas.</param>
    /// <param name="senhaAdmin">Senha do admin para gerenciamento dos arquivos PDF criptografados.</param>
    /// <param name="matriculasDTO">Lista de matrículas que será utilizada para identificar os arquivos de certificado.</param>
    /// <param name="dgv">Data grid que será carregado com as informações dos Certificados</param>
    /// <returns>Retorna uma lista de logs de erros. Retorna lista vazia, caso não ocorra nenhuma exceção</returns>
    internal static (List<CertificadoDTO>? certificados, List<LogDTO> logs) ImportarCertificados(string diretorio, string senhaAdmin, List<MatriculaDTO> matriculasDTO/*, DataGridView dgv*/)
    {
        // Monitorar a execução do processo
        var dt = ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.CarregarCertificados, () => CertificadoService.CarregarCertificados(diretorio, senhaAdmin, matriculasDTO));
        return (dt.retorno, dt.logs);
    }
}
