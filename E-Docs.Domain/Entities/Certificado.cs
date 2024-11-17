namespace E_Docs.Domain.Entities;
public class Certificado
{
    /// <summary>
    /// Método construtor da classe
    /// </summary>
    /// <param name="nomeArquivo">Nome do arquivo PDF</param>
    /// <param name="unidade">Nome da "Unidade" extraído do arquivo</param>
    /// <param name="nomeAluno">Nome do "Aluno" extraído do arquivo</param>
    /// <param name="curso">Nome do "Curso" extraído do arquivo</param>
    /// <param name="cargaHoraria">"Carga Horária" extraída do arquivo</param>
    /// <param name="periodo">"Período do Curso" extraído do arquivo</param>
    /// <param name="matricula">"Matrícula" vinculada ao "Certificado"</param>
    public Certificado(string nomeArquivo, string unidade, string nomeAluno, string curso, string cargaHoraria, string periodo, Matricula matricula)
    {
        NomeArquivo = nomeArquivo;
        Unidade = unidade;
        NomeAluno = nomeAluno;
        Curso = curso;
        CargaHoraria = cargaHoraria;
        Periodo = periodo;
        Matricula = matricula;
    }

    //Atributos da classe
    public string NomeArquivo { get; set; } = string.Empty;
    public string Unidade { get; set; } = string.Empty;
    public string NomeAluno { get; set; } = string.Empty;
    public string Curso { get; set; } = string.Empty;
    public string CargaHoraria { get; set; } = string.Empty;
    public string Periodo { get; set; } = string.Empty;
    //Associações da classe
    public Matricula Matricula { get; set; }

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
