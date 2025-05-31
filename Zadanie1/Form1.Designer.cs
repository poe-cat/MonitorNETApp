namespace DzielnikApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDzielna;
        private System.Windows.Forms.TextBox textBoxDzielnik;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

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
            this.textBoxDzielna = new System.Windows.Forms.TextBox();
            this.textBoxDzielnik = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDzielna
            // 
            this.textBoxDzielna.Location = new System.Drawing.Point(100, 20);
            this.textBoxDzielna.Name = "textBoxDzielna";
            this.textBoxDzielna.Size = new System.Drawing.Size(150, 23);
            // 
            // textBoxDzielnik
            // 
            this.textBoxDzielnik.Location = new System.Drawing.Point(100, 60);
            this.textBoxDzielnik.Name = "textBoxDzielnik";
            this.textBoxDzielnik.Size = new System.Drawing.Size(150, 23);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(100, 100);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.ReadOnly = true;
            this.textBoxWynik.Size = new System.Drawing.Size(150, 23);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(100, 140);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(150, 30);
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Dzielna:";
            this.label1.Size = new System.Drawing.Size(80, 23);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Text = "Dzielnik:";
            this.label2.Size = new System.Drawing.Size(80, 23);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Text = "Wynik:";
            this.label3.Size = new System.Drawing.Size(80, 23);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.textBoxDzielna);
            this.Controls.Add(this.textBoxDzielnik);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Dzielnik";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
