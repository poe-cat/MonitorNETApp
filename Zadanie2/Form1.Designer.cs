namespace KalkulatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button[] numButtons = new System.Windows.Forms.Button[10];
        private System.Windows.Forms.Button buttonAdd, buttonSub, buttonMul, buttonDiv, buttonEq, buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.textBoxDisplay.Location = new System.Drawing.Point(20, 20);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(210, 23);
            this.Controls.Add(this.textBoxDisplay);

            for (int i = 0; i <= 9; i++)
            {
                numButtons[i] = new System.Windows.Forms.Button();
                numButtons[i].Text = i.ToString();
                numButtons[i].Size = new System.Drawing.Size(50, 30);
                int row = (i == 0) ? 3 : (2 - (i - 1) / 3);
                int col = (i == 0) ? 1 : ((i - 1) % 3);
                numButtons[i].Location = new System.Drawing.Point(20 + col * 60, 60 + row * 40);
                string num = i.ToString();
                numButtons[i].Click += (s, e) => AppendNumber(num);
                this.Controls.Add(numButtons[i]);
            }

            buttonAdd = new System.Windows.Forms.Button() { Text = "+", Location = new System.Drawing.Point(200, 60), Size = new System.Drawing.Size(50, 30) };
            buttonAdd.Click += (s, e) => SetOperation("+");
            this.Controls.Add(buttonAdd);

            buttonSub = new System.Windows.Forms.Button() { Text = "-", Location = new System.Drawing.Point(200, 100), Size = new System.Drawing.Size(50, 30) };
            buttonSub.Click += (s, e) => SetOperation("-");
            this.Controls.Add(buttonSub);

            buttonMul = new System.Windows.Forms.Button() { Text = "*", Location = new System.Drawing.Point(200, 140), Size = new System.Drawing.Size(50, 30) };
            buttonMul.Click += (s, e) => SetOperation("*");
            this.Controls.Add(buttonMul);

            buttonDiv = new System.Windows.Forms.Button() { Text = "/", Location = new System.Drawing.Point(200, 180), Size = new System.Drawing.Size(50, 30) };
            buttonDiv.Click += (s, e) => SetOperation("/");
            this.Controls.Add(buttonDiv);

            buttonEq = new System.Windows.Forms.Button() { Text = "=", Location = new System.Drawing.Point(140, 220), Size = new System.Drawing.Size(50, 30) };
            buttonEq.Click += (s, e) => CalculateResult();
            this.Controls.Add(buttonEq);

            buttonClear = new System.Windows.Forms.Button() { Text = "C", Location = new System.Drawing.Point(80, 220), Size = new System.Drawing.Size(50, 30) };
            buttonClear.Click += (s, e) => ClearAll();
            this.Controls.Add(buttonClear);

            this.ClientSize = new System.Drawing.Size(280, 270);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
