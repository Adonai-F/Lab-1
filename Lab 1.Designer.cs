
namespace Lab_1
{
    partial class formAverageCalculator
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
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxStored = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTipForCalculator = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(49, 22);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(46, 20);
            this.labelUnits.TabIndex = 0;
            this.labelUnits.Text = "Units";
            this.labelUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(154, 22);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(144, 26);
            this.textBoxUnits.TabIndex = 1;
            this.toolTipForCalculator.SetToolTip(this.textBoxUnits, "Enter your number here");
            // 
            // labelDay
            // 
            this.labelDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDay.Location = new System.Drawing.Point(339, 22);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(100, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // textBoxStored
            // 
            this.textBoxStored.Location = new System.Drawing.Point(111, 68);
            this.textBoxStored.Multiline = true;
            this.textBoxStored.Name = "textBoxStored";
            this.textBoxStored.ReadOnly = true;
            this.textBoxStored.Size = new System.Drawing.Size(236, 157);
            this.textBoxStored.TabIndex = 3;
            this.toolTipForCalculator.SetToolTip(this.textBoxStored, "Where your inputted numbers are stored");
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(53, 238);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(386, 42);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(39, 292);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(101, 34);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculat&e";
            this.toolTipForCalculator.SetToolTip(this.calculateButton, "Press to perform calculation");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(186, 292);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(101, 34);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "&Reset";
            this.toolTipForCalculator.SetToolTip(this.resetButton, "Press to clear all fields");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(338, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.toolTipForCalculator.SetToolTip(this.exitButton, "Press to exit the application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // formAverageCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(473, 347);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxStored);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.labelUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxStored;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ToolTip toolTipForCalculator;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

