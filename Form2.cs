﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void болезниBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.болезниBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Evmenova______1_DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Evmenova______1_DataSet.болезни". При необходимости она может быть перемещена или удалена.
            this.болезниTableAdapter.Fill(this._Evmenova______1_DataSet.болезни);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
