namespace ServiceBMW
{
    partial class Персонал
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Персонал));
            this.bMWServiceDataSet = new ServiceBMW.BMWServiceDataSet();
            this.персонал_СервисаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персонал_СервисаTableAdapter = new ServiceBMW.BMWServiceDataSetTableAdapters.Персонал_СервисаTableAdapter();
            this.tableAdapterManager = new ServiceBMW.BMWServiceDataSetTableAdapters.TableAdapterManager();
            this.персонал_СервисаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.персонал_СервисаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.персонал_СервисаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bMWServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персонал_СервисаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персонал_СервисаBindingNavigator)).BeginInit();
            this.персонал_СервисаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персонал_СервисаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bMWServiceDataSet
            // 
            this.bMWServiceDataSet.DataSetName = "BMWServiceDataSet";
            this.bMWServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // персонал_СервисаBindingSource
            // 
            this.персонал_СервисаBindingSource.DataMember = "Персонал_Сервиса";
            this.персонал_СервисаBindingSource.DataSource = this.bMWServiceDataSet;
            // 
            // персонал_СервисаTableAdapter
            // 
            this.персонал_СервисаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ServiceBMW.BMWServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ДолжностьTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ОбслуживаниеTableAdapter = null;
            this.tableAdapterManager.Персонал_СервисаTableAdapter = this.персонал_СервисаTableAdapter;
            this.tableAdapterManager.СервисTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.СтажTableAdapter = null;
            // 
            // персонал_СервисаBindingNavigator
            // 
            this.персонал_СервисаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.персонал_СервисаBindingNavigator.BindingSource = this.персонал_СервисаBindingSource;
            this.персонал_СервисаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.персонал_СервисаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.персонал_СервисаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.персонал_СервисаBindingNavigatorSaveItem});
            this.персонал_СервисаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.персонал_СервисаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.персонал_СервисаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.персонал_СервисаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.персонал_СервисаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.персонал_СервисаBindingNavigator.Name = "персонал_СервисаBindingNavigator";
            this.персонал_СервисаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.персонал_СервисаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.персонал_СервисаBindingNavigator.TabIndex = 0;
            this.персонал_СервисаBindingNavigator.Text = "bindingNavigator1";
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
            // персонал_СервисаBindingNavigatorSaveItem
            // 
            this.персонал_СервисаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.персонал_СервисаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("персонал_СервисаBindingNavigatorSaveItem.Image")));
            this.персонал_СервисаBindingNavigatorSaveItem.Name = "персонал_СервисаBindingNavigatorSaveItem";
            this.персонал_СервисаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.персонал_СервисаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.персонал_СервисаBindingNavigatorSaveItem.Click += new System.EventHandler(this.персонал_СервисаBindingNavigatorSaveItem_Click);
            // 
            // персонал_СервисаDataGridView
            // 
            this.персонал_СервисаDataGridView.AutoGenerateColumns = false;
            this.персонал_СервисаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.персонал_СервисаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.персонал_СервисаDataGridView.DataSource = this.персонал_СервисаBindingSource;
            this.персонал_СервисаDataGridView.Location = new System.Drawing.Point(0, 28);
            this.персонал_СервисаDataGridView.Name = "персонал_СервисаDataGridView";
            this.персонал_СервисаDataGridView.Size = new System.Drawing.Size(800, 252);
            this.персонал_СервисаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_Поста";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_Поста";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_Найма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата_Найма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Персонал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.персонал_СервисаDataGridView);
            this.Controls.Add(this.персонал_СервисаBindingNavigator);
            this.Name = "Персонал";
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.Персонал_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bMWServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персонал_СервисаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персонал_СервисаBindingNavigator)).EndInit();
            this.персонал_СервисаBindingNavigator.ResumeLayout(false);
            this.персонал_СервисаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персонал_СервисаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BMWServiceDataSet bMWServiceDataSet;
        private System.Windows.Forms.BindingSource персонал_СервисаBindingSource;
        private BMWServiceDataSetTableAdapters.Персонал_СервисаTableAdapter персонал_СервисаTableAdapter;
        private BMWServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator персонал_СервисаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton персонал_СервисаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView персонал_СервисаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}