namespace SpellingCorrection
{
    partial class SpellingCorrector
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
            this.components = new System.ComponentModel.Container();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WordLabel = new System.Windows.Forms.Label();
            this.ButtonWord = new System.Windows.Forms.Button();
            this.WordResultText = new System.Windows.Forms.Label();
            this.SentenceResultText = new System.Windows.Forms.Label();
            this.SentenceButton = new System.Windows.Forms.Button();
            this.SentenceText = new System.Windows.Forms.Label();
            this.SentenceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(130, 83);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(108, 20);
            this.WordBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Location = new System.Drawing.Point(59, 86);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(65, 13);
            this.WordLabel.TabIndex = 2;
            this.WordLabel.Text = "Insert Word:";
            // 
            // ButtonWord
            // 
            this.ButtonWord.Location = new System.Drawing.Point(130, 109);
            this.ButtonWord.Name = "ButtonWord";
            this.ButtonWord.Size = new System.Drawing.Size(75, 23);
            this.ButtonWord.TabIndex = 3;
            this.ButtonWord.Text = "Start";
            this.ButtonWord.UseVisualStyleBackColor = true;
            this.ButtonWord.Click += new System.EventHandler(this.ButtonWord_Click);
            // 
            // WordResultText
            // 
            this.WordResultText.AutoSize = true;
            this.WordResultText.Location = new System.Drawing.Point(285, 86);
            this.WordResultText.Name = "WordResultText";
            this.WordResultText.Size = new System.Drawing.Size(35, 13);
            this.WordResultText.TabIndex = 4;
            this.WordResultText.Text = "label1";
            // 
            // SentenceResultText
            // 
            this.SentenceResultText.AutoSize = true;
            this.SentenceResultText.Location = new System.Drawing.Point(174, 328);
            this.SentenceResultText.Name = "SentenceResultText";
            this.SentenceResultText.Size = new System.Drawing.Size(38, 13);
            this.SentenceResultText.TabIndex = 8;
            this.SentenceResultText.Text = "label 1";
            // 
            // SentenceButton
            // 
            this.SentenceButton.Location = new System.Drawing.Point(177, 280);
            this.SentenceButton.Name = "SentenceButton";
            this.SentenceButton.Size = new System.Drawing.Size(75, 23);
            this.SentenceButton.TabIndex = 7;
            this.SentenceButton.Text = "Start";
            this.SentenceButton.UseVisualStyleBackColor = true;
            this.SentenceButton.Click += new System.EventHandler(this.SentenceButton_Click);
            // 
            // SentenceText
            // 
            this.SentenceText.AutoSize = true;
            this.SentenceText.Location = new System.Drawing.Point(59, 208);
            this.SentenceText.Name = "SentenceText";
            this.SentenceText.Size = new System.Drawing.Size(108, 13);
            this.SentenceText.TabIndex = 6;
            this.SentenceText.Text = "Or Insert A Sentense:";
            // 
            // SentenceBox
            // 
            this.SentenceBox.Location = new System.Drawing.Point(177, 208);
            this.SentenceBox.Multiline = true;
            this.SentenceBox.Name = "SentenceBox";
            this.SentenceBox.Size = new System.Drawing.Size(223, 66);
            this.SentenceBox.TabIndex = 5;
            this.SentenceBox.WordWrap = false;
            // 
            // SpellingCorrector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SentenceResultText);
            this.Controls.Add(this.SentenceButton);
            this.Controls.Add(this.SentenceText);
            this.Controls.Add(this.SentenceBox);
            this.Controls.Add(this.WordResultText);
            this.Controls.Add(this.ButtonWord);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.WordBox);
            this.Name = "SpellingCorrector";
            this.Text = "Spelling Corrector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Button ButtonWord;
        private System.Windows.Forms.Label WordResultText;
        private System.Windows.Forms.Label SentenceResultText;
        private System.Windows.Forms.Button SentenceButton;
        private System.Windows.Forms.Label SentenceText;
        private System.Windows.Forms.TextBox SentenceBox;
    }
}

