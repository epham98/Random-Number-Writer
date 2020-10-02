namespace Random_Number_Writer
{
    partial class Form1
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
            this.rngLabel = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.randNumListBox = new System.Windows.Forms.ListBox();
            this.randNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rngLabel
            // 
            this.rngLabel.AutoSize = true;
            this.rngLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rngLabel.Location = new System.Drawing.Point(21, 22);
            this.rngLabel.Name = "rngLabel";
            this.rngLabel.Size = new System.Drawing.Size(197, 16);
            this.rngLabel.TabIndex = 0;
            this.rngLabel.Text = "Random Number Generator";
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(39, 88);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "Write to File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(129, 88);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(12, 56);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(111, 13);
            this.promptLabel.TabIndex = 4;
            this.promptLabel.Text = "Numbers to Generate:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(129, 53);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 5;
            // 
            // randNumListBox
            // 
            this.randNumListBox.FormattingEnabled = true;
            this.randNumListBox.Location = new System.Drawing.Point(65, 155);
            this.randNumListBox.Name = "randNumListBox";
            this.randNumListBox.Size = new System.Drawing.Size(120, 95);
            this.randNumListBox.TabIndex = 6;
            // 
            // randNumLabel
            // 
            this.randNumLabel.AutoSize = true;
            this.randNumLabel.Location = new System.Drawing.Point(78, 127);
            this.randNumLabel.Name = "randNumLabel";
            this.randNumLabel.Size = new System.Drawing.Size(86, 13);
            this.randNumLabel.TabIndex = 7;
            this.randNumLabel.Text = "Numbers Written";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.randNumLabel);
            this.Controls.Add(this.randNumListBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.rngLabel);
            this.Name = "Form1";
            this.Text = "Number Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rngLabel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ListBox randNumListBox;
        private System.Windows.Forms.Label randNumLabel;
    }
}

