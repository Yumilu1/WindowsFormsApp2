namespace WindowsFormsApp2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label дата_обращенияLabel;
            System.Windows.Forms.Label код_болезниLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label результат_леченияLabel;
            System.Windows.Forms.Label имяLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Evmenova______1_DataSet = new WindowsFormsApp2._Evmenova______1_DataSet();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыTableAdapter = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.пациентыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager();
            this.пациентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.пациентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.дата_обращенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_болезниTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.результат_леченияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            код_пациентаLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            дата_обращенияLabel = new System.Windows.Forms.Label();
            код_болезниLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            результат_леченияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingNavigator)).BeginInit();
            this.пациентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(384, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пациенты";
            // 
            // _Evmenova______1_DataSet
            // 
            this._Evmenova______1_DataSet.DataSetName = "_Evmenova______1_DataSet";
            this._Evmenova______1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "пациенты";
            this.пациентыBindingSource.DataSource = this._Evmenova______1_DataSet;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.болезниTableAdapter = null;
            this.tableAdapterManager.должностиTableAdapter = null;
            this.tableAdapterManager.лекарстваTableAdapter = null;
            this.tableAdapterManager.пациентыTableAdapter = this.пациентыTableAdapter;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // пациентыBindingNavigator
            // 
            this.пациентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пациентыBindingNavigator.BindingSource = this.пациентыBindingSource;
            this.пациентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пациентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пациентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.пациентыBindingNavigatorSaveItem});
            this.пациентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пациентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пациентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пациентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пациентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пациентыBindingNavigator.Name = "пациентыBindingNavigator";
            this.пациентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пациентыBindingNavigator.Size = new System.Drawing.Size(880, 25);
            this.пациентыBindingNavigator.TabIndex = 1;
            this.пациентыBindingNavigator.Text = "bindingNavigator1";
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
            // пациентыBindingNavigatorSaveItem
            // 
            this.пациентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пациентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пациентыBindingNavigatorSaveItem.Image")));
            this.пациентыBindingNavigatorSaveItem.Name = "пациентыBindingNavigatorSaveItem";
            this.пациентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.пациентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пациентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.пациентыBindingNavigatorSaveItem_Click);
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Location = new System.Drawing.Point(329, 95);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(78, 13);
            код_пациентаLabel.TabIndex = 2;
            код_пациентаLabel.Text = "код пациента:";
            // 
            // код_пациентаTextBox
            // 
            this.код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "код пациента", true));
            this.код_пациентаTextBox.Location = new System.Drawing.Point(413, 92);
            this.код_пациентаTextBox.Name = "код_пациентаTextBox";
            this.код_пациентаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_пациентаTextBox.TabIndex = 3;
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Location = new System.Drawing.Point(356, 121);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(51, 13);
            возрастLabel.TabIndex = 4;
            возрастLabel.Text = "возраст:";
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(413, 118);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 20);
            this.возрастTextBox.TabIndex = 5;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(379, 147);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(28, 13);
            полLabel.TabIndex = 6;
            полLabel.Text = "пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "пол", true));
            this.полTextBox.Location = new System.Drawing.Point(413, 144);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(100, 20);
            this.полTextBox.TabIndex = 7;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(367, 173);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(40, 13);
            адресLabel.TabIndex = 8;
            адресLabel.Text = "адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(413, 170);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 9;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(354, 199);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(53, 13);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(413, 196);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 20);
            this.телефонTextBox.TabIndex = 11;
            // 
            // дата_обращенияLabel
            // 
            дата_обращенияLabel.AutoSize = true;
            дата_обращенияLabel.Location = new System.Drawing.Point(314, 226);
            дата_обращенияLabel.Name = "дата_обращенияLabel";
            дата_обращенияLabel.Size = new System.Drawing.Size(93, 13);
            дата_обращенияLabel.TabIndex = 12;
            дата_обращенияLabel.Text = "дата обращения:";
            // 
            // дата_обращенияDateTimePicker
            // 
            this.дата_обращенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пациентыBindingSource, "дата обращения", true));
            this.дата_обращенияDateTimePicker.Location = new System.Drawing.Point(413, 222);
            this.дата_обращенияDateTimePicker.Name = "дата_обращенияDateTimePicker";
            this.дата_обращенияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_обращенияDateTimePicker.TabIndex = 13;
            // 
            // код_болезниLabel
            // 
            код_болезниLabel.AutoSize = true;
            код_болезниLabel.Location = new System.Drawing.Point(334, 251);
            код_болезниLabel.Name = "код_болезниLabel";
            код_болезниLabel.Size = new System.Drawing.Size(73, 13);
            код_болезниLabel.TabIndex = 14;
            код_болезниLabel.Text = "код болезни:";
            // 
            // код_болезниTextBox
            // 
            this.код_болезниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "код болезни", true));
            this.код_болезниTextBox.Location = new System.Drawing.Point(413, 248);
            this.код_болезниTextBox.Name = "код_болезниTextBox";
            this.код_болезниTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_болезниTextBox.TabIndex = 15;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(318, 279);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(89, 13);
            код_сотрудникаLabel.TabIndex = 16;
            код_сотрудникаLabel.Text = "код сотрудника:";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(413, 276);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_сотрудникаTextBox.TabIndex = 17;
            // 
            // результат_леченияLabel
            // 
            результат_леченияLabel.AutoSize = true;
            результат_леченияLabel.Location = new System.Drawing.Point(302, 305);
            результат_леченияLabel.Name = "результат_леченияLabel";
            результат_леченияLabel.Size = new System.Drawing.Size(105, 13);
            результат_леченияLabel.TabIndex = 18;
            результат_леченияLabel.Text = "результат лечения:";
            // 
            // результат_леченияTextBox
            // 
            this.результат_леченияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "результат лечения", true));
            this.результат_леченияTextBox.Location = new System.Drawing.Point(413, 302);
            this.результат_леченияTextBox.Name = "результат_леченияTextBox";
            this.результат_леченияTextBox.Size = new System.Drawing.Size(100, 20);
            this.результат_леченияTextBox.TabIndex = 19;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(377, 331);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(30, 13);
            имяLabel.TabIndex = 20;
            имяLabel.Text = "имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(413, 328);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 21;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 468);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(результат_леченияLabel);
            this.Controls.Add(this.результат_леченияTextBox);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(код_болезниLabel);
            this.Controls.Add(this.код_болезниTextBox);
            this.Controls.Add(дата_обращенияLabel);
            this.Controls.Add(this.дата_обращенияDateTimePicker);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(this.код_пациентаTextBox);
            this.Controls.Add(this.пациентыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingNavigator)).EndInit();
            this.пациентыBindingNavigator.ResumeLayout(false);
            this.пациентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Evmenova______1_DataSet _Evmenova______1_DataSet;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private _Evmenova______1_DataSetTableAdapters.пациентыTableAdapter пациентыTableAdapter;
        private _Evmenova______1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пациентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton пациентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_пациентаTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DateTimePicker дата_обращенияDateTimePicker;
        private System.Windows.Forms.TextBox код_болезниTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox результат_леченияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
    }
}