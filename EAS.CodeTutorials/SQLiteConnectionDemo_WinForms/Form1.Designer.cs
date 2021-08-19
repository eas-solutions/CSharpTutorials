
namespace SQLiteConnectionDemo_WinForms
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
            this.btn_Drop = new System.Windows.Forms.Button();
            this.btn_CreateDatabase = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Drop
            // 
            this.btn_Drop.Location = new System.Drawing.Point(12, 12);
            this.btn_Drop.Name = "btn_Drop";
            this.btn_Drop.Size = new System.Drawing.Size(165, 42);
            this.btn_Drop.TabIndex = 0;
            this.btn_Drop.Text = "DELETE DATABASE";
            this.btn_Drop.UseVisualStyleBackColor = true;
            this.btn_Drop.Click += new System.EventHandler(this.btn_Drop_Click);
            // 
            // btn_CreateDatabase
            // 
            this.btn_CreateDatabase.Location = new System.Drawing.Point(12, 60);
            this.btn_CreateDatabase.Name = "btn_CreateDatabase";
            this.btn_CreateDatabase.Size = new System.Drawing.Size(165, 42);
            this.btn_CreateDatabase.TabIndex = 1;
            this.btn_CreateDatabase.Text = "CREATE DATABASE";
            this.btn_CreateDatabase.UseVisualStyleBackColor = true;
            this.btn_CreateDatabase.Click += new System.EventHandler(this.btn_CreateDatabase_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(12, 108);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(165, 42);
            this.btn_Read.TabIndex = 2;
            this.btn_Read.Text = "READ DATA";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(12, 191);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(165, 26);
            this.txtBoxName.TabIndex = 3;
            this.txtBoxName.TabStop = false;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.Location = new System.Drawing.Point(12, 239);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(165, 26);
            this.txtBoxAge.TabIndex = 4;
            this.txtBoxAge.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(12, 273);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(165, 42);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(196, 12);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(155, 303);
            this.listBoxUsers.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 328);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_CreateDatabase);
            this.Controls.Add(this.btn_Drop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Drop;
        private System.Windows.Forms.Button btn_CreateDatabase;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ListBox listBoxUsers;
    }
}

