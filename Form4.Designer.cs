namespace WindowsFormsApp2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label код_лекарстваLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label показанияLabel;
            System.Windows.Forms.Label противопоказанияLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label упаковкаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Evmenova______1_DataSet = new WindowsFormsApp2._Evmenova______1_DataSet();
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваTableAdapter = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.лекарстваTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager();
            this.лекарстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.лекарстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_лекарстваTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.показанияTextBox = new System.Windows.Forms.TextBox();
            this.противопоказанияTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.упаковкаTextBox = new System.Windows.Forms.TextBox();
            код_лекарстваLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            показанияLabel = new System.Windows.Forms.Label();
            противопоказанияLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            упаковкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingNavigator)).BeginInit();
            this.лекарстваBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(364, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лекарства";
            // 
            // _Evmenova______1_DataSet
            // 
            this._Evmenova______1_DataSet.DataSetName = "_Evmenova______1_DataSet";
            this._Evmenova______1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "лекарства";
            this.лекарстваBindingSource.DataSource = this._Evmenova______1_DataSet;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.болезниTableAdapter = null;
            this.tableAdapterManager.должностиTableAdapter = null;
            this.tableAdapterManager.лекарстваTableAdapter = this.лекарстваTableAdapter;
            this.tableAdapterManager.пациентыTableAdapter = null;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // лекарстваBindingNavigator
            // 
            this.лекарстваBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.лекарстваBindingNavigator.BindingSource = this.лекарстваBindingSource;
            this.лекарстваBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.лекарстваBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.лекарстваBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.лекарстваBindingNavigatorSaveItem});
            this.лекарстваBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.лекарстваBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.лекарстваBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.лекарстваBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.лекарстваBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.лекарстваBindingNavigator.Name = "лекарстваBindingNavigator";
            this.лекарстваBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.лекарстваBindingNavigator.Size = new System.Drawing.Size(829, 25);
            this.лекарстваBindingNavigator.TabIndex = 1;
            this.лекарстваBindingNavigator.Text = "bindingNavigator1";
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
            // лекарстваBindingNavigatorSaveItem
            // 
            this.лекарстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.лекарстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("лекарстваBindingNavigatorSaveItem.Image")));
            this.лекарстваBindingNavigatorSaveItem.Name = "лекарстваBindingNavigatorSaveItem";
            this.лекарстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.лекарстваBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.лекарстваBindingNavigatorSaveItem.Click += new System.EventHandler(this.лекарстваBindingNavigatorSaveItem_Click);
            // 
            // код_лекарстваLabel
            // 
            код_лекарстваLabel.AutoSize = true;
            код_лекарстваLabel.Location = new System.Drawing.Point(321, 94);
            код_лекарстваLabel.Name = "код_лекарстваLabel";
            код_лекарстваLabel.Size = new System.Drawing.Size(84, 13);
            код_лекарстваLabel.TabIndex = 2;
            код_лекарстваLabel.Text = "код лекарства:";
            // 
            // код_лекарстваTextBox
            // 
            this.код_лекарстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лекарстваBindingSource, "код лекарства", true));
            this.код_лекарстваTextBox.Location = new System.Drawing.Point(411, 91);
            this.код_лекарстваTextBox.Name = "код_лекарстваTextBox";
            this.код_лекарстваTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_лекарстваTextBox.TabIndex = 3;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(321, 131);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(84, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лекарстваBindingSource, "наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(411, 128);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // показанияLabel
            // 
            показанияLabel.AutoSize = true;
            показанияLabel.Location = new System.Drawing.Point(341, 169);
            показанияLabel.Name = "показанияLabel";
            показанияLabel.Size = new System.Drawing.Size(64, 13);
            показанияLabel.TabIndex = 6;
            показанияLabel.Text = "показания:";
            // 
            // показанияTextBox
            // 
            this.показанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лекарстваBindingSource, "показания", true));
            this.показанияTextBox.Location = new System.Drawing.Point(411, 166);
            this.показанияTextBox.Name = "показанияTextBox";
            this.показанияTextBox.Size = new System.Drawing.Size(100, 20);
            this.показанияTextBox.TabIndex = 7;
            // 
            // противопоказанияLabel
            // 
            противопоказанияLabel.AutoSize = true;
            противопоказанияLabel.Location = new System.Drawing.Point(300, 203);
            противопоказанияLabel.Name = "противопоказанияLabel";
            противопоказанияLabel.Size = new System.Drawing.Size(105, 13);
            противопоказанияLabel.TabIndex = 8;
            противопоказанияLabel.Text = "противопоказания:";
            // 
            // противопоказанияTextBox
            // 
            this.противопоказанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лекарстваBindingSource, "противопоказания", true));
            this.противопоказанияTextBox.Location = new System.Drawing.Point(411, 200);
            this.противопоказанияTextBox.Name = "противопоказанияTextBox";
            this.противопоказанияTextBox.Size = new System.Drawing.Size(100, 20);
            this.противопоказанияTextBox.TabIndex = 9;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(341, 240);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(64, 13);
            стоимостьLabel.TabIndex = 10;
            стоимостьLabel.Text = "стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лекарстваBindingSource, "стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(411, 237);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 11;
            // 
            // упаковкаLabel
            // 
            упаковкаLabel.AutoSize = true;
            упаковкаLabel.Location = new System.Drawing.Point(348, 278);
            упаковкаLabel.Name = "упаковкаLabel";
            упаковкаLabel.Size = new System.Drawing.Size(57, 13);
            упаковкаLabel.TabIndex = 12;
            упаковкаLabel.Text = "упаковка:";
            // 
            // упаковкаTextBox
            // 
            this.упаковкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.лекарстваBindingSource, "упаковка", true));
            this.упаковкаTextBox.Location = new System.Drawing.Point(411, 275);
            this.упаковкаTextBox.Name = "упаковкаTextBox";
            this.упаковкаTextBox.Size = new System.Drawing.Size(100, 20);
            this.упаковкаTextBox.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(упаковкаLabel);
            this.Controls.Add(this.упаковкаTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(противопоказанияLabel);
            this.Controls.Add(this.противопоказанияTextBox);
            this.Controls.Add(показанияLabel);
            this.Controls.Add(this.показанияTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_лекарстваLabel);
            this.Controls.Add(this.код_лекарстваTextBox);
            this.Controls.Add(this.лекарстваBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingNavigator)).EndInit();
            this.лекарстваBindingNavigator.ResumeLayout(false);
            this.лекарстваBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Evmenova______1_DataSet _Evmenova______1_DataSet;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private _Evmenova______1_DataSetTableAdapters.лекарстваTableAdapter лекарстваTableAdapter;
        private _Evmenova______1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator лекарстваBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton лекарстваBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_лекарстваTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox показанияTextBox;
        private System.Windows.Forms.TextBox противопоказанияTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox упаковкаTextBox;
    }
}