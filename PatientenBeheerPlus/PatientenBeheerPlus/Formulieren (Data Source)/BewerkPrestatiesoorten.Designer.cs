﻿namespace PatientenBeheerPlus
{
    partial class BewerkPrestatiesoorten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BewerkPrestatiesoorten));
            this.patientenDataSet = new PatientenBeheerPlus.patientenDataSet();
            this.prestatieSoortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.prestatieSoortTableAdapter = new PatientenBeheerPlus.patientenDataSetTableAdapters.PrestatieSoortTableAdapter();
            this.tableAdapterManager = new PatientenBeheerPlus.patientenDataSetTableAdapters.TableAdapterManager();
            this.prestatieSoortBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prestatieSoortBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prestatieSoortDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestatieSoortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestatieSoortBindingNavigator)).BeginInit();
            this.prestatieSoortBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestatieSoortDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientenDataSet
            // 
            this.patientenDataSet.DataSetName = "patientenDataSet";
            this.patientenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestatieSoortBindingSource
            // 
            this.prestatieSoortBindingSource.DataMember = "PrestatieSoort";
            this.prestatieSoortBindingSource.DataSource = this.patientenDataSet;
            // 
            // prestatieSoortTableAdapter
            // 
            this.prestatieSoortTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AfdelingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersoneelTableAdapter = null;
            this.tableAdapterManager.PostcodeTableAdapter = null;
            this.tableAdapterManager.PrestatieSoortTableAdapter = this.prestatieSoortTableAdapter;
            this.tableAdapterManager.UpdateOrder = PatientenBeheerPlus.patientenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prestatieSoortBindingNavigator
            // 
            this.prestatieSoortBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prestatieSoortBindingNavigator.BindingSource = this.prestatieSoortBindingSource;
            this.prestatieSoortBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prestatieSoortBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prestatieSoortBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prestatieSoortBindingNavigatorSaveItem});
            this.prestatieSoortBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prestatieSoortBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prestatieSoortBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prestatieSoortBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prestatieSoortBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prestatieSoortBindingNavigator.Name = "prestatieSoortBindingNavigator";
            this.prestatieSoortBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prestatieSoortBindingNavigator.Size = new System.Drawing.Size(510, 25);
            this.prestatieSoortBindingNavigator.TabIndex = 0;
            this.prestatieSoortBindingNavigator.Text = "bindingNavigator1";
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
            // prestatieSoortBindingNavigatorSaveItem
            // 
            this.prestatieSoortBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prestatieSoortBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prestatieSoortBindingNavigatorSaveItem.Image")));
            this.prestatieSoortBindingNavigatorSaveItem.Name = "prestatieSoortBindingNavigatorSaveItem";
            this.prestatieSoortBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.prestatieSoortBindingNavigatorSaveItem.Text = "Save Data";
            this.prestatieSoortBindingNavigatorSaveItem.Click += new System.EventHandler(this.prestatieSoortBindingNavigatorSaveItem_Click);
            // 
            // prestatieSoortDataGridView
            // 
            this.prestatieSoortDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prestatieSoortDataGridView.AutoGenerateColumns = false;
            this.prestatieSoortDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestatieSoortDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prestatieSoortDataGridView.DataSource = this.prestatieSoortBindingSource;
            this.prestatieSoortDataGridView.Location = new System.Drawing.Point(12, 28);
            this.prestatieSoortDataGridView.Name = "prestatieSoortDataGridView";
            this.prestatieSoortDataGridView.Size = new System.Drawing.Size(486, 236);
            this.prestatieSoortDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PrestatieSoortID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PrestatieSoortID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prestatienummer";
            this.dataGridViewTextBoxColumn2.HeaderText = "prestatienummer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Omschrijving";
            this.dataGridViewTextBoxColumn3.HeaderText = "Omschrijving";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prijs";
            this.dataGridViewTextBoxColumn4.HeaderText = "prijs";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmPrestatieSoort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 276);
            this.Controls.Add(this.prestatieSoortDataGridView);
            this.Controls.Add(this.prestatieSoortBindingNavigator);
            this.Name = "frmPrestatieSoort";
            this.Text = "frmPrestatieSoort";
            this.Load += new System.EventHandler(this.frmPrestatieSoort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestatieSoortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestatieSoortBindingNavigator)).EndInit();
            this.prestatieSoortBindingNavigator.ResumeLayout(false);
            this.prestatieSoortBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestatieSoortDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private patientenDataSet patientenDataSet;
        private System.Windows.Forms.BindingSource prestatieSoortBindingSource;
        private patientenDataSetTableAdapters.PrestatieSoortTableAdapter prestatieSoortTableAdapter;
        private patientenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prestatieSoortBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prestatieSoortBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView prestatieSoortDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}