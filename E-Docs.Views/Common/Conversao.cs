using System.Data;

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
                    dataRow[column.HeaderText] = row.Cells[column.Index].Value ?? DBNull.Value;
                }
                dataTable.Rows.Add(dataRow);
            }
        }

        return dataTable;
    }
}
