namespace Patientenbeheer
{
    partial class SelecteerPatient
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
            this.lvResultaat = new System.Windows.Forms.ListView();
            this.trUpdateList = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPatientDetail = new System.Windows.Forms.TextBox();
            this.btnSelecteer = new System.Windows.Forms.Button();
            this.gbKiesPatient = new System.Windows.Forms.GroupBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnBewerkPatient = new System.Windows.Forms.Button();
            this.btnNieuwePatient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZoek = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbKiesPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResultaat
            // 
            this.lvResultaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResultaat.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResultaat.FullRowSelect = true;
            this.lvResultaat.Location = new System.Drawing.Point(10, 188);
            this.lvResultaat.MultiSelect = false;
            this.lvResultaat.Name = "lvResultaat";
            this.lvResultaat.Size = new System.Drawing.Size(722, 259);
            this.lvResultaat.TabIndex = 2;
            this.lvResultaat.UseCompatibleStateImageBehavior = false;
            this.lvResultaat.View = System.Windows.Forms.View.Details;
            this.lvResultaat.SelectedIndexChanged += new System.EventHandler(this.WijzigSelectie);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPatientDetail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 118);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patiënt details";
            // 
            // txtPatientDetail
            // 
            this.txtPatientDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientDetail.Enabled = false;
            this.txtPatientDetail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientDetail.Location = new System.Drawing.Point(6, 19);
            this.txtPatientDetail.Multiline = true;
            this.txtPatientDetail.Name = "txtPatientDetail";
            this.txtPatientDetail.Size = new System.Drawing.Size(520, 91);
            this.txtPatientDetail.TabIndex = 45;
            // 
            // btnSelecteer
            // 
            this.btnSelecteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecteer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelecteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecteer.Location = new System.Drawing.Point(654, 20);
            this.btnSelecteer.Name = "btnSelecteer";
            this.btnSelecteer.Size = new System.Drawing.Size(78, 33);
            this.btnSelecteer.TabIndex = 25;
            this.btnSelecteer.Text = "Selecteer";
            this.btnSelecteer.UseVisualStyleBackColor = true;
            this.btnSelecteer.Click += new System.EventHandler(this.Selecteren);
            // 
            // gbKiesPatient
            // 
            this.gbKiesPatient.Controls.Add(this.btnVerwijder);
            this.gbKiesPatient.Controls.Add(this.btnBewerkPatient);
            this.gbKiesPatient.Controls.Add(this.btnNieuwePatient);
            this.gbKiesPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKiesPatient.Location = new System.Drawing.Point(10, 10);
            this.gbKiesPatient.Name = "gbKiesPatient";
            this.gbKiesPatient.Size = new System.Drawing.Size(100, 120);
            this.gbKiesPatient.TabIndex = 44;
            this.gbKiesPatient.TabStop = false;
            this.gbKiesPatient.Text = "Patient";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijder.Location = new System.Drawing.Point(5, 92);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(90, 20);
            this.btnVerwijder.TabIndex = 45;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.Verwijderen);
            // 
            // btnBewerkPatient
            // 
            this.btnBewerkPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBewerkPatient.Location = new System.Drawing.Point(7, 42);
            this.btnBewerkPatient.Name = "btnBewerkPatient";
            this.btnBewerkPatient.Size = new System.Drawing.Size(88, 20);
            this.btnBewerkPatient.TabIndex = 44;
            this.btnBewerkPatient.Text = "Bewerk ...";
            this.btnBewerkPatient.UseVisualStyleBackColor = true;
            // 
            // btnNieuwePatient
            // 
            this.btnNieuwePatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNieuwePatient.Location = new System.Drawing.Point(5, 16);
            this.btnNieuwePatient.Name = "btnNieuwePatient";
            this.btnNieuwePatient.Size = new System.Drawing.Size(90, 20);
            this.btnNieuwePatient.TabIndex = 42;
            this.btnNieuwePatient.Text = "Nieuw ...";
            this.btnNieuwePatient.UseVisualStyleBackColor = true;
            this.btnNieuwePatient.Click += new System.EventHandler(this.btnNieuwePatient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Zoek";
            // 
            // txtZoek
            // 
            this.txtZoek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZoek.Location = new System.Drawing.Point(48, 162);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(600, 20);
            this.txtZoek.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(654, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 20);
            this.button2.TabIndex = 47;
            this.button2.Text = "Annuleren";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelecteerPatient
            // 
            this.AcceptButton = this.btnSelecteer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbKiesPatient);
            this.Controls.Add(this.btnSelecteer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvResultaat);
            this.Controls.Add(this.txtZoek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecteerPatient";
            this.Text = "Selecteer Patient";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelecteerPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbKiesPatient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResultaat;
        private System.Windows.Forms.Timer trUpdateList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecteer;
        private System.Windows.Forms.GroupBox gbKiesPatient;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnBewerkPatient;
        private System.Windows.Forms.Button btnNieuwePatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZoek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPatientDetail;
    }
}