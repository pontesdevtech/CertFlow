using System.ComponentModel;

namespace E_Docs.Domain.Entities;
public class ServidorEmail
{
    public ServidorEmail(string provedor, int porta, string usuario, string senha)
    {
        Provedor = provedor;
        Porta = porta;
        Usuario = usuario;
        Senha = senha;
    }

    public string Provedor { get; set; }
    public int Porta { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }
}
