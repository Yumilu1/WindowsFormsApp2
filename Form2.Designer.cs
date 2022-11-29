namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label код_болезниLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label симптомыLabel;
            System.Windows.Forms.Label продолжительностьLabel;
            System.Windows.Forms.Label последствияLabel;
            System.Windows.Forms.Label код_лекарства_1Label;
            this.label1 = new System.Windows.Forms.Label();
            this._Evmenova______1_DataSet = new WindowsFormsApp2._Evmenova______1_DataSet();
            this.болезниBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.болезниTableAdapter = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.болезниTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager();
            this.болезниBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.болезниBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_болезниTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.симптомыTextBox = new System.Windows.Forms.TextBox();
            this.продолжительностьTextBox = new System.Windows.Forms.TextBox();
            this.последствияTextBox = new System.Windows.Forms.TextBox();
            this.код_лекарства_1TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            код_болезниLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            симптомыLabel = new System.Windows.Forms.Label();
            продолжительностьLabel = new System.Windows.Forms.Label();
            последствияLabel = new System.Windows.Forms.Label();
            код_лекарства_1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingNavigator)).BeginInit();
            this.болезниBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(389, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Болезни";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Evmenova______1_DataSet
            // 
            this._Evmenova______1_DataSet.DataSetName = "_Evmenova______1_DataSet";
            this._Evmenova______1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // болезниBindingSource
            // 
            this.болезниBindingSource.DataMember = "болезни";
            this.болезниBindingSource.DataSource = this._Evmenova______1_DataSet;
            // 
            // болезниTableAdapter
            // 
            this.болезниTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2._Evmenova______1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.болезниTableAdapter = this.болезниTableAdapter;
            this.tableAdapterManager.должностиTableAdapter = null;
            this.tableAdapterManager.лекарстваTableAdapter = null;
            this.tableAdapterManager.пациентыTableAdapter = null;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // болезниBindingNavigator
            // 
            this.болезниBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.болезниBindingNavigator.BindingSource = this.болезниBindingSource;
            this.болезниBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.болезниBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.болезниBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.болезниBindingNavigatorSaveItem});
            this.болезниBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.болезниBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.болезниBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.болезниBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.болезниBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.болезниBindingNavigator.Name = "болезниBindingNavigator";
            this.болезниBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.болезниBindingNavigator.Size = new System.Drawing.Size(798, 25);
            this.болезниBindingNavigator.TabIndex = 1;
            this.болезниBindingNavigator.Text = "bindingNavigator1";
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
            // болезниBindingNavigatorSaveItem
            // 
            this.болезниBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.болезниBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("болезниBindingNavigatorSaveItem.Image")));
            this.болезниBindingNavigatorSaveItem.Name = "болезниBindingNavigatorSaveItem";
            this.болезниBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.болезниBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.болезниBindingNavigatorSaveItem.Click += new System.EventHandler(this.болезниBindingNavigatorSaveItem_Click);
            // 
            // код_болезниLabel
            // 
            код_болезниLabel.AutoSize = true;
            код_болезниLabel.Location = new System.Drawing.Point(350, 109);
            код_болезниLabel.Name = "код_болезниLabel";
            код_болезниLabel.Size = new System.Drawing.Size(73, 13);
            код_болезниLabel.TabIndex = 2;
            код_болезниLabel.Text = "код болезни:";
            // 
            // код_болезниTextBox
            // 
            this.код_болезниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "код болезни", true));
            this.код_болезниTextBox.Location = new System.Drawing.Point(429, 106);
            this.код_болезниTextBox.Name = "код_болезниTextBox";
            this.код_болезниTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_болезниTextBox.TabIndex = 3;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(339, 150);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(84, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(429, 147);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // симптомыLabel
            // 
            симптомыLabel.AutoSize = true;
            симптомыLabel.Location = new System.Drawing.Point(360, 191);
            симптомыLabel.Name = "симптомыLabel";
            симптомыLabel.Size = new System.Drawing.Size(63, 13);
            симптомыLabel.TabIndex = 6;
            симптомыLabel.Text = "симптомы:";
            // 
            // симптомыTextBox
            // 
            this.симптомыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "симптомы", true));
            this.симптомыTextBox.Location = new System.Drawing.Point(429, 188);
            this.симптомыTextBox.Name = "симптомыTextBox";
            this.симптомыTextBox.Size = new System.Drawing.Size(100, 20);
            this.симптомыTextBox.TabIndex = 7;
            // 
            // продолжительностьLabel
            // 
            продолжительностьLabel.AutoSize = true;
            продолжительностьLabel.Location = new System.Drawing.Point(311, 230);
            продолжительностьLabel.Name = "продолжительностьLabel";
            продолжительностьLabel.Size = new System.Drawing.Size(112, 13);
            продолжительностьLabel.TabIndex = 8;
            продолжительностьLabel.Text = "продолжительность:";
            // 
            // продолжительностьTextBox
            // 
            this.продолжительностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "продолжительность", true));
            this.продолжительностьTextBox.Location = new System.Drawing.Point(429, 227);
            this.продолжительностьTextBox.Name = "продолжительностьTextBox";
            this.продолжительностьTextBox.Size = new System.Drawing.Size(100, 20);
            this.продолжительностьTextBox.TabIndex = 9;
            // 
            // последствияLabel
            // 
            последствияLabel.AutoSize = true;
            последствияLabel.Location = new System.Drawing.Point(348, 270);
            последствияLabel.Name = "последствияLabel";
            последствияLabel.Size = new System.Drawing.Size(75, 13);
            последствияLabel.TabIndex = 10;
            последствияLabel.Text = "последствия:";
            // 
            // последствияTextBox
            // 
            this.последствияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "последствия", true));
            this.последствияTextBox.Location = new System.Drawing.Point(429, 267);
            this.последствияTextBox.Name = "последствияTextBox";
            this.последствияTextBox.Size = new System.Drawing.Size(100, 20);
            this.последствияTextBox.TabIndex = 11;
            // 
            // код_лекарства_1Label
            // 
            код_лекарства_1Label.AutoSize = true;
            код_лекарства_1Label.Location = new System.Drawing.Point(330, 307);
            код_лекарства_1Label.Name = "код_лекарства_1Label";
            код_лекарства_1Label.Size = new System.Drawing.Size(93, 13);
            код_лекарства_1Label.TabIndex = 12;
            код_лекарства_1Label.Text = "код лекарства 1:";
            // 
            // код_лекарства_1TextBox
            // 
            this.код_лекарства_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "код лекарства 1", true));
            this.код_лекарства_1TextBox.Location = new System.Drawing.Point(429, 304);
            this.код_лекарства_1TextBox.Name = "код_лекарства_1TextBox";
            this.код_лекарства_1TextBox.Size = new System.Drawing.Size(100, 20);
            this.код_лекарства_1TextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(665, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(665, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(665, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(665, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_лекарства_1Label);
            this.Controls.Add(this.код_лекарства_1TextBox);
            this.Controls.Add(последствияLabel);
            this.Controls.Add(this.последствияTextBox);
            this.Controls.Add(продолжительностьLabel);
            this.Controls.Add(this.продолжительностьTextBox);
            this.Controls.Add(симптомыLabel);
            this.Controls.Add(this.симптомыTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_болезниLabel);
            this.Controls.Add(this.код_болезниTextBox);
            this.Controls.Add(this.болезниBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Evmenova______1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingNavigator)).EndInit();
            this.болезниBindingNavigator.ResumeLayout(false);
            this.болезниBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Evmenova______1_DataSet _Evmenova______1_DataSet;
        private System.Windows.Forms.BindingSource болезниBindingSource;
        private _Evmenova______1_DataSetTableAdapters.болезниTableAdapter болезниTableAdapter;
        private _Evmenova______1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator болезниBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton болезниBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_болезниTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox симптомыTextBox;
        private System.Windows.Forms.TextBox продолжительностьTextBox;
        private System.Windows.Forms.TextBox последствияTextBox;
        private System.Windows.Forms.TextBox код_лекарства_1TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}