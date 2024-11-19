using E_Docs.Presenter.DTOs;
using System.Data;

namespace E_Docs.Presenter.Common;
public static class FormatacaoControlesCommon
{
    /// <summary>
    /// Método responsável por adicionar colunas extras no DataTable
    /// </summary>
    /// <param name="dt">DataTable recebido por parâmetro para ser ajustado</param>
    /// <param name="matriculas">Lista de matrículas para verificação das que possuem certificados vinculados</param>
    /// <returns>Retorna um DataTable com as colunas extras e os registros de matrículas com certificados vinculados</returns>
    public static DataTable AdicionarColunasExtras(DataTable dt, List<MatriculaDTO> matriculas)
    {
        // Adicionar colunas extras para controle
        dt.Columns.Add("[X]", typeof(bool)); // Checkbox
        dt.Columns.Add("Certificado", typeof(bool));
        dt.Columns.Add("Envio", typeof(bool)); // Texto

        List<string> alunos = [];
        foreach (var aluno in matriculas) alunos.Add(aluno.Aluno);

        // Inicializar valores padrão para as colunas adicionais
        foreach (DataRow row in dt.Rows)
        {
            row["[X]"] = false; // Checkbox desmarcado
            row["Envio"] = false; // Célula vazia

            if (alunos.Contains(row["Aluno"].ToString()))
            {
                row["Certificado"] = true; // Célula vazia
            }
            else
            {
                row["Certificado"] = false; // Célula vazia
            }
        }
        return dt;
    }
}
