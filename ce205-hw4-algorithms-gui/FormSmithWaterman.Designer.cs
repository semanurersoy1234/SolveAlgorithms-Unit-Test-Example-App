namespace ce205_hw4_algorithms_gui
{
    partial class FormSmithWaterman
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
            this.sequence1RichTextBox = new System.Windows.Forms.RichTextBox();
            this.sequence2RichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gapPenaltyTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smith–Waterman";
            // 
            // sequence1RichTextBox
            // 
            this.sequence1RichTextBox.Location = new System.Drawing.Point(13, 49);
            this.sequence1RichTextBox.Name = "sequence1RichTextBox";
            this.sequence1RichTextBox.Size = new System.Drawing.Size(545, 41);
            this.sequence1RichTextBox.TabIndex = 1;
            this.sequence1RichTextBox.Text = "";
            // 
            // sequence2RichTextBox
            // 
            this.sequence2RichTextBox.Location = new System.Drawing.Point(13, 96);
            this.sequence2RichTextBox.Name = "sequence2RichTextBox";
            this.sequence2RichTextBox.Size = new System.Drawing.Size(545, 39);
            this.sequence2RichTextBox.TabIndex = 2;
            this.sequence2RichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(13, 142);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 13);
            this.scoreLabel.TabIndex = 4;
            // 
            // gapPenaltyTextBox
            // 
            this.gapPenaltyTextBox.Location = new System.Drawing.Point(12, 142);
            this.gapPenaltyTextBox.Name = "gapPenaltyTextBox";
            this.gapPenaltyTextBox.Size = new System.Drawing.Size(545, 20);
            this.gapPenaltyTextBox.TabIndex = 5;
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel2.Location = new System.Drawing.Point(214, 207);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(0, 31);
            this.scoreLabel2.TabIndex = 6;
            // 
            // FormSmithWaterman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 342);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.gapPenaltyTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sequence2RichTextBox);
            this.Controls.Add(this.sequence1RichTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormSmithWaterman";
            this.Text = "FormSmithWaterman";
            this.Load += new System.EventHandler(this.FormSmithWaterman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sequence1RichTextBox;
        private System.Windows.Forms.RichTextBox sequence2RichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox gapPenaltyTextBox;
        private System.Windows.Forms.Label scoreLabel2;
    }
}