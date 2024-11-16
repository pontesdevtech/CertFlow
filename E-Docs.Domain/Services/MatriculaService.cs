using E_Docs.Domain.Entities;
using ExcelDataReader;
using System.Data;

namespace E_Docs.Domain.Services;
public class MatriculaService
{
    /// <summary>
    /// Método responsável por carregar as informações da lista de matrículas
    /// </summary>
    /// <param name="diretorioArquivo">Endereço completo dos arquivos</param>
    /// <returns></returns>
    public static List<Matricula> CarregarMatriculas(string diretorioArquivo)
    {
        List<Matricula> matriculas = new();
        // Configuração necessária para o ExcelDataReader trabalhar corretamente
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        using (var stream = File.Open(diretorioArquivo, FileMode.Open, FileAccess.Read))
        {
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                // Converter para DataSet
                var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true // Usar a primeira linha como cabeçalho
                    }
                });

                DataTable tabela = dataSet.Tables[0]; // Selecionar a primeira planilha

                // Iterar pelas linhas da tabela
                foreach (DataRow linha in tabela.Rows)
                {
                    // Atribui os valores obtidos na lista de matriculados aos campos do objeto
                    var matricula = new Matricula
                                        (
                                            nome: linha["ALUNO"].ToString(),
                                            ra: linha["RA"].ToString(),
                                            cpf: linha["RA"].ToString(),
                                            curso: linha["CURSO"].ToString(),
                                            turma: linha["TURMA"].ToString(),
                                            email: linha["EMAIL"].ToString()
                                        );
                    // Adiciona cada objeto na lista.
                    matriculas.Add(matricula);
                }
            }
        }
        return matriculas;
    }
}
