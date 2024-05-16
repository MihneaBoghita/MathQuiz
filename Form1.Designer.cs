namespace MathQuiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.leftNumLabel = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.rightNumLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // timeLabel
            //
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.timeLabel.Location = new System.Drawing.Point(270, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(127, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            //
            // startButton
            //
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.startButton.Location = new System.Drawing.Point(143, 290);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 42);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            //
            // leftNumLabel
            //
            this.leftNumLabel.AutoSize = true;
            this.leftNumLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.leftNumLabel.Location = new System.Drawing.Point(51, 109);
            this.leftNumLabel.Name = "leftNumLabel";
            this.leftNumLabel.Size = new System.Drawing.Size(41, 54);
            this.leftNumLabel.TabIndex = 10;
            this.leftNumLabel.Text = "?";
            //
            // opLabel
            //
            this.opLabel.AutoSize = true;
            this.opLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.opLabel.Location = new System.Drawing.Point(120, 109);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(39, 54);
            this.opLabel.TabIndex = 11;
            this.opLabel.Text = "?";
            //
            // rightNumLabel
            //
            this.rightNumLabel.AutoSize = true;
            this.rightNumLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.rightNumLabel.Location = new System.Drawing.Point(193, 109);
            this.rightNumLabel.Name = "rightNumLabel";
            this.rightNumLabel.Size = new System.Drawing.Size(41, 54);
            this.rightNumLabel.TabIndex = 12;
            this.rightNumLabel.Text = "?";
            //
            // userAnswerTextBox
            //
            this.userAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.userAnswerTextBox.Location = new System.Drawing.Point(315, 109);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(100, 61);
            this.userAnswerTextBox.TabIndex = 13;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.rightNumLabel);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.leftNumLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label leftNumLabel;
        private System.Windows.Forms.Label opLabel;
        private System.Windows.Forms.Label rightNumLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
    }
}
