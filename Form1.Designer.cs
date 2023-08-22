namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            second_number = new TextBox();
            first_number = new TextBox();
            FN = new Label();
            SN = new Label();
            operation = new ComboBox();
            button1 = new Button();
            Result = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // second_number
            // 
            second_number.Location = new Point(251, 71);
            second_number.Name = "second_number";
            second_number.Size = new Size(261, 23);
            second_number.TabIndex = 0;
            // 
            // first_number
            // 
            first_number.Location = new Point(251, 29);
            first_number.Name = "first_number";
            first_number.Size = new Size(261, 23);
            first_number.TabIndex = 1;
            // 
            // FN
            // 
            FN.AutoSize = true;
            FN.Location = new Point(169, 32);
            FN.Name = "FN";
            FN.Size = new Size(76, 15);
            FN.TabIndex = 2;
            FN.Text = "First Number";
            // 
            // SN
            // 
            SN.AutoSize = true;
            SN.Location = new Point(152, 74);
            SN.Name = "SN";
            SN.Size = new Size(93, 15);
            SN.TabIndex = 3;
            SN.Text = "Second Number";
            // 
            // operation
            // 
            operation.FormattingEnabled = true;
            operation.Items.AddRange(new object[] { "Addition", "Subtration", "Multiplication", "Division" });
            operation.Location = new Point(251, 111);
            operation.Name = "operation";
            operation.Size = new Size(261, 23);
            operation.TabIndex = 4;
            operation.Text = "Select Operation";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(332, 157);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            Result.Location = new Point(251, 214);
            Result.Name = "Result";
            Result.PlaceholderText = "Result";
            Result.Size = new Size(261, 23);
            Result.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 217);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Result);
            Controls.Add(button1);
            Controls.Add(operation);
            Controls.Add(SN);
            Controls.Add(FN);
            Controls.Add(first_number);
            Controls.Add(second_number);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox second_number;
        private TextBox first_number;
        private Label FN;
        private Label SN;
        private ComboBox operation;
        private Button button1;
        private TextBox Result;
        private Label label1;
    }
}