using E_Docs.Presenter.DTOs;

namespace E_Docs.Presenter.Common;
public class RegistroLogsCommon
{
    public readonly List<LogDTO> Logs = [];

    /// <summary>
    /// Método reponsável por retornar a lista de logs gerados durante a execução de um processo
    /// </summary>
    /// <param name="nomeProcesso">Nome do processo que lançou a exceção</param>     
    /// <param name="processo">Processo que está sendo monitorado pelo objeto que registra os logs</param>
    internal void MonitorarProcesso(string nomeProcesso, Action processo)
    {
        try
        {
            processo();
        }
        catch (Exception excecao)
        {
            var log = new LogDTO(excecao, nomeProcesso);
            Logs.Add(log);
        }
    }

    /// <summary>
    /// Método reponsável por retornar a lista de logs gerados durante a execução de um processo
    /// </summary>
    /// <param name="nomeProcesso">Nome do processo que lançou a exceção</param>     
    /// <param name="processo">Processo que está sendo monitorado pelo objeto que registra os logs</param>
    internal T? MonitorarProcesso<T>(string nomeProcesso, Func<T> processo)
    {
        try
        {
            return processo();
        }
        catch (Exception excecao)
        {
            var log = new LogDTO(excecao, nomeProcesso);
            Logs.Add(log);
            return default;
        }
    }
}
