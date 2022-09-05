namespace Flash_Launcher
{
    partial class UpdateFrm
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
            this.lblCVersion = new System.Windows.Forms.Label();
            this.lblLVersion = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCVersion
            // 
            this.lblCVersion.AutoSize = true;
            this.lblCVersion.Location = new System.Drawing.Point(12, 9);
            this.lblCVersion.Name = "lblCVersion";
            this.lblCVersion.Size = new System.Drawing.Size(67, 13);
            this.lblCVersion.TabIndex = 0;
            this.lblCVersion.Text = "App Version:";
            // 
            // lblLVersion
            // 
            this.lblLVersion.AutoSize = true;
            this.lblLVersion.Location = new System.Drawing.Point(12, 34);
            this.lblLVersion.Name = "lblLVersion";
            this.lblLVersion.Size = new System.Drawing.Size(77, 13);
            this.lblLVersion.TabIndex = 0;
            this.lblLVersion.Text = "Latest Version:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 76);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 2;
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 98);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblLVersion);
            this.Controls.Add(this.lblCVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check for updates";
            this.Load += new System.EventHandler(this.UpdateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCVersion;
        private System.Windows.Forms.Label lblLVersion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblInfo;
    }
}