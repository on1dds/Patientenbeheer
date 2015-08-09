namespace PatientenBeheerPlus
{
    partial class frmPrestatieRapport
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
            this.lblnoreport = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblnoreport
            // 
            this.lblnoreport.AutoSize = true;
            this.lblnoreport.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoreport.Location = new System.Drawing.Point(64, 81);
            this.lblnoreport.Name = "lblnoreport";
            this.lblnoreport.Size = new System.Drawing.Size(210, 29);
            this.lblnoreport.TabIndex = 0;
            this.lblnoreport.Text = "helaas geen rapport";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrestatieRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 184);
            this.Controls.Add(this.lblnoreport);
            this.Name = "frmPrestatieRapport";
            this.Text = "frmPrestatieRapport";
            this.Load += new System.EventHandler(this.frmPrestatieRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnoreport;
        private System.Windows.Forms.Timer timer1;
    }
}