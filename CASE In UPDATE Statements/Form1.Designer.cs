namespace CASE_In_UPDATE_Statements
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
            this.btnUpdateUsingCS = new System.Windows.Forms.Button();
            this.btnUpdateUsingCaseStatement = new System.Windows.Forms.Button();
            this.btnCategorizeEmployeesUsingCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateUsingCS
            // 
            this.btnUpdateUsingCS.Location = new System.Drawing.Point(12, 79);
            this.btnUpdateUsingCS.Name = "btnUpdateUsingCS";
            this.btnUpdateUsingCS.Size = new System.Drawing.Size(298, 40);
            this.btnUpdateUsingCS.TabIndex = 0;
            this.btnUpdateUsingCS.Text = "Update using C#";
            this.btnUpdateUsingCS.UseVisualStyleBackColor = true;
            this.btnUpdateUsingCS.Click += new System.EventHandler(this.btnUpdateUsingCS_Click);
            // 
            // btnUpdateUsingCaseStatement
            // 
            this.btnUpdateUsingCaseStatement.Location = new System.Drawing.Point(12, 186);
            this.btnUpdateUsingCaseStatement.Name = "btnUpdateUsingCaseStatement";
            this.btnUpdateUsingCaseStatement.Size = new System.Drawing.Size(298, 40);
            this.btnUpdateUsingCaseStatement.TabIndex = 1;
            this.btnUpdateUsingCaseStatement.Text = "Update using Case statement";
            this.btnUpdateUsingCaseStatement.UseVisualStyleBackColor = true;
            this.btnUpdateUsingCaseStatement.Click += new System.EventHandler(this.btnUpdateUsingCaseStatement_Click);
            // 
            // btnCategorizeEmployeesUsingCS
            // 
            this.btnCategorizeEmployeesUsingCS.Location = new System.Drawing.Point(442, 111);
            this.btnCategorizeEmployeesUsingCS.Name = "btnCategorizeEmployeesUsingCS";
            this.btnCategorizeEmployeesUsingCS.Size = new System.Drawing.Size(428, 69);
            this.btnCategorizeEmployeesUsingCS.TabIndex = 2;
            this.btnCategorizeEmployeesUsingCS.Text = "Categorize Employees By Performance Rating\r\n(Using C#)";
            this.btnCategorizeEmployeesUsingCS.UseVisualStyleBackColor = true;
            this.btnCategorizeEmployeesUsingCS.Click += new System.EventHandler(this.btnCategorizeEmployeesUsingCS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 278);
            this.Controls.Add(this.btnCategorizeEmployeesUsingCS);
            this.Controls.Add(this.btnUpdateUsingCaseStatement);
            this.Controls.Add(this.btnUpdateUsingCS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateUsingCS;
        private System.Windows.Forms.Button btnUpdateUsingCaseStatement;
        private System.Windows.Forms.Button btnCategorizeEmployeesUsingCS;
    }
}

