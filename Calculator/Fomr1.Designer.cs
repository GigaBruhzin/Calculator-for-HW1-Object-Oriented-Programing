namespace Calculator
{
    partial class FrmCalculateGrade
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNumberGrade = new TextBox();
            txtLetterGrade = new TextBox();
            btnCalc = new Button();
            btnExt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Number Grade:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Letter Grade:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location = new Point(140, 26);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(100, 23);
            txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location = new Point(140, 72);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.ReadOnly = true;
            txtLetterGrade.Size = new Size(100, 23);
            txtLetterGrade.TabIndex = 3;
            txtLetterGrade.TabStop = false;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(25, 113);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(165, 113);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(75, 23);
            btnExt.TabIndex = 3;
            btnExt.Text = "Exit";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += this.btnExt_Click;
            // 
            // FrmCalculateGrade
            // 
            AcceptButton = btnCalc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExt;
            ClientSize = new Size(272, 158);
            Controls.Add(btnExt);
            Controls.Add(btnCalc);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumberGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculateGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumberGrade;
        private TextBox txtLetterGrade;
        private Button btnCalc;
        private Button btnExt;
    }
}
