namespace EAS.CodeTutorials.MovingSquares
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.GreenPanel = new System.Windows.Forms.Panel();
            this.YellowPanel = new System.Windows.Forms.Panel();
            this.RotationTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.FasterButton = new System.Windows.Forms.Button();
            this.SlowerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.Color.Red;
            this.RedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedPanel.Location = new System.Drawing.Point(10, 10);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(80, 80);
            this.RedPanel.TabIndex = 0;
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.Color.Blue;
            this.BluePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BluePanel.Location = new System.Drawing.Point(300, 10);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(80, 80);
            this.BluePanel.TabIndex = 1;
            // 
            // GreenPanel
            // 
            this.GreenPanel.BackColor = System.Drawing.Color.Green;
            this.GreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenPanel.Location = new System.Drawing.Point(10, 300);
            this.GreenPanel.Name = "GreenPanel";
            this.GreenPanel.Size = new System.Drawing.Size(80, 80);
            this.GreenPanel.TabIndex = 1;
            // 
            // YellowPanel
            // 
            this.YellowPanel.BackColor = System.Drawing.Color.Yellow;
            this.YellowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowPanel.Location = new System.Drawing.Point(300, 300);
            this.YellowPanel.Name = "YellowPanel";
            this.YellowPanel.Size = new System.Drawing.Size(80, 80);
            this.YellowPanel.TabIndex = 1;
            // 
            // RotationTimer
            // 
            this.RotationTimer.Interval = 5;
            this.RotationTimer.Tick += new System.EventHandler(this.RotationTimer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Chicago", 22F, System.Drawing.FontStyle.Bold);
            this.StartButton.Location = new System.Drawing.Point(398, 10);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 135);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Chicago", 22F, System.Drawing.FontStyle.Bold);
            this.StopButton.Location = new System.Drawing.Point(398, 220);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(120, 160);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FasterButton
            // 
            this.FasterButton.Font = new System.Drawing.Font("Chicago", 16F, System.Drawing.FontStyle.Bold);
            this.FasterButton.Location = new System.Drawing.Point(462, 174);
            this.FasterButton.Name = "FasterButton";
            this.FasterButton.Size = new System.Drawing.Size(56, 40);
            this.FasterButton.TabIndex = 5;
            this.FasterButton.Text = "+";
            this.FasterButton.UseVisualStyleBackColor = true;
            this.FasterButton.Click += new System.EventHandler(this.FasterButton_Click);
            // 
            // SlowerButton
            // 
            this.SlowerButton.Font = new System.Drawing.Font("Chicago", 16F, System.Drawing.FontStyle.Bold);
            this.SlowerButton.Location = new System.Drawing.Point(398, 174);
            this.SlowerButton.Name = "SlowerButton";
            this.SlowerButton.Size = new System.Drawing.Size(56, 40);
            this.SlowerButton.TabIndex = 6;
            this.SlowerButton.Text = "-";
            this.SlowerButton.UseVisualStyleBackColor = true;
            this.SlowerButton.Click += new System.EventHandler(this.SlowerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Interval:";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalLabel.Location = new System.Drawing.Point(460, 147);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(20, 24);
            this.IntervalLabel.TabIndex = 8;
            this.IntervalLabel.Text = "0";
            this.IntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hier passiert noch nichts :)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SlowerButton);
            this.Controls.Add(this.FasterButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.YellowPanel);
            this.Controls.Add(this.GreenPanel);
            this.Controls.Add(this.BluePanel);
            this.Controls.Add(this.RedPanel);
            this.Name = "Form1";
            this.Text = "Moving Squares Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RedPanel;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Panel GreenPanel;
        private System.Windows.Forms.Panel YellowPanel;
        private System.Windows.Forms.Timer RotationTimer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FasterButton;
        private System.Windows.Forms.Button SlowerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Label label2;
    }
}

