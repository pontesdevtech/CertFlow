﻿using E_Docs.Presenter.Common;
using E_Docs.Presenter.Common.Enums;
using E_Docs.Presenter.DTOs;
using E_Docs.Presenter.Services;
using E_Docs.Views.Common;
using E_Docs.Views.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_Docs.Views.Services;
internal static class ImportarMatriculasService
{
    /// <summary>
    /// Método responsável por carregar o data grid com as informações das matrículas
    /// </summary>
    /// <param name="diretorio">Diretório do arquivo com a lista de matrículas</param>
    /// <param name="dgv">Data grid que será carregado com as informações das matrículas</param>
    /// <returns>Retorna uma lista de logs de erros. Retorna lista vazia, caso não ocorra nenhuma exceção</returns>
    internal static (List<MatriculaDTO>matriculas, List<CertificadoDTO>certificados, List<LogDTO>logs) ImportarMatriculas(string diretorio, DataGridView dgv)
    {
        // Monitorar a execução do processo
        var dt = ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.CarregarMatriculas, () => MatriculaService.CarregarMatriculas(diretorio, ConfiguracaoCommon.pswd()));
        dgv.DataSource = dt.retorno.matriculasDt;
        if (dt.logs.Count == 0) ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.FormatarTabela, () => FormatacaoCommon.FormatarDgv(dgv));

        if (dt.logs.Count > 0)
        {
            ExcecoesView excecoesView = new();
            var contador = 1;
            foreach (var log in dt.logs)
            {
                if (contador == 1) excecoesView.Text = log.GetMensagem().titulo;
                if (contador == 1) excecoesView.MensagemErroLBL.Text = log.GetMensagem().mensagem;
                excecoesView.InformacoesBasicasTXT.Text += log.GetMensagem().informacoesBasicas;
                excecoesView.InformacoesTecnicasTXT.Text += log.GetMensagem().informacoesTecnicas;
                contador++;
            }
            excecoesView.ShowDialog();
        }

        return (dt.retorno.matriculasDTO, dt.retorno.certificadosDTO, dt.logs);
    }

    internal static void TransferirRegistros(DataGridView dgv)
    {
        var retorno = ExecutorProcessosCommon.ExecutarProcesso(ENomeProcessoCommon.FormatarTabela, () => FormatacaoCommon.FormatarDgv(dgv));

        if (retorno.Count > 0)
        {
            ExcecoesView excecoesView = new();
            var contador = 1;
            foreach (var log in retorno)
            {
                if (contador == 1) excecoesView.Text = log.GetMensagem().titulo;
                if (contador == 1) excecoesView.MensagemErroLBL.Text = log.GetMensagem().mensagem;
                excecoesView.InformacoesBasicasTXT.Text += log.GetMensagem().informacoesBasicas;
                excecoesView.InformacoesTecnicasTXT.Text += log.GetMensagem().informacoesTecnicas;
                contador++;
            }
            excecoesView.ShowDialog();
        }
    }
}
