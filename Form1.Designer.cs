namespace Timer
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
            this.StartButtn = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StopButtton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButtn
            // 
            this.StartButtn.Location = new System.Drawing.Point(137, 301);
            this.StartButtn.Name = "StartButtn";
            this.StartButtn.Size = new System.Drawing.Size(144, 72);
            this.StartButtn.TabIndex = 0;
            this.StartButtn.Text = "Start";
            this.StartButtn.UseVisualStyleBackColor = true;
            this.StartButtn.Click += new System.EventHandler(this.StartButtn_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(459, 301);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(144, 72);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StopButtton
            // 
            this.StopButtton.Location = new System.Drawing.Point(300, 301);
            this.StopButtton.Name = "StopButtton";
            this.StopButtton.Size = new System.Drawing.Size(144, 72);
            this.StopButtton.TabIndex = 2;
            this.StopButtton.Text = "Stop";
            this.StopButtton.UseVisualStyleBackColor = true;
            this.StopButtton.Click += new System.EventHandler(this.StopButtton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(228, 117);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(301, 90);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.StopButtton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButtn);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButtn;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StopButtton;
        private System.Windows.Forms.Label TimerLabel;
    }
}

