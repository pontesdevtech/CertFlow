using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Mappings;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace E_Docs.Views.Common;
public static class Auxiliares
{
    public static void FiltrarMatriculas(bool filtrar, DataGridView dgv, List<MatriculaDTO> matriculasDto, List<CertificadoDTO> certificadosDto, ToolStripLabel feedback)
    {
        List<MatriculaDTO> filtroDto = [];

        foreach (var matricula in matriculasDto)
        {
            if (certificadosDto.FirstOrDefault(x => x.Matricula.Cpf.Equals(matricula.Cpf)) != null) filtroDto.Add(matricula);
        }

        // Configurar exibição dos dados no datagridview
        if (filtrar)
        {
            dgv.DataSource = MatriculaMap.ConverterListaDtoParaDataTable(filtroDto);
        }
        else
        {
            dgv.DataSource = MatriculaMap.ConverterListaDtoParaDataTable(matriculasDto);
        }
        FormatacaoCommon.FormatarDgv(dgv);
        IdentificarMatriculasComCertificado(dgv, certificadosDto);
        IdentificarEmailsEnviados(dgv, new());
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

    public static void IdentificarMatriculasComCertificado(DataGridView dgv, List<CertificadoDTO> certificados)
    {
        foreach (DataGridViewRow row in dgv.Rows)
        {
            string? aluno = row.Cells["Aluno"].Value.ToString();
            if (certificados.FirstOrDefault(x => x.NomeAluno.Equals(aluno.Split(" - ")[1])) != null)
            {
                row.Cells["Certificado"].Value = Properties.Resources.CertificadoVerde;
                row.Cells["Unidade"].Value = certificados.FirstOrDefault(x => x.NomeAluno.Equals(aluno.Split(" - ")[1])).Unidade;
            }
            else
            {
                row.Cells["Certificado"].Value = Properties.Resources.PendenteVermelho;
            }
        }
    }

    public static void IdentificarEmailsEnviados(DataGridView dgv, List<EmailDTO> emails)
    {
        foreach (DataGridViewRow row in dgv.Rows)
        {
            string? aluno = row.Cells["Aluno"].Value.ToString();
            if (emails.FirstOrDefault(x => x.Matricula.Aluno.Equals(aluno)) != null)
            {
                row.Cells["Envio"].Value = Properties.Resources.EmailVerde;
            }
            else
            {
                row.Cells["Envio"].Value = Properties.Resources.PendenteVermelho;

            }
        }
    }

    public static string InserirTag(string opcao) => $"[{opcao}]";
}
