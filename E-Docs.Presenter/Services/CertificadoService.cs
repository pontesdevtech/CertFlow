using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Mappings;

namespace E_Docs.Presenter.Services;
public class CertificadoService
{
    /// <summary>
    /// Método responsável por carregar um DataTable com as informações dos certificados renomeados
    /// </summary>
    /// <param name="diretorio">Endereço da pasta onde se encontram os arquivos.</param>
    /// <param name="senhaAdmin">Senha do usuário Admin para manipulação dos arquivos</param>
    /// <param name="matriculas">Lista de matrículas para identificação dos certificados.</param>
    /// <returns>Retorna um DataTable com as informações dos certificados</returns>
    public static List<CertificadoDTO> CarregarCertificados(string diretorio, string senhaAdmin, List<MatriculaDTO> matriculas)
    {
        var certificados = Domain.Services.CertificadoService.RenomearCertificados(diretorio, senhaAdmin, MatriculaMap.ConverterListaMatriculasDtoParaListaMatriculas(matriculas)) ?? new List<Certificado>();
        var certifcadosDto = CertificadoMap.ConverterListaCertificadosParaListaCertificadosDto(certificados);
        return certifcadosDto;
    }
}
