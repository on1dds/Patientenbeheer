namespace PatientenBeheerPlus
{
    partial class BewerkAfdelingen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BewerkAfdelingen));
            this.patientenDataSet = new PatientenBeheerPlus.patientenDataSet();
            this.afdelingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afdelingTableAdapter = new PatientenBeheerPlus.patientenDataSetTableAdapters.AfdelingTableAdapter();
            this.tableAdapterManager = new PatientenBeheerPlus.patientenDataSetTableAdapters.TableAdapterManager();
            this.afdelingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.afdelingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.afdelingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingBindingNavigator)).BeginInit();
            this.afdelingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientenDataSet
            // 
            this.patientenDataSet.DataSetName = "patientenDataSet";
            this.patientenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afdelingBindingSource
            // 
            this.afdelingBindingSource.DataMember = "Afdeling";
            this.afdelingBindingSource.DataSource = this.patientenDataSet;
            // 
            // afdelingTableAdapter
            // 
            this.afdelingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AfdelingTableAdapter = this.afdelingTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersoneelTableAdapter = null;
            this.tableAdapterManager.PostcodeTableAdapter = null;
            this.tableAdapterManager.PrestatieSoortTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PatientenBeheerPlus.patientenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // afdelingBindingNavigator
            // 
            this.afdelingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.afdelingBindingNavigator.BindingSource = this.afdelingBindingSource;
            this.afdelingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.afdelingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.afdelingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.afdelingBindingNavigatorSaveItem});
            this.afdelingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.afdelingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.afdelingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.afdelingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.afdelingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.afdelingBindingNavigator.Name = "afdelingBindingNavigator";
            this.afdelingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.afdelingBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.afdelingBindingNavigator.TabIndex = 0;
            this.afdelingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // afdelingBindingNavigatorSaveItem
            // 
            this.afdelingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.afdelingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("afdelingBindingNavigatorSaveItem.Image")));
            this.afdelingBindingNavigatorSaveItem.Name = "afdelingBindingNavigatorSaveItem";
            this.afdelingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.afdelingBindingNavigatorSaveItem.Text = "Save Data";
            this.afdelingBindingNavigatorSaveItem.Click += new System.EventHandler(this.afdelingBindingNavigatorSaveItem_Click);
            // 
            // afdelingDataGridView
            // 
            this.afdelingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.afdelingDataGridView.AutoGenerateColumns = false;
            this.afdelingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afdelingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.afdelingDataGridView.DataSource = this.afdelingBindingSource;
            this.afdelingDataGridView.Location = new System.Drawing.Point(12, 28);
            this.afdelingDataGridView.Name = "afdelingDataGridView";
            this.afdelingDataGridView.Size = new System.Drawing.Size(363, 328);
            this.afdelingDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AfdelingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AfdelingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Afdelingnaam";
            this.dataGridViewTextBoxColumn2.HeaderText = "Afdelingnaam";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmAfdeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 368);
            this.Controls.Add(this.afdelingDataGridView);
            this.Controls.Add(this.afdelingBindingNavigator);
            this.Name = "frmAfdeling";
            this.Text = "frmAfdeling";
            this.Load += new System.EventHandler(this.frmAfdeling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingBindingNavigator)).EndInit();
            this.afdelingBindingNavigator.ResumeLayout(false);
            this.afdelingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private patientenDataSet patientenDataSet;
        private System.Windows.Forms.BindingSource afdelingBindingSource;
        private patientenDataSetTableAdapters.AfdelingTableAdapter afdelingTableAdapter;
        private patientenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator afdelingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton afdelingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView afdelingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}