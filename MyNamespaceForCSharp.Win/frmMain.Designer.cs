namespace MyNamespaceForCSharp.Win
{
    partial class frmMain
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
            this.btnComputerInfoAvailablePhysicalMemory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvailablePhysicalMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComputerInfoAvailablePhysicalMemory
            // 
            this.btnComputerInfoAvailablePhysicalMemory.Location = new System.Drawing.Point(16, 48);
            this.btnComputerInfoAvailablePhysicalMemory.Name = "btnComputerInfoAvailablePhysicalMemory";
            this.btnComputerInfoAvailablePhysicalMemory.Size = new System.Drawing.Size(346, 32);
            this.btnComputerInfoAvailablePhysicalMemory.TabIndex = 0;
            this.btnComputerInfoAvailablePhysicalMemory.Text = "My.Computer.Info.AvailablePhysicalMemory";
            this.btnComputerInfoAvailablePhysicalMemory.UseVisualStyleBackColor = true;
            this.btnComputerInfoAvailablePhysicalMemory.Click += new System.EventHandler(this.btnComputerInfoAvailablePhysicalMemory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is a test application for MyNamespaceForCSharp Lib";
            // 
            // lblAvailablePhysicalMemory
            // 
            this.lblAvailablePhysicalMemory.AutoSize = true;
            this.lblAvailablePhysicalMemory.Location = new System.Drawing.Point(368, 56);
            this.lblAvailablePhysicalMemory.Name = "lblAvailablePhysicalMemory";
            this.lblAvailablePhysicalMemory.Size = new System.Drawing.Size(16, 17);
            this.lblAvailablePhysicalMemory.TabIndex = 2;
            this.lblAvailablePhysicalMemory.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 386);
            this.Controls.Add(this.lblAvailablePhysicalMemory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComputerInfoAvailablePhysicalMemory);
            this.Name = "frmMain";
            this.Text = "MyNamespaceForCSharp.Win";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComputerInfoAvailablePhysicalMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailablePhysicalMemory;
    }
}

