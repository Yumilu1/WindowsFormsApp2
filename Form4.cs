using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void лекарстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.лекарстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Evmenova______1_DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Evmenova______1_DataSet.лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this._Evmenova______1_DataSet.лекарства);

        }
    }
}
