
namespace NumberGuesser
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
            this.BtnGenerateNum = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.LbOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerateNum
            // 
            this.BtnGenerateNum.Location = new System.Drawing.Point(12, 13);
            this.BtnGenerateNum.Name = "BtnGenerateNum";
            this.BtnGenerateNum.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerateNum.TabIndex = 0;
            this.BtnGenerateNum.Text = "Start";
            this.BtnGenerateNum.UseVisualStyleBackColor = true;
            this.BtnGenerateNum.Click += new System.EventHandler(this.BtnGenerateNum_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(94, 16);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(100, 20);
            this.TxtInput.TabIndex = 1;
            // 
            // BtnGuess
            // 
            this.BtnGuess.Location = new System.Drawing.Point(200, 14);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(75, 23);
            this.BtnGuess.TabIndex = 2;
            this.BtnGuess.Text = "Guess";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // LbOutput
            // 
            this.LbOutput.AutoSize = true;
            this.LbOutput.Location = new System.Drawing.Point(12, 43);
            this.LbOutput.Name = "LbOutput";
            this.LbOutput.Size = new System.Drawing.Size(0, 13);
            this.LbOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 281);
            this.Controls.Add(this.LbOutput);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnGenerateNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateNum;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.Label LbOutput;
    }
}

