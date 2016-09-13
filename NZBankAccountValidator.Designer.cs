namespace BankAccountGenerator
{
    partial class NZBankAccountValidator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NZBankAccountValidator));
            this.label_FilePath = new System.Windows.Forms.Label();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.label_Step1 = new System.Windows.Forms.Label();
            this.label_Step2 = new System.Windows.Forms.Label();
            this.button_ValidateFile = new System.Windows.Forms.Button();
            this.label_Step3 = new System.Windows.Forms.Label();
            this.textBox_ResultFile = new System.Windows.Forms.TextBox();
            this.button_OpenResultFile = new System.Windows.Forms.Button();
            this.label_ResultFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(42, 55);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(72, 13);
            this.label_FilePath.TabIndex = 0;
            this.label_FilePath.Text = "Resauce File:";
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(133, 52);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(314, 20);
            this.textBox_FilePath.TabIndex = 1;
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.Location = new System.Drawing.Point(463, 50);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(75, 23);
            this.button_ChooseFile.TabIndex = 2;
            this.button_ChooseFile.Text = "Choose";
            this.button_ChooseFile.UseVisualStyleBackColor = true;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // label_Step1
            // 
            this.label_Step1.AutoSize = true;
            this.label_Step1.Location = new System.Drawing.Point(88, 36);
            this.label_Step1.Name = "label_Step1";
            this.label_Step1.Size = new System.Drawing.Size(237, 13);
            this.label_Step1.TabIndex = 3;
            this.label_Step1.Text = "Step1: Choose the excel file you want to validate";
            // 
            // label_Step2
            // 
            this.label_Step2.AutoSize = true;
            this.label_Step2.Location = new System.Drawing.Point(88, 101);
            this.label_Step2.Name = "label_Step2";
            this.label_Step2.Size = new System.Drawing.Size(155, 13);
            this.label_Step2.TabIndex = 4;
            this.label_Step2.Text = "Step2: Click the validate button";
            // 
            // button_ValidateFile
            // 
            this.button_ValidateFile.Location = new System.Drawing.Point(133, 118);
            this.button_ValidateFile.Name = "button_ValidateFile";
            this.button_ValidateFile.Size = new System.Drawing.Size(75, 23);
            this.button_ValidateFile.TabIndex = 5;
            this.button_ValidateFile.Text = "Validate";
            this.button_ValidateFile.UseVisualStyleBackColor = true;
            this.button_ValidateFile.Click += new System.EventHandler(this.button_ValidateFile_Click);
            // 
            // label_Step3
            // 
            this.label_Step3.AutoSize = true;
            this.label_Step3.Location = new System.Drawing.Point(88, 180);
            this.label_Step3.Name = "label_Step3";
            this.label_Step3.Size = new System.Drawing.Size(178, 13);
            this.label_Step3.TabIndex = 6;
            this.label_Step3.Text = "Step3: Check the results in result file";
            // 
            // textBox_ResultFile
            // 
            this.textBox_ResultFile.Location = new System.Drawing.Point(133, 196);
            this.textBox_ResultFile.Name = "textBox_ResultFile";
            this.textBox_ResultFile.Size = new System.Drawing.Size(314, 20);
            this.textBox_ResultFile.TabIndex = 7;
            // 
            // button_OpenResultFile
            // 
            this.button_OpenResultFile.Location = new System.Drawing.Point(463, 194);
            this.button_OpenResultFile.Name = "button_OpenResultFile";
            this.button_OpenResultFile.Size = new System.Drawing.Size(75, 23);
            this.button_OpenResultFile.TabIndex = 8;
            this.button_OpenResultFile.Text = "Open";
            this.button_OpenResultFile.UseVisualStyleBackColor = true;
            this.button_OpenResultFile.Click += new System.EventHandler(this.button_OpenResultFile_Click);
            // 
            // label_ResultFile
            // 
            this.label_ResultFile.AutoSize = true;
            this.label_ResultFile.Location = new System.Drawing.Point(55, 199);
            this.label_ResultFile.Name = "label_ResultFile";
            this.label_ResultFile.Size = new System.Drawing.Size(59, 13);
            this.label_ResultFile.TabIndex = 9;
            this.label_ResultFile.Text = "Result File:";
            // 
            // NZBankAccountValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 371);
            this.Controls.Add(this.label_ResultFile);
            this.Controls.Add(this.button_OpenResultFile);
            this.Controls.Add(this.textBox_ResultFile);
            this.Controls.Add(this.label_Step3);
            this.Controls.Add(this.button_ValidateFile);
            this.Controls.Add(this.label_Step2);
            this.Controls.Add(this.label_Step1);
            this.Controls.Add(this.button_ChooseFile);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.label_FilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NZBankAccountValidator";
            this.Text = "NZ Bank Account Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_ChooseFile;
        private System.Windows.Forms.Label label_Step1;
        private System.Windows.Forms.Label label_Step2;
        private System.Windows.Forms.Button button_ValidateFile;
        private System.Windows.Forms.Label label_Step3;
        private System.Windows.Forms.TextBox textBox_ResultFile;
        private System.Windows.Forms.Button button_OpenResultFile;
        private System.Windows.Forms.Label label_ResultFile;
    }
}