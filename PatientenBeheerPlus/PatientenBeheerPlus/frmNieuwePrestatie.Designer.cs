namespace PatientenBeheerPlus
{
    partial class frmNieuwePrestatie
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
            this.grpPrestatie = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPrestatieTijdstip = new System.Windows.Forms.DateTimePicker();
            this.btnPrestatieToevoegen = new System.Windows.Forms.Button();
            this.cmbPrestatieNaam = new System.Windows.Forms.ComboBox();
            this.lstPrestatieDetails = new System.Windows.Forms.ListBox();
            this.txtOpmerking = new System.Windows.Forms.TextBox();
            this.grpPrestatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrestatie
            // 
            this.grpPrestatie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPrestatie.Controls.Add(this.label3);
            this.grpPrestatie.Controls.Add(this.label2);
            this.grpPrestatie.Controls.Add(this.dtpPrestatieTijdstip);
            this.grpPrestatie.Controls.Add(this.btnPrestatieToevoegen);
            this.grpPrestatie.Controls.Add(this.cmbPrestatieNaam);
            this.grpPrestatie.Controls.Add(this.lstPrestatieDetails);
            this.grpPrestatie.Controls.Add(this.txtOpmerking);
            this.grpPrestatie.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrestatie.Location = new System.Drawing.Point(12, 12);
            this.grpPrestatie.Name = "grpPrestatie";
            this.grpPrestatie.Size = new System.Drawing.Size(610, 287);
            this.grpPrestatie.TabIndex = 16;
            this.grpPrestatie.TabStop = false;
            this.grpPrestatie.Text = "Nieuwe prestatie op patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mededeling";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tijdstip prestatie";
            // 
            // dtpPrestatieTijdstip
            // 
            this.dtpPrestatieTijdstip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPrestatieTijdstip.Checked = false;
            this.dtpPrestatieTijdstip.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpPrestatieTijdstip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPrestatieTijdstip.Location = new System.Drawing.Point(431, 168);
            this.dtpPrestatieTijdstip.Name = "dtpPrestatieTijdstip";
            this.dtpPrestatieTijdstip.Size = new System.Drawing.Size(173, 22);
            this.dtpPrestatieTijdstip.TabIndex = 16;
            this.dtpPrestatieTijdstip.Leave += new System.EventHandler(this.dtpPrestatieTijdstip_Leave);
            // 
            // btnPrestatieToevoegen
            // 
            this.btnPrestatieToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrestatieToevoegen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrestatieToevoegen.Location = new System.Drawing.Point(431, 248);
            this.btnPrestatieToevoegen.Name = "btnPrestatieToevoegen";
            this.btnPrestatieToevoegen.Size = new System.Drawing.Size(173, 33);
            this.btnPrestatieToevoegen.TabIndex = 15;
            this.btnPrestatieToevoegen.Text = "Prestatie Toevoegen";
            this.btnPrestatieToevoegen.UseVisualStyleBackColor = true;
            this.btnPrestatieToevoegen.Click += new System.EventHandler(this.btnPrestatieToevoegen_Click_1);
            // 
            // cmbPrestatieNaam
            // 
            this.cmbPrestatieNaam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrestatieNaam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrestatieNaam.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrestatieNaam.FormattingEnabled = true;
            this.cmbPrestatieNaam.Location = new System.Drawing.Point(6, 19);
            this.cmbPrestatieNaam.Name = "cmbPrestatieNaam";
            this.cmbPrestatieNaam.Size = new System.Drawing.Size(598, 24);
            this.cmbPrestatieNaam.TabIndex = 13;
            this.cmbPrestatieNaam.SelectedIndexChanged += new System.EventHandler(this.cmbPrestatieNaam_SelectedIndexChanged_1);
            // 
            // lstPrestatieDetails
            // 
            this.lstPrestatieDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPrestatieDetails.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrestatieDetails.FormattingEnabled = true;
            this.lstPrestatieDetails.ItemHeight = 15;
            this.lstPrestatieDetails.Location = new System.Drawing.Point(6, 49);
            this.lstPrestatieDetails.Name = "lstPrestatieDetails";
            this.lstPrestatieDetails.Size = new System.Drawing.Size(598, 94);
            this.lstPrestatieDetails.TabIndex = 14;
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpmerking.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpmerking.Location = new System.Drawing.Point(6, 170);
            this.txtOpmerking.Multiline = true;
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(419, 112);
            this.txtOpmerking.TabIndex = 8;
            // 
            // frmNieuwePrestatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.grpPrestatie);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "frmNieuwePrestatie";
            this.Text = "frmNieuwePrestatie";
            this.Load += new System.EventHandler(this.frmNieuwePrestatie_Load);
            this.grpPrestatie.ResumeLayout(false);
            this.grpPrestatie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrestatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPrestatieTijdstip;
        private System.Windows.Forms.Button btnPrestatieToevoegen;
        private System.Windows.Forms.ComboBox cmbPrestatieNaam;
        private System.Windows.Forms.ListBox lstPrestatieDetails;
        private System.Windows.Forms.TextBox txtOpmerking;
    }
}