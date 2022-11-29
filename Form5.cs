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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void пациентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Evmenova______1_DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Evmenova______1_DataSet.пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this._Evmenova______1_DataSet.пациенты);

        }
    }
}
