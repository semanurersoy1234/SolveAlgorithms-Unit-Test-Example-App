namespace ce205_hw4_algorithms_gui
{
    partial class FormNeedlemanWunsch
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
            this.sequence1Box = new System.Windows.Forms.TextBox();
            this.sequence2Box = new System.Windows.Forms.TextBox();
            this.alignedSequence1Box = new System.Windows.Forms.RichTextBox();
            this.alignedSequence2Box = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Needleman Wunsch";
            // 
            // sequence1Box
            // 
            this.sequence1Box.Location = new System.Drawing.Point(12, 39);
            this.sequence1Box.Name = "sequence1Box";
            this.sequence1Box.Size = new System.Drawing.Size(545, 20);
            this.sequence1Box.TabIndex = 1;
            // 
            // sequence2Box
            // 
            this.sequence2Box.Location = new System.Drawing.Point(13, 65);
            this.sequence2Box.Name = "sequence2Box";
            this.sequence2Box.Size = new System.Drawing.Size(545, 20);
            this.sequence2Box.TabIndex = 2;
            // 
            // alignedSequence1Box
            // 
            this.alignedSequence1Box.Location = new System.Drawing.Point(12, 91);
            this.alignedSequence1Box.Name = "alignedSequence1Box";
            this.alignedSequence1Box.Size = new System.Drawing.Size(545, 96);
            this.alignedSequence1Box.TabIndex = 3;
            this.alignedSequence1Box.Text = "";
            // 
            // alignedSequence2Box
            // 
            this.alignedSequence2Box.Location = new System.Drawing.Point(12, 193);
            this.alignedSequence2Box.Name = "alignedSequence2Box";
            this.alignedSequence2Box.Size = new System.Drawing.Size(545, 96);
            this.alignedSequence2Box.TabIndex = 4;
            this.alignedSequence2Box.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNeedlemanWunsch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alignedSequence2Box);
            this.Controls.Add(this.alignedSequence1Box);
            this.Controls.Add(this.sequence2Box);
            this.Controls.Add(this.sequence1Box);
            this.Controls.Add(this.label1);
            this.Name = "FormNeedlemanWunsch";
            this.Text = "FormNeedlemanWunsch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sequence1Box;
        private System.Windows.Forms.TextBox sequence2Box;
        private System.Windows.Forms.RichTextBox alignedSequence1Box;
        private System.Windows.Forms.RichTextBox alignedSequence2Box;
        private System.Windows.Forms.Button button1;
    }
}