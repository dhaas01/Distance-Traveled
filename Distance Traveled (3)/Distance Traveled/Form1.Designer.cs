namespace Distance_Traveled
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
            this.distanceTraveled5HoursButton = new System.Windows.Forms.Button();
            this.distanceTraveled8HoursButton = new System.Windows.Forms.Button();
            this.distanceTraveled12HoursButton = new System.Windows.Forms.Button();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.distanceTraveled5HoursLabel = new System.Windows.Forms.Label();
            this.distanceTraveled8HoursLabel = new System.Windows.Forms.Label();
            this.distanceTraveled12HoursLabel = new System.Windows.Forms.Label();
            this.calculatedDistance5HoursLabel = new System.Windows.Forms.Label();
            this.calculatedDistance8HoursLabel = new System.Windows.Forms.Label();
            this.calculatedDistance12HoursLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // distanceTraveled5HoursButton
            // 
            this.distanceTraveled5HoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled5HoursButton.Location = new System.Drawing.Point(39, 242);
            this.distanceTraveled5HoursButton.Name = "distanceTraveled5HoursButton";
            this.distanceTraveled5HoursButton.Size = new System.Drawing.Size(75, 49);
            this.distanceTraveled5HoursButton.TabIndex = 0;
            this.distanceTraveled5HoursButton.Text = "Distance in 5 Hours";
            this.distanceTraveled5HoursButton.UseVisualStyleBackColor = true;
            this.distanceTraveled5HoursButton.Click += new System.EventHandler(this.DistanceTraveled5HoursButton_Click);
            // 
            // distanceTraveled8HoursButton
            // 
            this.distanceTraveled8HoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled8HoursButton.Location = new System.Drawing.Point(152, 242);
            this.distanceTraveled8HoursButton.Name = "distanceTraveled8HoursButton";
            this.distanceTraveled8HoursButton.Size = new System.Drawing.Size(75, 49);
            this.distanceTraveled8HoursButton.TabIndex = 1;
            this.distanceTraveled8HoursButton.Text = "Distance in 8 Hours";
            this.distanceTraveled8HoursButton.UseVisualStyleBackColor = true;
            this.distanceTraveled8HoursButton.Click += new System.EventHandler(this.DistanceTraveled8HoursButton_Click);
            // 
            // distanceTraveled12HoursButton
            // 
            this.distanceTraveled12HoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled12HoursButton.Location = new System.Drawing.Point(271, 242);
            this.distanceTraveled12HoursButton.Name = "distanceTraveled12HoursButton";
            this.distanceTraveled12HoursButton.Size = new System.Drawing.Size(75, 49);
            this.distanceTraveled12HoursButton.TabIndex = 2;
            this.distanceTraveled12HoursButton.Text = "Distance in 12 Hours";
            this.distanceTraveled12HoursButton.UseVisualStyleBackColor = true;
            this.distanceTraveled12HoursButton.Click += new System.EventHandler(this.DistanceTraveled12HoursButton_Click);
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(434, 66);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 3;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(69, 67);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(277, 16);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Enter the car\'s speed in miles per hour:";
            // 
            // distanceTraveled5HoursLabel
            // 
            this.distanceTraveled5HoursLabel.AutoSize = true;
            this.distanceTraveled5HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled5HoursLabel.Location = new System.Drawing.Point(97, 107);
            this.distanceTraveled5HoursLabel.Name = "distanceTraveled5HoursLabel";
            this.distanceTraveled5HoursLabel.Size = new System.Drawing.Size(249, 16);
            this.distanceTraveled5HoursLabel.TabIndex = 5;
            this.distanceTraveled5HoursLabel.Text = "The distance traveled in 5 hours is:";
            // 
            // distanceTraveled8HoursLabel
            // 
            this.distanceTraveled8HoursLabel.AutoSize = true;
            this.distanceTraveled8HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled8HoursLabel.Location = new System.Drawing.Point(97, 149);
            this.distanceTraveled8HoursLabel.Name = "distanceTraveled8HoursLabel";
            this.distanceTraveled8HoursLabel.Size = new System.Drawing.Size(249, 16);
            this.distanceTraveled8HoursLabel.TabIndex = 6;
            this.distanceTraveled8HoursLabel.Text = "The distance traveled in 8 hours is:";
            // 
            // distanceTraveled12HoursLabel
            // 
            this.distanceTraveled12HoursLabel.AutoSize = true;
            this.distanceTraveled12HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled12HoursLabel.Location = new System.Drawing.Point(89, 184);
            this.distanceTraveled12HoursLabel.Name = "distanceTraveled12HoursLabel";
            this.distanceTraveled12HoursLabel.Size = new System.Drawing.Size(257, 16);
            this.distanceTraveled12HoursLabel.TabIndex = 7;
            this.distanceTraveled12HoursLabel.Text = "The distance traveled in 12 hours is:";
            // 
            // calculatedDistance5HoursLabel
            // 
            this.calculatedDistance5HoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedDistance5HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedDistance5HoursLabel.Location = new System.Drawing.Point(434, 104);
            this.calculatedDistance5HoursLabel.Name = "calculatedDistance5HoursLabel";
            this.calculatedDistance5HoursLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedDistance5HoursLabel.TabIndex = 8;
            this.calculatedDistance5HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedDistance8HoursLabel
            // 
            this.calculatedDistance8HoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedDistance8HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedDistance8HoursLabel.Location = new System.Drawing.Point(434, 146);
            this.calculatedDistance8HoursLabel.Name = "calculatedDistance8HoursLabel";
            this.calculatedDistance8HoursLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedDistance8HoursLabel.TabIndex = 9;
            this.calculatedDistance8HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedDistance12HoursLabel
            // 
            this.calculatedDistance12HoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedDistance12HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedDistance12HoursLabel.Location = new System.Drawing.Point(434, 181);
            this.calculatedDistance12HoursLabel.Name = "calculatedDistance12HoursLabel";
            this.calculatedDistance12HoursLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedDistance12HoursLabel.TabIndex = 10;
            this.calculatedDistance12HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(375, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(478, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 314);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculatedDistance12HoursLabel);
            this.Controls.Add(this.calculatedDistance8HoursLabel);
            this.Controls.Add(this.calculatedDistance5HoursLabel);
            this.Controls.Add(this.distanceTraveled12HoursLabel);
            this.Controls.Add(this.distanceTraveled8HoursLabel);
            this.Controls.Add(this.distanceTraveled5HoursLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.distanceTraveled12HoursButton);
            this.Controls.Add(this.distanceTraveled8HoursButton);
            this.Controls.Add(this.distanceTraveled5HoursButton);
            this.Name = "Form1";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button distanceTraveled5HoursButton;
        private System.Windows.Forms.Button distanceTraveled8HoursButton;
        private System.Windows.Forms.Button distanceTraveled12HoursButton;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label distanceTraveled5HoursLabel;
        private System.Windows.Forms.Label distanceTraveled8HoursLabel;
        private System.Windows.Forms.Label distanceTraveled12HoursLabel;
        private System.Windows.Forms.Label calculatedDistance5HoursLabel;
        private System.Windows.Forms.Label calculatedDistance8HoursLabel;
        private System.Windows.Forms.Label calculatedDistance12HoursLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

