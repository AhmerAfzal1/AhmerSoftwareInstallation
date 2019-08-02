namespace Ahmer_Silent_Software_Install_Program_GUI
{
    partial class AhmerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDevelopedBy = new System.Windows.Forms.Label();
            this.labelAhmerAfzal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDevelopedBy
            // 
            this.labelDevelopedBy.AutoSize = true;
            this.labelDevelopedBy.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevelopedBy.ForeColor = System.Drawing.Color.Azure;
            this.labelDevelopedBy.Location = new System.Drawing.Point(95, 112);
            this.labelDevelopedBy.Name = "labelDevelopedBy";
            this.labelDevelopedBy.Size = new System.Drawing.Size(207, 47);
            this.labelDevelopedBy.TabIndex = 2;
            this.labelDevelopedBy.Text = "Developed by:";
            // 
            // labelAhmerAfzal
            // 
            this.labelAhmerAfzal.AutoSize = true;
            this.labelAhmerAfzal.Font = new System.Drawing.Font("Ribbon Heart", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAhmerAfzal.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAhmerAfzal.Location = new System.Drawing.Point(38, 181);
            this.labelAhmerAfzal.Name = "labelAhmerAfzal";
            this.labelAhmerAfzal.Size = new System.Drawing.Size(909, 233);
            this.labelAhmerAfzal.TabIndex = 3;
            this.labelAhmerAfzal.Text = "Ahmer Afzal";
            // 
            // AhmerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.labelAhmerAfzal);
            this.Controls.Add(this.labelDevelopedBy);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "AhmerUC";
            this.Size = new System.Drawing.Size(984, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDevelopedBy;
        private System.Windows.Forms.Label labelAhmerAfzal;
    }
}
