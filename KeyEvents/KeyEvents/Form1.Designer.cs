namespace KeyEvents
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
            this.SpaceShipPanel = new System.Windows.Forms.Panel();
            this.ControlInfoLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpaceShipPanel
            // 
            this.SpaceShipPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.SpaceShipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpaceShipPanel.Location = new System.Drawing.Point(366, 176);
            this.SpaceShipPanel.Name = "SpaceShipPanel";
            this.SpaceShipPanel.Size = new System.Drawing.Size(50, 50);
            this.SpaceShipPanel.TabIndex = 0;
            // 
            // ControlInfoLabel
            // 
            this.ControlInfoLabel.AutoSize = true;
            this.ControlInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.ControlInfoLabel.Name = "ControlInfoLabel";
            this.ControlInfoLabel.Size = new System.Drawing.Size(173, 13);
            this.ControlInfoLabel.TabIndex = 1;
            this.ControlInfoLabel.Text = "Use W, A, S and D to control";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(12, 425);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(45, 16);
            this.PositionLabel.TabIndex = 2;
            this.PositionLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.ControlInfoLabel);
            this.Controls.Add(this.SpaceShipPanel);
            this.Name = "Form1";
            this.Text = "KeyEvents";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SpaceShipPanel;
        private System.Windows.Forms.Label ControlInfoLabel;
        private System.Windows.Forms.Label PositionLabel;
    }
}

