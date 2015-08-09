namespace PatientenBeheerPlus
{
    partial class frmOpnamebeheer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPatientDetail = new System.Windows.Forms.TextBox();
            this.lvLijstPatienten = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVoornaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAchternaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGemeente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGeboortedatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefoon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkZoeken = new System.Windows.Forms.CheckBox();
            this.btnGenereerPatient = new System.Windows.Forms.Button();
            this.btnVerwijderPatient = new System.Windows.Forms.Button();
            this.btnNieuwePatient = new System.Windows.Forms.Button();
            this.btnVorigeOpname = new System.Windows.Forms.Button();
            this.btnVolgendeOpname = new System.Windows.Forms.Button();
            this.picOpnames = new System.Windows.Forms.PictureBox();
            this.txtZoekPatient = new System.Windows.Forms.TextBox();
            this.btnGenereerOpname = new System.Windows.Forms.Button();
            this.grpOpnameDetails = new System.Windows.Forms.GroupBox();
            this.mtbTotTijd = new System.Windows.Forms.MaskedTextBox();
            this.mtbVanTijd = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAfdeling = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOpnameVan = new System.Windows.Forms.DateTimePicker();
            this.dtpOpnameTot = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderOpname = new System.Windows.Forms.Button();
            this.btnNieuweOpname = new System.Windows.Forms.Button();
            this.chkVoorOntslag = new System.Windows.Forms.CheckBox();
            this.btnOpnameOpslaan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpnames)).BeginInit();
            this.grpOpnameDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPatientDetail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patiënt details";
            // 
            // txtPatientDetail
            // 
            this.txtPatientDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientDetail.Enabled = false;
            this.txtPatientDetail.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientDetail.Location = new System.Drawing.Point(6, 19);
            this.txtPatientDetail.Multiline = true;
            this.txtPatientDetail.Name = "txtPatientDetail";
            this.txtPatientDetail.Size = new System.Drawing.Size(778, 83);
            this.txtPatientDetail.TabIndex = 45;
            this.txtPatientDetail.UseWaitCursor = true;
            // 
            // lvLijstPatienten
            // 
            this.lvLijstPatienten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLijstPatienten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colVoornaam,
            this.colAchternaam,
            this.colAdres,
            this.colGemeente,
            this.colGeboortedatum,
            this.colTelefoon});
            this.lvLijstPatienten.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLijstPatienten.FullRowSelect = true;
            this.lvLijstPatienten.Location = new System.Drawing.Point(12, 343);
            this.lvLijstPatienten.MultiSelect = false;
            this.lvLijstPatienten.Name = "lvLijstPatienten";
            this.lvLijstPatienten.Size = new System.Drawing.Size(790, 222);
            this.lvLijstPatienten.TabIndex = 47;
            this.lvLijstPatienten.UseCompatibleStateImageBehavior = false;
            this.lvLijstPatienten.View = System.Windows.Forms.View.Details;
            this.lvLijstPatienten.SelectedIndexChanged += new System.EventHandler(this.lvLijstPatienten_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 45;
            // 
            // colVoornaam
            // 
            this.colVoornaam.Text = "Voornaam";
            this.colVoornaam.Width = 111;
            // 
            // colAchternaam
            // 
            this.colAchternaam.Text = "Achternaam";
            this.colAchternaam.Width = 149;
            // 
            // colAdres
            // 
            this.colAdres.Text = "Straat + nr";
            this.colAdres.Width = 241;
            // 
            // colGemeente
            // 
            this.colGemeente.Text = "Gemeente";
            this.colGemeente.Width = 136;
            // 
            // colGeboortedatum
            // 
            this.colGeboortedatum.Text = "Geboortedatum";
            this.colGeboortedatum.Width = 111;
            // 
            // colTelefoon
            // 
            this.colTelefoon.Text = "Telefoon";
            // 
            // chkZoeken
            // 
            this.chkZoeken.AutoSize = true;
            this.chkZoeken.Checked = true;
            this.chkZoeken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZoeken.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZoeken.Location = new System.Drawing.Point(12, 312);
            this.chkZoeken.Name = "chkZoeken";
            this.chkZoeken.Size = new System.Drawing.Size(123, 20);
            this.chkZoeken.TabIndex = 52;
            this.chkZoeken.Text = "Zoek patient";
            this.chkZoeken.UseVisualStyleBackColor = true;
            this.chkZoeken.CheckedChanged += new System.EventHandler(this.chkZoekPatient_CheckedChanged);
            // 
            // btnGenereerPatient
            // 
            this.btnGenereerPatient.Location = new System.Drawing.Point(690, 571);
            this.btnGenereerPatient.Name = "btnGenereerPatient";
            this.btnGenereerPatient.Size = new System.Drawing.Size(112, 28);
            this.btnGenereerPatient.TabIndex = 53;
            this.btnGenereerPatient.Text = "Genereer Patient";
            this.btnGenereerPatient.UseVisualStyleBackColor = true;
            this.btnGenereerPatient.Click += new System.EventHandler(this.btnGenereerPatient_Click);
            // 
            // btnVerwijderPatient
            // 
            this.btnVerwijderPatient.Location = new System.Drawing.Point(572, 571);
            this.btnVerwijderPatient.Name = "btnVerwijderPatient";
            this.btnVerwijderPatient.Size = new System.Drawing.Size(112, 28);
            this.btnVerwijderPatient.TabIndex = 54;
            this.btnVerwijderPatient.Text = "Verwijder Patient";
            this.btnVerwijderPatient.UseVisualStyleBackColor = true;
            this.btnVerwijderPatient.Click += new System.EventHandler(this.btnVerwijderPatient_Click);
            // 
            // btnNieuwePatient
            // 
            this.btnNieuwePatient.Location = new System.Drawing.Point(12, 571);
            this.btnNieuwePatient.Name = "btnNieuwePatient";
            this.btnNieuwePatient.Size = new System.Drawing.Size(112, 28);
            this.btnNieuwePatient.TabIndex = 55;
            this.btnNieuwePatient.Text = "Nieuwe Patient ...";
            this.btnNieuwePatient.UseVisualStyleBackColor = true;
            this.btnNieuwePatient.Click += new System.EventHandler(this.btnNieuwePatient_Click);
            // 
            // btnVorigeOpname
            // 
            this.btnVorigeOpname.Location = new System.Drawing.Point(12, 126);
            this.btnVorigeOpname.Name = "btnVorigeOpname";
            this.btnVorigeOpname.Size = new System.Drawing.Size(26, 23);
            this.btnVorigeOpname.TabIndex = 57;
            this.btnVorigeOpname.Text = "<";
            this.btnVorigeOpname.UseVisualStyleBackColor = true;
            this.btnVorigeOpname.Click += new System.EventHandler(this.btnVorigeOpname_Click);
            // 
            // btnVolgendeOpname
            // 
            this.btnVolgendeOpname.Location = new System.Drawing.Point(777, 126);
            this.btnVolgendeOpname.Name = "btnVolgendeOpname";
            this.btnVolgendeOpname.Size = new System.Drawing.Size(26, 23);
            this.btnVolgendeOpname.TabIndex = 58;
            this.btnVolgendeOpname.Text = ">";
            this.btnVolgendeOpname.UseVisualStyleBackColor = true;
            this.btnVolgendeOpname.Click += new System.EventHandler(this.btnVolgendeOpname_Click);
            // 
            // picOpnames
            // 
            this.picOpnames.BackColor = System.Drawing.Color.LightGray;
            this.picOpnames.Location = new System.Drawing.Point(37, 127);
            this.picOpnames.Name = "picOpnames";
            this.picOpnames.Size = new System.Drawing.Size(741, 21);
            this.picOpnames.TabIndex = 59;
            this.picOpnames.TabStop = false;
            this.picOpnames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOpnames_MouseClick);
            // 
            // txtZoekPatient
            // 
            this.txtZoekPatient.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoekPatient.Location = new System.Drawing.Point(141, 305);
            this.txtZoekPatient.Name = "txtZoekPatient";
            this.txtZoekPatient.Size = new System.Drawing.Size(532, 31);
            this.txtZoekPatient.TabIndex = 61;
            // 
            // btnGenereerOpname
            // 
            this.btnGenereerOpname.Location = new System.Drawing.Point(690, 154);
            this.btnGenereerOpname.Name = "btnGenereerOpname";
            this.btnGenereerOpname.Size = new System.Drawing.Size(112, 28);
            this.btnGenereerOpname.TabIndex = 62;
            this.btnGenereerOpname.Text = "Genereer Opname";
            this.btnGenereerOpname.UseVisualStyleBackColor = true;
            this.btnGenereerOpname.Click += new System.EventHandler(this.btnGenereerOpname_Click);
            // 
            // grpOpnameDetails
            // 
            this.grpOpnameDetails.Controls.Add(this.mtbTotTijd);
            this.grpOpnameDetails.Controls.Add(this.mtbVanTijd);
            this.grpOpnameDetails.Controls.Add(this.label3);
            this.grpOpnameDetails.Controls.Add(this.cmbAfdeling);
            this.grpOpnameDetails.Controls.Add(this.label2);
            this.grpOpnameDetails.Controls.Add(this.dtpOpnameVan);
            this.grpOpnameDetails.Controls.Add(this.dtpOpnameTot);
            this.grpOpnameDetails.Controls.Add(this.label1);
            this.grpOpnameDetails.Location = new System.Drawing.Point(12, 188);
            this.grpOpnameDetails.Name = "grpOpnameDetails";
            this.grpOpnameDetails.Size = new System.Drawing.Size(362, 106);
            this.grpOpnameDetails.TabIndex = 63;
            this.grpOpnameDetails.TabStop = false;
            this.grpOpnameDetails.Text = "Opname Details";
            // 
            // mtbTotTijd
            // 
            this.mtbTotTijd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTotTijd.Location = new System.Drawing.Point(253, 77);
            this.mtbTotTijd.Mask = "00:00";
            this.mtbTotTijd.Name = "mtbTotTijd";
            this.mtbTotTijd.Size = new System.Drawing.Size(100, 22);
            this.mtbTotTijd.TabIndex = 74;
            this.mtbTotTijd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTotTijd.ValidatingType = typeof(System.DateTime);
            // 
            // mtbVanTijd
            // 
            this.mtbVanTijd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbVanTijd.Location = new System.Drawing.Point(253, 51);
            this.mtbVanTijd.Mask = "00:00";
            this.mtbVanTijd.Name = "mtbVanTijd";
            this.mtbVanTijd.Size = new System.Drawing.Size(100, 22);
            this.mtbVanTijd.TabIndex = 73;
            this.mtbVanTijd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbVanTijd.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Afdeling";
            // 
            // cmbAfdeling
            // 
            this.cmbAfdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfdeling.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAfdeling.FormattingEnabled = true;
            this.cmbAfdeling.Location = new System.Drawing.Point(90, 19);
            this.cmbAfdeling.Name = "cmbAfdeling";
            this.cmbAfdeling.Size = new System.Drawing.Size(263, 24);
            this.cmbAfdeling.TabIndex = 71;
            this.cmbAfdeling.SelectedIndexChanged += new System.EventHandler(this.cmbAfdeling_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tot";
            // 
            // dtpOpnameVan
            // 
            this.dtpOpnameVan.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOpnameVan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpnameVan.Location = new System.Drawing.Point(90, 49);
            this.dtpOpnameVan.Name = "dtpOpnameVan";
            this.dtpOpnameVan.ShowCheckBox = true;
            this.dtpOpnameVan.Size = new System.Drawing.Size(152, 22);
            this.dtpOpnameVan.TabIndex = 67;
            this.dtpOpnameVan.ValueChanged += new System.EventHandler(this.dtpOpnameVan_ValueChanged);
            // 
            // dtpOpnameTot
            // 
            this.dtpOpnameTot.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOpnameTot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpnameTot.Location = new System.Drawing.Point(90, 77);
            this.dtpOpnameTot.Name = "dtpOpnameTot";
            this.dtpOpnameTot.ShowCheckBox = true;
            this.dtpOpnameTot.Size = new System.Drawing.Size(152, 22);
            this.dtpOpnameTot.TabIndex = 69;
            this.dtpOpnameTot.ValueChanged += new System.EventHandler(this.dtpOpnameTot_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Van";
            // 
            // btnVerwijderOpname
            // 
            this.btnVerwijderOpname.Location = new System.Drawing.Point(572, 154);
            this.btnVerwijderOpname.Name = "btnVerwijderOpname";
            this.btnVerwijderOpname.Size = new System.Drawing.Size(112, 28);
            this.btnVerwijderOpname.TabIndex = 66;
            this.btnVerwijderOpname.Text = "Verwijder Opname";
            this.btnVerwijderOpname.UseVisualStyleBackColor = true;
            this.btnVerwijderOpname.Click += new System.EventHandler(this.btnVerwijderOpname_Click);
            // 
            // btnNieuweOpname
            // 
            this.btnNieuweOpname.Location = new System.Drawing.Point(12, 154);
            this.btnNieuweOpname.Name = "btnNieuweOpname";
            this.btnNieuweOpname.Size = new System.Drawing.Size(112, 28);
            this.btnNieuweOpname.TabIndex = 71;
            this.btnNieuweOpname.Text = "Nieuwe Opname";
            this.btnNieuweOpname.UseVisualStyleBackColor = true;
            this.btnNieuweOpname.Click += new System.EventHandler(this.btnNieuweOpname_Click);
            // 
            // chkVoorOntslag
            // 
            this.chkVoorOntslag.AutoSize = true;
            this.chkVoorOntslag.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVoorOntslag.Location = new System.Drawing.Point(679, 312);
            this.chkVoorOntslag.Name = "chkVoorOntslag";
            this.chkVoorOntslag.Size = new System.Drawing.Size(123, 20);
            this.chkVoorOntslag.TabIndex = 72;
            this.chkVoorOntslag.Text = "Voor ontslag";
            this.chkVoorOntslag.UseVisualStyleBackColor = true;
            this.chkVoorOntslag.CheckedChanged += new System.EventHandler(this.chkVoorOntslag_CheckedChanged);
            // 
            // btnOpnameOpslaan
            // 
            this.btnOpnameOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpnameOpslaan.ForeColor = System.Drawing.Color.Black;
            this.btnOpnameOpslaan.Location = new System.Drawing.Point(130, 154);
            this.btnOpnameOpslaan.Name = "btnOpnameOpslaan";
            this.btnOpnameOpslaan.Size = new System.Drawing.Size(143, 28);
            this.btnOpnameOpslaan.TabIndex = 73;
            this.btnOpnameOpslaan.Text = "Opname Opslaan";
            this.btnOpnameOpslaan.UseVisualStyleBackColor = true;
            this.btnOpnameOpslaan.Click += new System.EventHandler(this.btnPatientUitschrijven_Click);
            // 
            // frmOpnamebeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 610);
            this.Controls.Add(this.btnOpnameOpslaan);
            this.Controls.Add(this.chkVoorOntslag);
            this.Controls.Add(this.btnNieuweOpname);
            this.Controls.Add(this.btnVerwijderOpname);
            this.Controls.Add(this.grpOpnameDetails);
            this.Controls.Add(this.btnGenereerOpname);
            this.Controls.Add(this.txtZoekPatient);
            this.Controls.Add(this.picOpnames);
            this.Controls.Add(this.btnVolgendeOpname);
            this.Controls.Add(this.btnVorigeOpname);
            this.Controls.Add(this.btnNieuwePatient);
            this.Controls.Add(this.btnVerwijderPatient);
            this.Controls.Add(this.btnGenereerPatient);
            this.Controls.Add(this.chkZoeken);
            this.Controls.Add(this.lvLijstPatienten);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOpnamebeheer";
            this.Text = "Opnamebeheer";
            this.Load += new System.EventHandler(this.frmOpnamebeheer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpnames)).EndInit();
            this.grpOpnameDetails.ResumeLayout(false);
            this.grpOpnameDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPatientDetail;
        private System.Windows.Forms.ListView lvLijstPatienten;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colVoornaam;
        private System.Windows.Forms.ColumnHeader colAchternaam;
        private System.Windows.Forms.ColumnHeader colAdres;
        private System.Windows.Forms.ColumnHeader colGemeente;
        private System.Windows.Forms.ColumnHeader colGeboortedatum;
        private System.Windows.Forms.CheckBox chkZoeken;
        private System.Windows.Forms.Button btnGenereerPatient;
        private System.Windows.Forms.Button btnVerwijderPatient;
        private System.Windows.Forms.ColumnHeader colTelefoon;
        private System.Windows.Forms.Button btnNieuwePatient;
        private System.Windows.Forms.Button btnVorigeOpname;
        private System.Windows.Forms.Button btnVolgendeOpname;
        private System.Windows.Forms.PictureBox picOpnames;
        private System.Windows.Forms.TextBox txtZoekPatient;
        private System.Windows.Forms.Button btnGenereerOpname;
        private System.Windows.Forms.GroupBox grpOpnameDetails;
        private System.Windows.Forms.Button btnVerwijderOpname;
        private System.Windows.Forms.DateTimePicker dtpOpnameVan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOpnameTot;
        private System.Windows.Forms.Button btnNieuweOpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAfdeling;
        private System.Windows.Forms.MaskedTextBox mtbTotTijd;
        private System.Windows.Forms.MaskedTextBox mtbVanTijd;
        private System.Windows.Forms.CheckBox chkVoorOntslag;
        private System.Windows.Forms.Button btnOpnameOpslaan;
    }
}