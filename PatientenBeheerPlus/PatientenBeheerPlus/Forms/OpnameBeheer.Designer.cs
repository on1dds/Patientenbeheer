namespace Patientenbeheer
{
    partial class OpnameBeheer
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
            this.tabInschrijvingen = new System.Windows.Forms.TabControl();
            this.tabOpname = new System.Windows.Forms.TabPage();
            this.grpPatientGegevens = new System.Windows.Forms.GroupBox();
            this.txtPatientDetails = new System.Windows.Forms.TextBox();
            this.picPatientFoto = new System.Windows.Forms.PictureBox();
            this.btnBewerkPatient = new System.Windows.Forms.Button();
            this.gbKiesPatient = new System.Windows.Forms.GroupBox();
            this.btnVerwijderPatient = new System.Windows.Forms.Button();
            this.btnSelecteerPatient = new System.Windows.Forms.Button();
            this.btnNieuwePatient = new System.Windows.Forms.Button();
            this.tabUitschrijven = new System.Windows.Forms.TabPage();
            this.tabInschrijvingen.SuspendLayout();
            this.tabOpname.SuspendLayout();
            this.grpPatientGegevens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientFoto)).BeginInit();
            this.gbKiesPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInschrijvingen
            // 
            this.tabInschrijvingen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInschrijvingen.Controls.Add(this.tabOpname);
            this.tabInschrijvingen.Controls.Add(this.tabUitschrijven);
            this.tabInschrijvingen.Location = new System.Drawing.Point(12, 12);
            this.tabInschrijvingen.Name = "tabInschrijvingen";
            this.tabInschrijvingen.SelectedIndex = 0;
            this.tabInschrijvingen.Size = new System.Drawing.Size(610, 298);
            this.tabInschrijvingen.TabIndex = 11;
            // 
            // tabOpname
            // 
            this.tabOpname.BackColor = System.Drawing.SystemColors.Control;
            this.tabOpname.Controls.Add(this.grpPatientGegevens);
            this.tabOpname.Controls.Add(this.gbKiesPatient);
            this.tabOpname.Location = new System.Drawing.Point(4, 22);
            this.tabOpname.Name = "tabOpname";
            this.tabOpname.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpname.Size = new System.Drawing.Size(602, 272);
            this.tabOpname.TabIndex = 0;
            this.tabOpname.Text = "Inschrijven";
            // 
            // grpPatientGegevens
            // 
            this.grpPatientGegevens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientGegevens.Controls.Add(this.txtPatientDetails);
            this.grpPatientGegevens.Controls.Add(this.picPatientFoto);
            this.grpPatientGegevens.Controls.Add(this.btnBewerkPatient);
            this.grpPatientGegevens.Location = new System.Drawing.Point(129, 17);
            this.grpPatientGegevens.Name = "grpPatientGegevens";
            this.grpPatientGegevens.Size = new System.Drawing.Size(461, 181);
            this.grpPatientGegevens.TabIndex = 44;
            this.grpPatientGegevens.TabStop = false;
            this.grpPatientGegevens.Text = "Details";
            // 
            // txtPatientDetails
            // 
            this.txtPatientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientDetails.Enabled = false;
            this.txtPatientDetails.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientDetails.Location = new System.Drawing.Point(9, 19);
            this.txtPatientDetails.Multiline = true;
            this.txtPatientDetails.Name = "txtPatientDetails";
            this.txtPatientDetails.Size = new System.Drawing.Size(335, 153);
            this.txtPatientDetails.TabIndex = 46;
            // 
            // picPatientFoto
            // 
            this.picPatientFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPatientFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPatientFoto.Location = new System.Drawing.Point(350, 19);
            this.picPatientFoto.Name = "picPatientFoto";
            this.picPatientFoto.Size = new System.Drawing.Size(105, 127);
            this.picPatientFoto.TabIndex = 45;
            this.picPatientFoto.TabStop = false;
            // 
            // btnBewerkPatient
            // 
            this.btnBewerkPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBewerkPatient.Location = new System.Drawing.Point(350, 152);
            this.btnBewerkPatient.Name = "btnBewerkPatient";
            this.btnBewerkPatient.Size = new System.Drawing.Size(105, 23);
            this.btnBewerkPatient.TabIndex = 44;
            this.btnBewerkPatient.Text = "Bewerk ...";
            this.btnBewerkPatient.UseVisualStyleBackColor = true;
            // 
            // gbKiesPatient
            // 
            this.gbKiesPatient.Controls.Add(this.btnVerwijderPatient);
            this.gbKiesPatient.Controls.Add(this.btnSelecteerPatient);
            this.gbKiesPatient.Controls.Add(this.btnNieuwePatient);
            this.gbKiesPatient.Location = new System.Drawing.Point(6, 17);
            this.gbKiesPatient.Name = "gbKiesPatient";
            this.gbKiesPatient.Size = new System.Drawing.Size(117, 181);
            this.gbKiesPatient.TabIndex = 43;
            this.gbKiesPatient.TabStop = false;
            this.gbKiesPatient.Text = "Patient";
            // 
            // btnVerwijderPatient
            // 
            this.btnVerwijderPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijderPatient.Location = new System.Drawing.Point(6, 149);
            this.btnVerwijderPatient.Name = "btnVerwijderPatient";
            this.btnVerwijderPatient.Size = new System.Drawing.Size(105, 23);
            this.btnVerwijderPatient.TabIndex = 45;
            this.btnVerwijderPatient.Text = "Verwijder";
            this.btnVerwijderPatient.UseVisualStyleBackColor = true;
            // 
            // btnSelecteerPatient
            // 
            this.btnSelecteerPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecteerPatient.Location = new System.Drawing.Point(6, 19);
            this.btnSelecteerPatient.Name = "btnSelecteerPatient";
            this.btnSelecteerPatient.Size = new System.Drawing.Size(105, 52);
            this.btnSelecteerPatient.TabIndex = 43;
            this.btnSelecteerPatient.Text = "Selecteer ...";
            this.btnSelecteerPatient.UseVisualStyleBackColor = true;
            this.btnSelecteerPatient.Click += new System.EventHandler(this.btnSelecteerPatient_Click);
            // 
            // btnNieuwePatient
            // 
            this.btnNieuwePatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNieuwePatient.Location = new System.Drawing.Point(6, 77);
            this.btnNieuwePatient.Name = "btnNieuwePatient";
            this.btnNieuwePatient.Size = new System.Drawing.Size(105, 23);
            this.btnNieuwePatient.TabIndex = 42;
            this.btnNieuwePatient.Text = "Nieuw ...";
            this.btnNieuwePatient.UseVisualStyleBackColor = true;
            this.btnNieuwePatient.Click += new System.EventHandler(this.btnNieuwePatient_Click);
            // 
            // tabUitschrijven
            // 
            this.tabUitschrijven.Location = new System.Drawing.Point(4, 22);
            this.tabUitschrijven.Name = "tabUitschrijven";
            this.tabUitschrijven.Size = new System.Drawing.Size(602, 272);
            this.tabUitschrijven.TabIndex = 3;
            this.tabUitschrijven.Text = "Uitschrijven";
            this.tabUitschrijven.UseVisualStyleBackColor = true;
            // 
            // OpnameBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 335);
            this.Controls.Add(this.tabInschrijvingen);
            this.Name = "OpnameBeheer";
            this.Text = "Opnamebeheer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpnameBeheer_FormClosed);
            this.Load += new System.EventHandler(this.frmOpnames_Load);
            this.tabInschrijvingen.ResumeLayout(false);
            this.tabOpname.ResumeLayout(false);
            this.grpPatientGegevens.ResumeLayout(false);
            this.grpPatientGegevens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientFoto)).EndInit();
            this.gbKiesPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInschrijvingen;
        private System.Windows.Forms.TabPage tabOpname;
        private System.Windows.Forms.GroupBox grpPatientGegevens;
        private System.Windows.Forms.TextBox txtPatientDetails;
        private System.Windows.Forms.PictureBox picPatientFoto;
        private System.Windows.Forms.Button btnBewerkPatient;
        private System.Windows.Forms.GroupBox gbKiesPatient;
        private System.Windows.Forms.Button btnVerwijderPatient;
        private System.Windows.Forms.Button btnSelecteerPatient;
        private System.Windows.Forms.Button btnNieuwePatient;
        private System.Windows.Forms.TabPage tabUitschrijven;
    }
}