namespace E_Docs.Views.Common;
internal class Dialogo
{
    public static string? SelecionarPasta()
    {
        using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
        {
            folderBrowser.Description = "Selecione a pasta de certificados";
            folderBrowser.ShowNewFolderButton = true;

            // Abre o diálogo e verifica se o usuário clicou em "OK"
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                // Captura o caminho selecionado
                string caminhoSelecionado = folderBrowser.SelectedPath;

                // Exibe o caminho no TextBox
                return $"{caminhoSelecionado}\\";
            }
        }
        return null;
    }

    public static string? SelecionarArquivo()
    {
        // Cria uma nova instância do OpenFileDialog
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Title = "Selecione um arquivo Excel";
            openFileDialog.Filter = "Arquivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Abre o diálogo e verifica se o usuário clicou em "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Captura o caminho do arquivo selecionado
                string caminhoArquivo = openFileDialog.FileName;

                // Exibe o caminho no TextBox
                return caminhoArquivo;
            }
        }
        return null;
    }


}
