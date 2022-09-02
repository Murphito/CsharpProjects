
namespace Calculator
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
            this.In1 = new System.Windows.Forms.TextBox();
            this.In2 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InOperator = new System.Windows.Forms.Label();
            this.Awnser = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // In1
            // 
            this.In1.Location = new System.Drawing.Point(105, 48);
            this.In1.MaxLength = 5;
            this.In1.Name = "In1";
            this.In1.Size = new System.Drawing.Size(72, 20);
            this.In1.TabIndex = 0;
            // 
            // In2
            // 
            this.In2.Location = new System.Drawing.Point(202, 48);
            this.In2.MaxLength = 5;
            this.In2.Name = "In2";
            this.In2.Size = new System.Drawing.Size(72, 20);
            this.In2.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(152, 83);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 20);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(12, 34);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "Plus";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(12, 64);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 4;
            this.Minus.Text = "Minus";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Times
            // 
            this.Times.Location = new System.Drawing.Point(12, 94);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(75, 23);
            this.Times.TabIndex = 5;
            this.Times.Text = "Times";
            this.Times.UseVisualStyleBackColor = true;
            this.Times.Click += new System.EventHandler(this.Times_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(12, 124);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operators";
            // 
            // InOperator
            // 
            this.InOperator.AutoSize = true;
            this.InOperator.Location = new System.Drawing.Point(183, 52);
            this.InOperator.Name = "InOperator";
            this.InOperator.Size = new System.Drawing.Size(13, 13);
            this.InOperator.TabIndex = 11;
            this.InOperator.Text = "?";
            // 
            // Awnser
            // 
            this.Awnser.AutoSize = true;
            this.Awnser.Location = new System.Drawing.Point(300, 52);
            this.Awnser.Name = "Awnser";
            this.Awnser.Size = new System.Drawing.Size(0, 13);
            this.Awnser.TabIndex = 12;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(152, 110);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 13;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Awnser);
            this.Controls.Add(this.InOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.In2);
            this.Controls.Add(this.In1);
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox In1;
        private System.Windows.Forms.TextBox In2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InOperator;
        private System.Windows.Forms.Label Awnser;
        private System.Windows.Forms.Button ResetBtn;
    }
}

