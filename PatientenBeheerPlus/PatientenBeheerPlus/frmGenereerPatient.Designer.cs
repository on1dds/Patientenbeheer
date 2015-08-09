namespace PatientenBeheerPlus
{
    partial class frmGenereerPatient
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPatienten = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOpnames = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPrestaties = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenereer = new System.Windows.Forms.Button();
            this.txtPatientinfo = new System.Windows.Forms.TextBox();
            this.lstOpnames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPrestaties = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstPatienten = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPatienten,
            this.lblOpnames,
            this.lblPrestaties});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(417, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPatienten
            // 
            this.lblPatienten.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblPatienten.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblPatienten.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatienten.Name = "lblPatienten";
            this.lblPatienten.Size = new System.Drawing.Size(116, 20);
            this.lblPatienten.Text = "--- Patienten";
            // 
            // lblOpnames
            // 
            this.lblOpnames.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblOpnames.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblOpnames.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpnames.Name = "lblOpnames";
            this.lblOpnames.Size = new System.Drawing.Size(100, 20);
            this.lblOpnames.Text = "--- Opnames";
            // 
            // lblPrestaties
            // 
            this.lblPrestaties.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblPrestaties.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblPrestaties.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestaties.Name = "lblPrestaties";
            this.lblPrestaties.Size = new System.Drawing.Size(132, 20);
            this.lblPrestaties.Text = "---- Prestaties";
            // 
            // btnGenereer
            // 
            this.btnGenereer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenereer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenereer.Location = new System.Drawing.Point(12, 12);
            this.btnGenereer.Name = "btnGenereer";
            this.btnGenereer.Size = new System.Drawing.Size(393, 32);
            this.btnGenereer.TabIndex = 1;
            this.btnGenereer.Text = "Genereer Patient";
            this.btnGenereer.UseVisualStyleBackColor = true;
            this.btnGenereer.Click += new System.EventHandler(this.btnGenereer_Click);
            // 
            // txtPatientinfo
            // 
            this.txtPatientinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientinfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPatientinfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientinfo.Location = new System.Drawing.Point(6, 141);
            this.txtPatientinfo.Multiline = true;
            this.txtPatientinfo.Name = "txtPatientinfo";
            this.txtPatientinfo.ReadOnly = true;
            this.txtPatientinfo.Size = new System.Drawing.Size(381, 73);
            this.txtPatientinfo.TabIndex = 2;
            // 
            // lstOpnames
            // 
            this.lstOpnames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOpnames.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOpnames.FormattingEnabled = true;
            this.lstOpnames.ItemHeight = 16;
            this.lstOpnames.Location = new System.Drawing.Point(6, 19);
            this.lstOpnames.Name = "lstOpnames";
            this.lstOpnames.Size = new System.Drawing.Size(381, 116);
            this.lstOpnames.TabIndex = 3;
            this.lstOpnames.SelectedIndexChanged += new System.EventHandler(this.lstOpnames_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstOpnames);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opnames";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstPrestaties);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestaties";
            // 
            // lstPrestaties
            // 
            this.lstPrestaties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPrestaties.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrestaties.FormattingEnabled = true;
            this.lstPrestaties.ItemHeight = 16;
            this.lstPrestaties.Location = new System.Drawing.Point(6, 19);
            this.lstPrestaties.Name = "lstPrestaties";
            this.lstPrestaties.Size = new System.Drawing.Size(381, 132);
            this.lstPrestaties.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lstPatienten);
            this.groupBox3.Controls.Add(this.txtPatientinfo);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 220);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patienten";
            // 
            // lstPatienten
            // 
            this.lstPatienten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPatienten.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPatienten.FormattingEnabled = true;
            this.lstPatienten.ItemHeight = 16;
            this.lstPatienten.Location = new System.Drawing.Point(6, 19);
            this.lstPatienten.Name = "lstPatienten";
            this.lstPatienten.Size = new System.Drawing.Size(381, 84);
            this.lstPatienten.TabIndex = 3;
            this.lstPatienten.SelectedIndexChanged += new System.EventHandler(this.lstPatienten_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verwijder Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGenereerPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenereer);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmGenereerPatient";
            this.Text = "frmGenereerPatient";
            this.Load += new System.EventHandler(this.frmGenereerPatient_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPatienten;
        private System.Windows.Forms.ToolStripStatusLabel lblOpnames;
        private System.Windows.Forms.ToolStripStatusLabel lblPrestaties;
        private System.Windows.Forms.Button btnGenereer;
        private System.Windows.Forms.TextBox txtPatientinfo;
        private System.Windows.Forms.ListBox lstOpnames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstPrestaties;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstPatienten;
        private System.Windows.Forms.Button button1;
    }
}