namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label код_должностиLabel;
            System.Windows.Forms.Label наименование_должностиLabel;
            System.Windows.Forms.Label окладLabel;
            System.Windows.Forms.Label обязанностиLabel;
            System.Windows.Forms.Label требованияLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Evmenova______1_DataSet = new WindowsFormsApp2._Evmenova______1_DataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.должностиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager();
            this.должностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.должностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_должностиTextBox = new System.Windows.Forms.TextBox();
            this.наименование_должностиTextBox = new System.Windows.Forms.TextBox();
            this.окладTextBox = new System.Windows.Forms.TextBox();
            this.обязанностиTextBox = new System.Windows.Forms.TextBox();
            this.требованияTextBox = new System.Windows.Forms.TextBox();
            код_должностиLabel = new System.Windows.Forms.Label();
            наименование_должностиLabel = new System.Windows.Forms.Label();
            окладLabel = new System.Windows.Forms.Label();
            обязанностиLabel = new System.Windows.Forms.Label();
            требованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).BeginInit();
            this.должностиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(366, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должности";
            // 
            // _Evmenova______1_DataSet
            // 
            this._Evmenova______1_DataSet.DataSetName = "_Evmenova______1_DataSet";
            this._Evmenova______1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "должности";
            this.должностиBindingSource.DataSource = this._Evmenova______1_DataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.болезниTableAdapter = null;
            this.tableAdapterManager.должностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.лекарстваTableAdapter = null;
            this.tableAdapterManager.пациентыTableAdapter = null;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // должностиBindingNavigator
            // 
            this.должностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.должностиBindingNavigator.BindingSource = this.должностиBindingSource;
            this.должностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.должностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.должностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.должностиBindingNavigatorSaveItem});
            this.должностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.должностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.должностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.должностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.должностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.должностиBindingNavigator.Name = "должностиBindingNavigator";
            this.должностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.должностиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.должностиBindingNavigator.TabIndex = 1;
            this.должностиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // должностиBindingNavigatorSaveItem
            // 
            this.должностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.должностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("должностиBindingNavigatorSaveItem.Image")));
            this.должностиBindingNavigatorSaveItem.Name = "должностиBindingNavigatorSaveItem";
            this.должностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.должностиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.должностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.должностиBindingNavigatorSaveItem_Click);
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Location = new System.Drawing.Point(323, 97);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(86, 13);
            код_должностиLabel.TabIndex = 2;
            код_должностиLabel.Text = "код должности:";
            // 
            // код_должностиTextBox
            // 
            this.код_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "код должности", true));
            this.код_должностиTextBox.Location = new System.Drawing.Point(415, 94);
            this.код_должностиTextBox.Name = "код_должностиTextBox";
            this.код_должностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_должностиTextBox.TabIndex = 3;
            // 
            // наименование_должностиLabel
            // 
            наименование_должностиLabel.AutoSize = true;
            наименование_должностиLabel.Location = new System.Drawing.Point(267, 136);
            наименование_должностиLabel.Name = "наименование_должностиLabel";
            наименование_должностиLabel.Size = new System.Drawing.Size(142, 13);
            наименование_должностиLabel.TabIndex = 4;
            наименование_должностиLabel.Text = "наименование должности:";
            // 
            // наименование_должностиTextBox
            // 
            this.наименование_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "наименование должности", true));
            this.наименование_должностиTextBox.Location = new System.Drawing.Point(415, 133);
            this.наименование_должностиTextBox.Name = "наименование_должностиTextBox";
            this.наименование_должностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименование_должностиTextBox.TabIndex = 5;
            // 
            // окладLabel
            // 
            окладLabel.AutoSize = true;
            окладLabel.Location = new System.Drawing.Point(369, 179);
            окладLabel.Name = "окладLabel";
            окладLabel.Size = new System.Drawing.Size(40, 13);
            окладLabel.TabIndex = 6;
            окладLabel.Text = "оклад:";
            // 
            // окладTextBox
            // 
            this.окладTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "оклад", true));
            this.окладTextBox.Location = new System.Drawing.Point(415, 176);
            this.окладTextBox.Name = "окладTextBox";
            this.окладTextBox.Size = new System.Drawing.Size(100, 20);
            this.окладTextBox.TabIndex = 7;
            // 
            // обязанностиLabel
            // 
            обязанностиLabel.AutoSize = true;
            обязанностиLabel.Location = new System.Drawing.Point(334, 223);
            обязанностиLabel.Name = "обязанностиLabel";
            обязанностиLabel.Size = new System.Drawing.Size(75, 13);
            обязанностиLabel.TabIndex = 8;
            обязанностиLabel.Text = "обязанности:";
            // 
            // обязанностиTextBox
            // 
            this.обязанностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "обязанности", true));
            this.обязанностиTextBox.Location = new System.Drawing.Point(415, 220);
            this.обязанностиTextBox.Name = "обязанностиTextBox";
            this.обязанностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.обязанностиTextBox.TabIndex = 9;
            // 
            // требованияLabel
            // 
            требованияLabel.AutoSize = true;
            требованияLabel.Location = new System.Drawing.Point(340, 266);
            требованияLabel.Name = "требованияLabel";
            требованияLabel.Size = new System.Drawing.Size(69, 13);
            требованияLabel.TabIndex = 10;
            требованияLabel.Text = "требования:";
            // 
            // требованияTextBox
            // 
            this.требованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "требования", true));
            this.требованияTextBox.Location = new System.Drawing.Point(415, 263);
            this.требованияTextBox.Name = "требованияTextBox";
            this.требованияTextBox.Size = new System.Drawing.Size(100, 20);
            this.требованияTextBox.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(требованияLabel);
            this.Controls.Add(this.требованияTextBox);
            this.Controls.Add(обязанностиLabel);
            this.Controls.Add(this.обязанностиTextBox);
            this.Controls.Add(окладLabel);
            this.Controls.Add(this.окладTextBox);
            this.Controls.Add(наименование_должностиLabel);
            this.Controls.Add(this.наименование_должностиTextBox);
            this.Controls.Add(код_должностиLabel);
            this.Controls.Add(this.код_должностиTextBox);
            this.Controls.Add(this.должностиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).EndInit();
            this.должностиBindingNavigator.ResumeLayout(false);
            this.должностиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Evmenova______1_DataSet _Evmenova______1_DataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private _Evmenova______1_DataSetTableAdapters.должностиTableAdapter должностиTableAdapter;
        private _Evmenova______1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator должностиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton должностиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_должностиTextBox;
        private System.Windows.Forms.TextBox наименование_должностиTextBox;
        private System.Windows.Forms.TextBox окладTextBox;
        private System.Windows.Forms.TextBox обязанностиTextBox;
        private System.Windows.Forms.TextBox требованияTextBox;
    }
}