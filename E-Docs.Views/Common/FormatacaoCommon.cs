using E_Docs.Views.Views;
using System;
using System.Windows.Forms;

namespace E_Docs.Views.Common;
public static class FormatacaoCommon
{
    /// <summary>
    /// Método responsável por formatar as colunas no datagridview
    /// </summary>
    /// <param name="dgv">DataGridView que será formatado</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public static void FormatarDgv(DataGridView dgv)
    {
        try
        {
            // Criar as colunas extras se ainda não existirem
            CriarColunaDGV(typeof(DataGridViewCheckBoxColumn), "[X]", dgv);
            CriarColunaDGV(typeof(DataGridViewTextBoxColumn), "Unidade", dgv);
            CriarColunaDGV(typeof(DataGridViewImageColumn), "Certificado", dgv);
            CriarColunaDGV(typeof(DataGridViewImageColumn), "Envio", dgv);

            if (dgv.FindForm() is ImportarMatriculasView)
            {
                if (dgv.Columns.Contains(dgv.Columns["[X]"]))
                {
                    dgv.Columns["[X]"].DisplayIndex = 0; // Desloca essa coluna para o início do datagridview
                    dgv.Columns["[X]"].Width = 30;
                    dgv.Columns["[X]"].ReadOnly = false;
                }

                if (dgv.Columns.Contains(dgv.Columns["Aluno"])) dgv.Columns["Aluno"].Width = 250;

                if (dgv.Columns.Contains(dgv.Columns["CPF"])) dgv.Columns["CPF"].Width = 100;

                if (dgv.Columns.Contains(dgv.Columns["Email"])) dgv.Columns["Email"].Width = 250;

                if (dgv.Columns.Contains(dgv.Columns["Turma"])) dgv.Columns["Turma"].Width = 80;

                if (dgv.Columns.Contains(dgv.Columns["Curso"])) dgv.Columns["Curso"].Width = 300;

                if (dgv.Columns.Contains(dgv.Columns["Unidade"]))
                {
                    dgv.Columns["Unidade"].Width = 250;
                    dgv.Columns["Unidade"].Visible = false;
                }

                if (dgv.Columns.Contains(dgv.Columns["Certificado"]))
                {
                    dgv.Columns["Certificado"].Width = 80;
                }

                if (dgv.Columns.Contains(dgv.Columns["Envio"]))
                {
                    dgv.Columns["Envio"].Width = 80;
                    dgv.Columns["Envio"].Visible = false; // Remove a visibilidade da coluna nesta visão
                }
            }

            if (dgv.FindForm() is PrincipalView)
            {
                if (dgv.Columns.Contains(dgv.Columns["[X]"]))
                {
                    dgv.Columns["[X]"].DisplayIndex = 0; // Desloca essa coluna para o início do datagridview
                    dgv.Columns["[X]"].Width = 30;
                    dgv.Columns["[X]"].ReadOnly = false;
                }

                if (dgv.Columns.Contains(dgv.Columns["Aluno"])) dgv.Columns["Aluno"].Width = 250;

                if (dgv.Columns.Contains(dgv.Columns["CPF"])) dgv.Columns["CPF"].Width = 100;

                if (dgv.Columns.Contains(dgv.Columns["Email"])) dgv.Columns["Email"].Width = 250;

                if (dgv.Columns.Contains(dgv.Columns["Turma"])) dgv.Columns["Turma"].Width = 80;

                if (dgv.Columns.Contains(dgv.Columns["Curso"])) dgv.Columns["Curso"].Width = 300;

                if (dgv.Columns.Contains(dgv.Columns["Unidade"]))
                {
                    dgv.Columns["Unidade"].Width = 250;
                    dgv.Columns["Unidade"].Visible = false;
                }

                if (dgv.Columns.Contains(dgv.Columns["Certificado"])) dgv.Columns["Certificado"].Width = 80;

                if (dgv.Columns.Contains(dgv.Columns["Envio"]))
                {
                    dgv.Columns["Envio"].Width = 80;
                    dgv.Columns["Envio"].Visible = true; // Remove a visibilidade da coluna nesta visão
                }
            }
        }
        catch (ArgumentOutOfRangeException) { throw; }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (InvalidOperationException) { throw; }
        catch (Exception) { throw; }

    }

    /// <summary>
    /// Método responsável por adicionar novas colunas no datagridview
    /// </summary>
    /// <param name="tipoColuna">Tipo da coluna a ser inserida</param>
    /// <param name="nomeColuna">Nome que será atribuido à nova coluna</param>
    /// <param name="dgv">DataGridView que receverá as novas colunas</param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="NullReferenceException"></exception>
    public static void CriarColunaDGV(Type tipoColuna, string nomeColuna, DataGridView dgv)
    {
        try
        {
            // Adiciona a coluna se não existir
            switch (tipoColuna)
            {
                case Type t when t.Equals(typeof(DataGridViewCheckBoxColumn)):
                    DataGridViewCheckBoxColumn colunaCheckBox = new();
                    colunaCheckBox.Name = nomeColuna;
                    if (!dgv.Columns.Contains(dgv.Columns[nomeColuna])) dgv.Columns.Add(colunaCheckBox);
                    break;
                case Type t when t.Equals(typeof(DataGridViewImageColumn)):
                    DataGridViewImageColumn colunaImagem = new();
                    colunaImagem.Name = nomeColuna;
                    colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    if (!dgv.Columns.Contains(dgv.Columns[nomeColuna])) dgv.Columns.Add(colunaImagem);
                    break;
                case Type t when t.Equals(typeof(DataGridViewTextBoxColumn)):
                    DataGridViewTextBoxColumn colunaTextBox = new();
                    colunaTextBox.Name = nomeColuna;
                    if (!dgv.Columns.Contains(dgv.Columns[nomeColuna])) dgv.Columns.Add(colunaTextBox);
                    break;
                case Type t when t.Equals(typeof(DataGridViewButtonColumn)):
                    DataGridViewButtonColumn colunaBotao = new();
                    colunaBotao.Name = nomeColuna;
                    if (!dgv.Columns.Contains(dgv.Columns[nomeColuna])) dgv.Columns.Add(colunaBotao);
                    break;
                default:
                    throw new ArgumentException("Tipo de coluna não aceito para o escopo.");
            }
        }
        catch (ArgumentNullException) { throw; }
        catch (ArgumentException) { throw; }
        catch (InvalidOperationException) { throw; }
        catch (Exception) { throw; }
    }
}
