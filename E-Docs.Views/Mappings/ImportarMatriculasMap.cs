using E_Docs.Presenter.DTOs;
using E_Docs.Views.Common;
using System;
using System.Data;
using System.Windows.Forms;

namespace E_Docs.Views.Mappings;
internal class ImportarMatriculasMap
{
    /// <summary>
    /// Método responsável por converter DataGridView em DataTable
    /// </summary>
    /// <param name="dgv">DataGridView que será convertido</param>
    /// <returns>Retorna um DataTable com os dados carregados</returns>
    public static DataTable ConvertDataGridViewToDataTable(DataGridView dgv)
    {
        // Criar um novo DataTable
        DataTable dataTable = new DataTable();

        // Adicionar colunas ao DataTable com base nas colunas do DataGridView
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            dataTable.Columns.Add(column.HeaderText, column.ValueType ?? typeof(string));
        }

        // Adicionar linhas ao DataTable com base nas linhas do DataGridView
        foreach (DataGridViewRow row in dgv.Rows)
        {
            // Ignorar linhas não preenchidas (como a última linha de entrada)
            if (!row.IsNewRow && row.Cells["[X]"].Value.Equals(true))
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewColumn column in dgv.Columns)
                {

                    //dataRow[column.HeaderText] = row.Cells[column.Index].Value ?? DBNull.Value;
                    dataRow[column.Name] = row.Cells[column.Name].Value ?? DBNull.Value;

                }
                dataTable.Rows.Add(dataRow);
            }
        }

        return dataTable;
    }

    public static void TransferirRegistrosEntreDgv(DataGridView dgv, DataGridView dgvSelecionados)
    {
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            dgvSelecionados.Columns.Add(column);
        }

        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.Cells["[X]"] is DataGridViewCheckBoxCell chk && chk.Value != null && (bool)chk.Value)
            {
                dgvSelecionados.Rows.Add(row);
            }
        } 






        //var dt = new DataTable();

        //// Adicionar colunas baseadas nas propriedades da classe "Matricula"
        //dt.Columns.Add("Aluno", typeof(string));
        //dt.Columns.Add("CPF", typeof(string));
        //dt.Columns.Add("Email", typeof(string));
        //dt.Columns.Add("Curso", typeof(string));
        //dt.Columns.Add("Turma", typeof(string));
        //dt.Columns.Add("Unidade", typeof(string));

        //dt.Columns.Add("[X]", typeof(bool));
        //dt.Columns.Add("Certificado", typeof(string));
        //dt.Columns.Add("Envio", typeof(string));



        //// Adicionar linhas com os dados da lista
        //foreach (var matricula in matriculas)
        //{
        //    DataRow row = dt.NewRow();
        //    row["Aluno"] = matricula.Aluno;
        //    row["CPF"] = matricula.Cpf;
        //    row["Email"] = matricula.Email;
        //    row["Curso"] = matricula.Curso;
        //    row["Turma"] = matricula.Turma;

        //    row["[X]"] = matricula.;
        //    row["Certificado"] = matricula.Turma;
        //    row["Envio"] = matricula.Turma;
        //    dt.Rows.Add(row);
        //}

        //return dt;
    }
}
