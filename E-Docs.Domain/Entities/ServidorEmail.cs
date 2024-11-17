namespace E_Docs.Domain.Entities;
public class ServidorEmail
{
    /// <summary>
    /// Contrutor da classe
    /// </summary>
    /// <param name="provedor">Provedor de email utilizado para envio</param>
    /// <param name="porta">Número da porta liberarda no provedor</param>
    /// <param name="usuario">Email do usuário remetente</param>
    /// <param name="senha">Senha do usuário remetente</param>
    public ServidorEmail(string provedor, int porta, string usuario, string senha)
    {
        Provedor = provedor;
        Porta = porta;
        Usuario = usuario;
        Senha = senha;
    }

    // Atributos da classe
    public string Provedor { get; set; }
    public int Porta { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }

    /// <summary>
    /// Sobrescrição do método "ToString()" para exibição das informações do documento após leitura.
    /// </summary>
    public override string ToString()
    {
        return $"# Provedor: {Provedor}{Environment.NewLine}" +
               $"# Porta: {Porta}{Environment.NewLine}" +
               $"# Usuário: {Usuario}{Environment.NewLine}" +
               $"# Senha: {"*************"}{Environment.NewLine}" +
               $"{Environment.NewLine}";
    }
}
