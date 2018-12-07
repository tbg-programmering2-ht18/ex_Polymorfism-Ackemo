namespace ex_polymorfism
{
    partial class rbCreate
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
            this.rbnA = new System.Windows.Forms.RadioButton();
            this.rbnB = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbnA
            // 
            this.rbnA.AutoSize = true;
            this.rbnA.Location = new System.Drawing.Point(24, 31);
            this.rbnA.Name = "rbnA";
            this.rbnA.Size = new System.Drawing.Size(88, 21);
            this.rbnA.TabIndex = 0;
            this.rbnA.TabStop = true;
            this.rbnA.Text = "Välj typ A";
            this.rbnA.UseVisualStyleBackColor = true;
            // 
            // rbnB
            // 
            this.rbnB.AutoSize = true;
            this.rbnB.Location = new System.Drawing.Point(25, 60);
            this.rbnB.Name = "rbnB";
            this.rbnB.Size = new System.Drawing.Size(88, 21);
            this.rbnB.TabIndex = 1;
            this.rbnB.TabStop = true;
            this.rbnB.Text = "Välj typ B";
            this.rbnB.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(173, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Skapa";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 3;
            // 
            // rbCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 135);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rbnB);
            this.Controls.Add(this.rbnA);
            this.Name = "rbCreate";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnA;
        private System.Windows.Forms.RadioButton rbnB;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBox1;
    }
}

