
namespace E_Docs.Domain.Entities;
public class Certificado
{
    public Certificado(string nomeArquivo, string unidade, string nomeAluno, string curso, string cargaHoraria, string periodo)
    {
        NomeArquivo = nomeArquivo;
        Unidade = unidade;
        NomeAluno = nomeAluno;
        Curso = curso;
        CargaHoraria = cargaHoraria;
        Periodo = periodo;
    }

    public string NomeArquivo { get; set; } = string.Empty;
    public string Unidade { get; set; } = string.Empty;
    public string NomeAluno { get; set; } = string.Empty;
    public string Curso { get; set; } = string.Empty;
    public string CargaHoraria { get; set; } = string.Empty;
    public string Periodo { get; set; } = string.Empty;

    /// <summary>
    /// Sobrescrição do método "ToString()" para exibição das informações do documento após leitura.
    /// </summary>
    public override string ToString()
    {
        return $"# Nome do Arquivo: {NomeArquivo}{Environment.NewLine}" +
               $"# Unidade: {Unidade}{Environment.NewLine}" +
               $"# Nome do Matricula: {NomeAluno}{Environment.NewLine}" +
               $"# Curso: {Curso}{Environment.NewLine}" +
               $"# Carga Horária: {CargaHoraria}{Environment.NewLine}" +
               $"# Período: {Periodo}{Environment.NewLine}" +
               $"{Environment.NewLine}";
    }
}
