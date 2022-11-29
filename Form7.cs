using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void лекарстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.лекарстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Evmenova______1_DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Evmenova______1_DataSet.лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this._Evmenova______1_DataSet.лекарства);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
            {
                лекарстваDataGridView.Sort(Col,ListSortDirection.Ascending);
            }
            else
            {
                лекарстваDataGridView.Sort(Col,ListSortDirection.Descending);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            лекарстваBindingSource.Filter = "Цена_лекарства=" + groupBox1.Text + "";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            лекарстваBindingSource.Filter = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;

            for (i = 0; i < лекарстваDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < лекарстваDataGridView.RowCount - 1; j++)
                {
                    лекарстваDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    лекарстваDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }

            for (i = 0; i < лекарстваDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < лекарстваDataGridView.RowCount; j++)
                {
                    var value = лекарстваDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            лекарстваDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            лекарстваDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
    }
}

  

