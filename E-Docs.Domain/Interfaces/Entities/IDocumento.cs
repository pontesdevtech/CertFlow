namespace E_Docs.Domain.Interfaces.Entities;

public interface IDocumento : IDocs
{
    /// <summary>
    /// Método responsável por validar as informações do documento.
    /// </summary>
    /// <returns>
    /// Retorna "true" caso as informações do documento sejam válidas e "false" quando foram inválidas.
    /// </returns>
    bool ValidarDocumento();
}
