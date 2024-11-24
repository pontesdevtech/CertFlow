using iText.Layout.Element;
using System;
using System.Data;
using System.Windows.Forms;

namespace E_Docs.Views.Common;
public static class Conversao
{
    public static DataTable ConvertDataGridViewToDataTable(DataGridView dgv)
    {
        // Criar um novo DataTable
        DataTable dataTable = new DataTable();

        // Adicionar colunas ao DataTable com base nas colunas do DataGridView
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            if (column.Name != "[X]" && column.Name != "Unidade" && column.Name != "Certificado" && column.Name != "Envio")
            {
                dataTable.Columns.Add(column.Name, column.ValueType ?? typeof(string));
            }
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
                    if (column.Name != "[X]" && column.Name != "Unidade" && column.Name != "Certificado" && column.Name != "Envio")
                    {
                        dataRow[column.Name] = row.Cells[column.Name].Value ?? DBNull.Value;
                    }
                }
                dataTable.Rows.Add(dataRow);
            }
        }

        return dataTable;
    }
}