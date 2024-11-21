using E_Docs.Presenter.Common.Enums;
using E_Docs.Presenter.DTOs;

namespace E_Docs.Presenter.Common;
public static class ExecutorProcessosCommon
{
    /// <summary>
    /// Método responsável por gerenciar a execução dos processos que retornam valor
    /// </summary>
    /// <typeparam name="T">Valor genérico para o tipo de retorno do processo executado</typeparam>
    /// <param name="nomeProcesso">Nome do processo que lançou a exceção</param>     
    /// <param name="processo">Processo que está sendo monitorado pelo objeto que registra os logs</param>
    /// <returns>Retorna o valor do tipo genérico "T" e a lista de logs de erros do processo</returns>
    public static (T? retorno, List<LogDTO> logs) ExecutarProcesso<T>(ENomeProcessoCommon nomeProcesso, Func<T> processo)
    {
        RegistroLogsCommon logs = new();
        var retorno = logs.MonitorarProcesso(nomeProcesso, ()=> processo());
        return (retorno, logs.Logs);
    }

    /// <summary>
    /// Método responsável por gerenciar a execução dos processos que não retornam valor
    /// </summary>
    /// <param name="nomeProcesso">Nome do processo que lançou a exceção</param>     
    /// <param name="processo">Processo que está sendo monitorado pelo objeto que registra os logs</param>
    /// <returns>Retorna a lista de logs de erros do processo</returns>
    public static List<LogDTO> ExecutarProcesso(ENomeProcessoCommon nomeProcesso, Action processo)
    {
        RegistroLogsCommon logs = new();
        logs.MonitorarProcesso(nomeProcesso, () => processo());
        return logs.Logs;
    }
}
