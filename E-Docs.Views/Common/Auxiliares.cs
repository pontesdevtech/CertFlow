using E_Docs.Domain.Entities;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Mappings;
using System.Data;

namespace E_Docs.Views.Common;
public static class Auxiliares
{
    public static void FiltrarMatriculas(CheckBox chk, DataGridView dgv, List<MatriculaDTO> matriculasDto, List<CertificadoDTO> certificadosDto, ToolStripLabel feedback, string diretorioImagens)
    {
        List<MatriculaDTO> filtroDto = [];

        foreach (var matricula in matriculasDto)
        {
            if(certificadosDto.FirstOrDefault(x => x.Matricula.Cpf.Equals(matricula.Cpf)) != null) filtroDto.Add(matricula);
        }

        // Configurar exibição dos dados no datagridview
        if (chk.Checked)
        {
            dgv.DataSource = MatriculaMap.ConverterListaDtoParaDataTable(filtroDto);
        }
        else
        {
            dgv.DataSource = MatriculaMap.ConverterListaDtoParaDataTable(matriculasDto);
        }
        FormatacaoCommon.FormatarDgv(dgv);
        IdentificarMatriculasComCertificado(dgv, certificadosDto, diretorioImagens);
        feedback.Text = ContarRegistros(dgv).feedback;
    }

    public static (int total, int selecionados, string feedback) ContarRegistros(DataGridView dgv)
    {
        int total = dgv.Rows.Count;
        int selecionados = 0;

        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.Cells["[X]"] is DataGridViewCheckBoxCell chk && chk.Value != null && (bool)chk.Value) selecionados++;
        }

        return (total, selecionados, $"Registros Selecionados: {selecionados}/{total}");
    }

    public static void IdentificarMatriculasComCertificado(DataGridView dgv, List<CertificadoDTO> certificados, string diretorioImagens)
    {
        foreach (DataGridViewRow row in dgv.Rows)
        {
            string? aluno = row.Cells["Aluno"].Value.ToString();
            if (certificados.FirstOrDefault(x => x.NomeAluno.Equals(aluno.Split(" - ")[1])) != null)
            {
                row.Cells["Certificado"].Value = Image.FromFile(Path.Combine(diretorioImagens, "Certificado.png"));
                row.Cells["Unidade"].Value = certificados.FirstOrDefault(x => x.NomeAluno.Equals(aluno.Split(" - ")[1])).Unidade;
            }
            else
            {
                row.Cells["Certificado"].Value = Image.FromFile(Path.Combine(diretorioImagens, "Pendente.png"));
            }
        }
    }
}
