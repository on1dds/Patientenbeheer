namespace PatientenBeheerPlus
{
    partial class frmPrestaties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestaties));
            this.cmbPersoneel = new System.Windows.Forms.ComboBox();
            this.cmbPatienten = new System.Windows.Forms.ComboBox();
            this.cmbAfdeling = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPrestatiedatum = new System.Windows.Forms.DateTimePicker();
            this.lstPrestaties = new System.Windows.Forms.ListBox();
            this.cmbOpnames = new System.Windows.Forms.ComboBox();
            this.chkAlleOpnames = new System.Windows.Forms.CheckBox();
            this.chkAlleAfdelingen = new System.Windows.Forms.CheckBox();
            this.btnPrestatieVerwijderen = new System.Windows.Forms.Button();
            this.txtPrestatieView = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNieuwePrestatie = new System.Windows.Forms.Button();
            this.chkNegeerPrestatieStatus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnMaakPrestatieRapport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveTextRapport = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPersoneel
            // 
            this.cmbPersoneel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPersoneel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersoneel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersoneel.FormattingEnabled = true;
            this.cmbPersoneel.Location = new System.Drawing.Point(160, 21);
            this.cmbPersoneel.Name = "cmbPersoneel";
            this.cmbPersoneel.Size = new System.Drawing.Size(440, 24);
            this.cmbPersoneel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbPersoneel, "Selecteer de zorgverstrekker voor de prestatie");
            // 
            // cmbPatienten
            // 
            this.cmbPatienten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPatienten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatienten.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatienten.FormattingEnabled = true;
            this.cmbPatienten.Location = new System.Drawing.Point(160, 75);
            this.cmbPatienten.Name = "cmbPatienten";
            this.cmbPatienten.Size = new System.Drawing.Size(440, 24);
            this.cmbPatienten.TabIndex = 1;
            this.cmbPatienten.SelectedIndexChanged += new System.EventHandler(this.OpnameVeld_Gewijzigd);
            // 
            // cmbAfdeling
            // 
            this.cmbAfdeling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAfdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfdeling.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAfdeling.FormattingEnabled = true;
            this.cmbAfdeling.Location = new System.Drawing.Point(160, 48);
            this.cmbAfdeling.Name = "cmbAfdeling";
            this.cmbAfdeling.Size = new System.Drawing.Size(440, 24);
            this.cmbAfdeling.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbAfdeling, "Selecteer de afdeling waar de prestatie plaats vindt");
            this.cmbAfdeling.SelectedIndexChanged += new System.EventHandler(this.cmbAfdeling_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zorgverstrekker";
            // 
            // dtpPrestatiedatum
            // 
            this.dtpPrestatiedatum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrestatiedatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrestatiedatum.Location = new System.Drawing.Point(10, 21);
            this.dtpPrestatiedatum.Name = "dtpPrestatiedatum";
            this.dtpPrestatiedatum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpPrestatiedatum.ShowCheckBox = true;
            this.dtpPrestatiedatum.Size = new System.Drawing.Size(144, 22);
            this.dtpPrestatiedatum.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dtpPrestatiedatum, "Toon indien aangevinkt enkel\r\nde prestaties op de aangegeven dag");
            this.dtpPrestatiedatum.ValueChanged += new System.EventHandler(this.PrestatieVeld_Gewijzigd);
            // 
            // lstPrestaties
            // 
            this.lstPrestaties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPrestaties.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrestaties.FormattingEnabled = true;
            this.lstPrestaties.ItemHeight = 16;
            this.lstPrestaties.Location = new System.Drawing.Point(7, 49);
            this.lstPrestaties.Name = "lstPrestaties";
            this.lstPrestaties.Size = new System.Drawing.Size(311, 196);
            this.lstPrestaties.TabIndex = 9;
            this.lstPrestaties.SelectedIndexChanged += new System.EventHandler(this.lstPrestaties_SelectedIndexChanged);
            // 
            // cmbOpnames
            // 
            this.cmbOpnames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpnames.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOpnames.FormattingEnabled = true;
            this.cmbOpnames.Location = new System.Drawing.Point(160, 103);
            this.cmbOpnames.Name = "cmbOpnames";
            this.cmbOpnames.Size = new System.Drawing.Size(440, 24);
            this.cmbOpnames.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmbOpnames, "Selecteer de opname waarop de prestatie van toepassing is");
            this.cmbOpnames.SelectedIndexChanged += new System.EventHandler(this.PrestatieVeld_Gewijzigd);
            // 
            // chkAlleOpnames
            // 
            this.chkAlleOpnames.AutoSize = true;
            this.chkAlleOpnames.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlleOpnames.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlleOpnames.Location = new System.Drawing.Point(31, 105);
            this.chkAlleOpnames.Name = "chkAlleOpnames";
            this.chkAlleOpnames.Size = new System.Drawing.Size(123, 20);
            this.chkAlleOpnames.TabIndex = 11;
            this.chkAlleOpnames.Text = "Alle Opnames";
            this.toolTip1.SetToolTip(this.chkAlleOpnames, "Indien aangevinkt:\r\ntoon alle opnames van deze patient");
            this.chkAlleOpnames.UseVisualStyleBackColor = true;
            this.chkAlleOpnames.CheckedChanged += new System.EventHandler(this.OpnameVeld_Gewijzigd);
            // 
            // chkAlleAfdelingen
            // 
            this.chkAlleAfdelingen.AutoSize = true;
            this.chkAlleAfdelingen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlleAfdelingen.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlleAfdelingen.Location = new System.Drawing.Point(7, 50);
            this.chkAlleAfdelingen.Name = "chkAlleAfdelingen";
            this.chkAlleAfdelingen.Size = new System.Drawing.Size(147, 20);
            this.chkAlleAfdelingen.TabIndex = 12;
            this.chkAlleAfdelingen.Text = "Alle Afdelingen";
            this.toolTip1.SetToolTip(this.chkAlleAfdelingen, "Toon indien aangevinkt patienten\r\nvan alle afdelingen");
            this.chkAlleAfdelingen.UseVisualStyleBackColor = true;
            this.chkAlleAfdelingen.CheckedChanged += new System.EventHandler(this.PatientenVeld_Gewijzigd);
            // 
            // btnPrestatieVerwijderen
            // 
            this.btnPrestatieVerwijderen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrestatieVerwijderen.Location = new System.Drawing.Point(221, 250);
            this.btnPrestatieVerwijderen.Name = "btnPrestatieVerwijderen";
            this.btnPrestatieVerwijderen.Size = new System.Drawing.Size(96, 28);
            this.btnPrestatieVerwijderen.TabIndex = 18;
            this.btnPrestatieVerwijderen.Text = "Verwijder";
            this.toolTip1.SetToolTip(this.btnPrestatieVerwijderen, "Verwijdert de prestatie uit de database\r\nNormaal heb je daar verhoogde rechten\r\nv" +
        "oor nodig.");
            this.btnPrestatieVerwijderen.UseVisualStyleBackColor = true;
            this.btnPrestatieVerwijderen.Click += new System.EventHandler(this.btnPrestatieVerwijderen_Click);
            // 
            // txtPrestatieView
            // 
            this.txtPrestatieView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrestatieView.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrestatieView.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestatieView.Location = new System.Drawing.Point(324, 21);
            this.txtPrestatieView.Multiline = true;
            this.txtPrestatieView.Name = "txtPrestatieView";
            this.txtPrestatieView.Size = new System.Drawing.Size(489, 257);
            this.txtPrestatieView.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNieuwePrestatie);
            this.groupBox1.Controls.Add(this.chkNegeerPrestatieStatus);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtpPrestatiedatum);
            this.groupBox1.Controls.Add(this.txtPrestatieView);
            this.groupBox1.Controls.Add(this.lstPrestaties);
            this.groupBox1.Controls.Add(this.btnPrestatieVerwijderen);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 287);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestaties uitgevoerd op patient";
            // 
            // btnNieuwePrestatie
            // 
            this.btnNieuwePrestatie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNieuwePrestatie.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuwePrestatie.Location = new System.Drawing.Point(7, 250);
            this.btnNieuwePrestatie.Name = "btnNieuwePrestatie";
            this.btnNieuwePrestatie.Size = new System.Drawing.Size(96, 28);
            this.btnNieuwePrestatie.TabIndex = 22;
            this.btnNieuwePrestatie.Text = "Nieuw";
            this.toolTip1.SetToolTip(this.btnNieuwePrestatie, "Maak nieuwe prestatie ...");
            this.btnNieuwePrestatie.UseVisualStyleBackColor = true;
            this.btnNieuwePrestatie.Click += new System.EventHandler(this.btnNieuwePrestatie_Click);
            // 
            // chkNegeerPrestatieStatus
            // 
            this.chkNegeerPrestatieStatus.AutoSize = true;
            this.chkNegeerPrestatieStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNegeerPrestatieStatus.Location = new System.Drawing.Point(160, 23);
            this.chkNegeerPrestatieStatus.Name = "chkNegeerPrestatieStatus";
            this.chkNegeerPrestatieStatus.Size = new System.Drawing.Size(131, 20);
            this.chkNegeerPrestatieStatus.TabIndex = 13;
            this.chkNegeerPrestatieStatus.Text = "Negeer Status";
            this.chkNegeerPrestatieStatus.UseVisualStyleBackColor = true;
            this.chkNegeerPrestatieStatus.CheckedChanged += new System.EventHandler(this.PrestatieVeld_Gewijzigd);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(114, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sluit";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSluitPrestatie_Click);
            // 
            // grpFilters
            // 
            this.grpFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilters.Controls.Add(this.cmbPersoneel);
            this.grpFilters.Controls.Add(this.cmbPatienten);
            this.grpFilters.Controls.Add(this.cmbAfdeling);
            this.grpFilters.Controls.Add(this.chkAlleAfdelingen);
            this.grpFilters.Controls.Add(this.chkAlleOpnames);
            this.grpFilters.Controls.Add(this.label1);
            this.grpFilters.Controls.Add(this.cmbOpnames);
            this.grpFilters.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilters.Location = new System.Drawing.Point(12, 12);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(606, 137);
            this.grpFilters.TabIndex = 20;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";
            // 
            // btnMaakPrestatieRapport
            // 
            this.btnMaakPrestatieRapport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaakPrestatieRapport.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaakPrestatieRapport.Location = new System.Drawing.Point(6, 21);
            this.btnMaakPrestatieRapport.Name = "btnMaakPrestatieRapport";
            this.btnMaakPrestatieRapport.Size = new System.Drawing.Size(195, 33);
            this.btnMaakPrestatieRapport.TabIndex = 19;
            this.btnMaakPrestatieRapport.Text = "Prestatierapport";
            this.btnMaakPrestatieRapport.UseVisualStyleBackColor = true;
            this.btnMaakPrestatieRapport.Click += new System.EventHandler(this.btnMaakPrestatieRapport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnMaakPrestatieRapport);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(624, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 137);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genereer";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Prestaties naar tekst";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPrestatiesNaarTekst_Click);
            // 
            // frmPrestaties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrestaties";
            this.Text = "Invoer Prestaties";
            this.Load += new System.EventHandler(this.frmPrestaties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersoneel;
        private System.Windows.Forms.ComboBox cmbPatienten;
        private System.Windows.Forms.ComboBox cmbAfdeling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPrestatiedatum;
        private System.Windows.Forms.ListBox lstPrestaties;
        private System.Windows.Forms.ComboBox cmbOpnames;
        private System.Windows.Forms.CheckBox chkAlleOpnames;
        private System.Windows.Forms.CheckBox chkAlleAfdelingen;
        private System.Windows.Forms.Button btnPrestatieVerwijderen;
        private System.Windows.Forms.TextBox txtPrestatieView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Button btnMaakPrestatieRapport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNieuwePrestatie;
        private System.Windows.Forms.CheckBox chkNegeerPrestatieStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveTextRapport;
    }
}