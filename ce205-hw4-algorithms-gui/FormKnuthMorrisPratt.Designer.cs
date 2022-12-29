namespace ce205_hw4_algorithms_gui
{
    partial class FormKnuthMorrisPratt
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
            this.label1 = new System.Windows.Forms.Label();
            this.SrchBtn = new System.Windows.Forms.Button();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knuth-Morris-Pratt Algorithm";
            // 
            // SrchBtn
            // 
            this.SrchBtn.Location = new System.Drawing.Point(319, 364);
            this.SrchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SrchBtn.Name = "SrchBtn";
            this.SrchBtn.Size = new System.Drawing.Size(100, 28);
            this.SrchBtn.TabIndex = 1;
            this.SrchBtn.Text = "Search";
            this.SrchBtn.UseVisualStyleBackColor = true;
            this.SrchBtn.Click += new System.EventHandler(this.SrchBtn_Click);
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(56, 288);
            this.patternTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(644, 22);
            this.patternTextBox.TabIndex = 2;
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.Location = new System.Drawing.Point(56, 64);
            this.textRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(644, 198);
            this.textRichTextBox.TabIndex = 3;
            this.textRichTextBox.Text = "";
            // 
            // FormKnuthMorrisPratt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 421);
            this.Controls.Add(this.textRichTextBox);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.SrchBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKnuthMorrisPratt";
            this.Text = "KnuthMorrisPratt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SrchBtn;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.RichTextBox textRichTextBox;
    }
}