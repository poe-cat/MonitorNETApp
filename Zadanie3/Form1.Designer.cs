namespace MonitorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Button buttonStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCpu = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(30, 30);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(38, 15);
            this.labelCpu.Text = "CPU:";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(30, 60);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(38, 15);
            this.labelRam.Text = "RAM:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(30, 100);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 30);
            this.buttonStart.Text = "Start monitorowania";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Monitor systemowy";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
