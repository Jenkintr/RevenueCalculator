namespace stadiumSeating
{
    partial class stadiumSeating
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
            this.soldGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.instructionalLabel = new System.Windows.Forms.Label();
            this.inputALabel = new System.Windows.Forms.Label();
            this.inputBLabel = new System.Windows.Forms.Label();
            this.inputCLabel = new System.Windows.Forms.Label();
            this.outputALabel = new System.Windows.Forms.Label();
            this.outputBLabel = new System.Windows.Forms.Label();
            this.outputCLabel = new System.Windows.Forms.Label();
            this.outputTotalLabel = new System.Windows.Forms.Label();
            this.inputATextBox = new System.Windows.Forms.TextBox();
            this.inputBTextBox = new System.Windows.Forms.TextBox();
            this.inputCTextBox = new System.Windows.Forms.TextBox();
            this.displayAOutputLabel = new System.Windows.Forms.Label();
            this.displayBOutputLabel = new System.Windows.Forms.Label();
            this.displayCOutputLabel = new System.Windows.Forms.Label();
            this.displayTotalOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.soldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // soldGroupBox
            // 
            this.soldGroupBox.Controls.Add(this.inputCTextBox);
            this.soldGroupBox.Controls.Add(this.inputBTextBox);
            this.soldGroupBox.Controls.Add(this.inputATextBox);
            this.soldGroupBox.Controls.Add(this.inputCLabel);
            this.soldGroupBox.Controls.Add(this.inputBLabel);
            this.soldGroupBox.Controls.Add(this.inputALabel);
            this.soldGroupBox.Controls.Add(this.instructionalLabel);
            this.soldGroupBox.Location = new System.Drawing.Point(12, 12);
            this.soldGroupBox.Name = "soldGroupBox";
            this.soldGroupBox.Size = new System.Drawing.Size(252, 172);
            this.soldGroupBox.TabIndex = 0;
            this.soldGroupBox.TabStop = false;
            this.soldGroupBox.Text = "Tickets Sold";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.displayTotalOutputLabel);
            this.revenueGroupBox.Controls.Add(this.displayCOutputLabel);
            this.revenueGroupBox.Controls.Add(this.displayBOutputLabel);
            this.revenueGroupBox.Controls.Add(this.displayAOutputLabel);
            this.revenueGroupBox.Controls.Add(this.outputTotalLabel);
            this.revenueGroupBox.Controls.Add(this.outputCLabel);
            this.revenueGroupBox.Controls.Add(this.outputBLabel);
            this.revenueGroupBox.Controls.Add(this.outputALabel);
            this.revenueGroupBox.Location = new System.Drawing.Point(280, 12);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(252, 172);
            this.revenueGroupBox.TabIndex = 1;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // instructionalLabel
            // 
            this.instructionalLabel.Location = new System.Drawing.Point(50, 27);
            this.instructionalLabel.Name = "instructionalLabel";
            this.instructionalLabel.Size = new System.Drawing.Size(148, 30);
            this.instructionalLabel.TabIndex = 0;
            this.instructionalLabel.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // inputALabel
            // 
            this.inputALabel.AutoSize = true;
            this.inputALabel.Location = new System.Drawing.Point(50, 76);
            this.inputALabel.Name = "inputALabel";
            this.inputALabel.Size = new System.Drawing.Size(45, 13);
            this.inputALabel.TabIndex = 1;
            this.inputALabel.Text = "Class A:";
            // 
            // inputBLabel
            // 
            this.inputBLabel.AutoSize = true;
            this.inputBLabel.Location = new System.Drawing.Point(50, 105);
            this.inputBLabel.Name = "inputBLabel";
            this.inputBLabel.Size = new System.Drawing.Size(45, 13);
            this.inputBLabel.TabIndex = 2;
            this.inputBLabel.Text = "Class B:";
            // 
            // inputCLabel
            // 
            this.inputCLabel.AutoSize = true;
            this.inputCLabel.Location = new System.Drawing.Point(50, 134);
            this.inputCLabel.Name = "inputCLabel";
            this.inputCLabel.Size = new System.Drawing.Size(45, 13);
            this.inputCLabel.TabIndex = 3;
            this.inputCLabel.Text = "Class C:";
            // 
            // outputALabel
            // 
            this.outputALabel.AutoSize = true;
            this.outputALabel.Location = new System.Drawing.Point(52, 27);
            this.outputALabel.Name = "outputALabel";
            this.outputALabel.Size = new System.Drawing.Size(45, 13);
            this.outputALabel.TabIndex = 0;
            this.outputALabel.Text = "Class A:";
            // 
            // outputBLabel
            // 
            this.outputBLabel.AutoSize = true;
            this.outputBLabel.Location = new System.Drawing.Point(52, 62);
            this.outputBLabel.Name = "outputBLabel";
            this.outputBLabel.Size = new System.Drawing.Size(45, 13);
            this.outputBLabel.TabIndex = 1;
            this.outputBLabel.Text = "Class B:";
            // 
            // outputCLabel
            // 
            this.outputCLabel.AutoSize = true;
            this.outputCLabel.Location = new System.Drawing.Point(52, 97);
            this.outputCLabel.Name = "outputCLabel";
            this.outputCLabel.Size = new System.Drawing.Size(45, 13);
            this.outputCLabel.TabIndex = 2;
            this.outputCLabel.Text = "Class C:";
            // 
            // outputTotalLabel
            // 
            this.outputTotalLabel.AutoSize = true;
            this.outputTotalLabel.Location = new System.Drawing.Point(63, 132);
            this.outputTotalLabel.Name = "outputTotalLabel";
            this.outputTotalLabel.Size = new System.Drawing.Size(34, 13);
            this.outputTotalLabel.TabIndex = 3;
            this.outputTotalLabel.Text = "Total:";
            // 
            // inputATextBox
            // 
            this.inputATextBox.Location = new System.Drawing.Point(103, 73);
            this.inputATextBox.Name = "inputATextBox";
            this.inputATextBox.Size = new System.Drawing.Size(100, 20);
            this.inputATextBox.TabIndex = 0;
            // 
            // inputBTextBox
            // 
            this.inputBTextBox.Location = new System.Drawing.Point(103, 102);
            this.inputBTextBox.Name = "inputBTextBox";
            this.inputBTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputBTextBox.TabIndex = 1;
            // 
            // inputCTextBox
            // 
            this.inputCTextBox.Location = new System.Drawing.Point(103, 131);
            this.inputCTextBox.Name = "inputCTextBox";
            this.inputCTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputCTextBox.TabIndex = 2;
            // 
            // displayAOutputLabel
            // 
            this.displayAOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayAOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAOutputLabel.Location = new System.Drawing.Point(102, 27);
            this.displayAOutputLabel.Name = "displayAOutputLabel";
            this.displayAOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.displayAOutputLabel.TabIndex = 4;
            this.displayAOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayBOutputLabel
            // 
            this.displayBOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBOutputLabel.Location = new System.Drawing.Point(102, 61);
            this.displayBOutputLabel.Name = "displayBOutputLabel";
            this.displayBOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.displayBOutputLabel.TabIndex = 5;
            this.displayBOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayCOutputLabel
            // 
            this.displayCOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayCOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCOutputLabel.Location = new System.Drawing.Point(102, 95);
            this.displayCOutputLabel.Name = "displayCOutputLabel";
            this.displayCOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.displayCOutputLabel.TabIndex = 6;
            this.displayCOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayTotalOutputLabel
            // 
            this.displayTotalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTotalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTotalOutputLabel.Location = new System.Drawing.Point(102, 129);
            this.displayTotalOutputLabel.Name = "displayTotalOutputLabel";
            this.displayTotalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.displayTotalOutputLabel.TabIndex = 7;
            this.displayTotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(136, 203);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 39);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculat&e Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(236, 202);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 39);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(335, 203);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stadiumSeating
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.soldGroupBox);
            this.Name = "stadiumSeating";
            this.Text = "Stadium Seating";
            this.soldGroupBox.ResumeLayout(false);
            this.soldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox soldGroupBox;
        private System.Windows.Forms.TextBox inputCTextBox;
        private System.Windows.Forms.TextBox inputBTextBox;
        private System.Windows.Forms.TextBox inputATextBox;
        private System.Windows.Forms.Label inputCLabel;
        private System.Windows.Forms.Label inputBLabel;
        private System.Windows.Forms.Label inputALabel;
        private System.Windows.Forms.Label instructionalLabel;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Label displayTotalOutputLabel;
        private System.Windows.Forms.Label displayCOutputLabel;
        private System.Windows.Forms.Label displayBOutputLabel;
        private System.Windows.Forms.Label displayAOutputLabel;
        private System.Windows.Forms.Label outputTotalLabel;
        private System.Windows.Forms.Label outputCLabel;
        private System.Windows.Forms.Label outputBLabel;
        private System.Windows.Forms.Label outputALabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

