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
            this.labelAhmerAfzal = new System.Windows.Forms.Label();
            this.labelDevelopedBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAhmerAfzal
            // 
            this.labelAhmerAfzal.AutoSize = true;
            this.labelAhmerAfzal.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Bold);
            this.labelAhmerAfzal.ForeColor = System.Drawing.Color.Crimson;
            this.labelAhmerAfzal.Location = new System.Drawing.Point(125, 212);
            this.labelAhmerAfzal.Name = "labelAhmerAfzal";
            this.labelAhmerAfzal.Size = new System.Drawing.Size(765, 159);
            this.labelAhmerAfzal.TabIndex = 3;
            this.labelAhmerAfzal.Text = "Ahmer Afzal";
            // 
            // labelDevelopedBy
            // 
            this.labelDevelopedBy.AutoSize = true;
            this.labelDevelopedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevelopedBy.ForeColor = System.Drawing.Color.Black;
            this.labelDevelopedBy.Location = new System.Drawing.Point(95, 155);
            this.labelDevelopedBy.Name = "labelDevelopedBy";
            this.labelDevelopedBy.Size = new System.Drawing.Size(191, 37);
            this.labelDevelopedBy.TabIndex = 2;
            this.labelDevelopedBy.Text = "Developed by:";
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

        private System.Windows.Forms.Label labelAhmerAfzal;
        private System.Windows.Forms.Label labelDevelopedBy;
    }
}
