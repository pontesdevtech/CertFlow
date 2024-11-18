namespace E_Docs.Presenter.DTOs;
public class CertificadoDTO
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
    public CertificadoDTO(string nomeArquivo, string unidade, string nomeAluno, string curso, string cargaHoraria, string periodo, MatriculaDTO matricula)
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
    public string NomeArquivo { get; set; }
    public string Unidade { get; set; }
    public string NomeAluno { get; set; }
    public string Curso { get; set; }
    public string CargaHoraria { get; set; }
    public string Periodo { get; set; }

    //Associações da classe
    public MatriculaDTO Matricula { get; set; }
}
